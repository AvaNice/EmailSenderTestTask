using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EmailSender
{
    public partial class SendControl : System.Web.UI.UserControl
    {
        private readonly AddressValidator _validator = new AddressValidator();
        private CookiesWorker _cookiesWorker;

        protected void Page_Load(object sender, EventArgs e)
        {
            _cookiesWorker = new CookiesWorker(Request);

            AddressLabel.Text = Resource.Address;
            MessageLabel.Text = Resource.Message;
            SendButton.Text = Resource.SendButton;
            InvalidAddressLabel.Text = Resource.InvalidAddress;

            //AddressTextBox.Text = _cookiesWorker.GetByName("Address");
            //MessageTextBox.Text = _cookiesWorker.GetByName("Message");
            
        }

        protected void SendButton_Click(object sender, EventArgs e)
        {
            InvalidAddressLabel.Visible = false;

            if (_validator.IsValideAddress(AddressTextBox.Text))
            {
                Response.Cookies.Add(_cookiesWorker.CreateCookie("Address", AddressTextBox.Text));
                Response.Cookies.Add(_cookiesWorker.CreateCookie("Message", MessageTextBox.Text));

                Response.Redirect("/ShippingNotice.aspx");
            }
            else
            {
                InvalidAddressLabel.Visible = true;
            }
        }

        private void Page_FormClosing(Object sender, EventArgs e)
        {

            int a = 5;
            a++;
            a++;
        }
    }
}