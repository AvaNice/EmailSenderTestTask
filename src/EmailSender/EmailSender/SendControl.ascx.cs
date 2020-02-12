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
        private readonly IAddressValidator _validator = new AddressValidator();
        private ICookiesWorker _cookiesWorker;

        protected void Page_Load(object sender, EventArgs e)
        {
            _cookiesWorker = new CookiesWorker(Request);

            AddressLabel.Text = Resource.Address;
            MessageLabel.Text = Resource.Message;
            SendButton.Text = Resource.SendButton;
            InvalidAddressLabel.Text = Resource.InvalidAddress;


            var addressCoocieValue = _cookiesWorker.GetByName("Address");
            var messageCoocieValue = _cookiesWorker.GetByName("Message");


            if (AddressTextBox.Text == string.Empty)
            {
                AddressTextBox.Text = addressCoocieValue;
            }

            if (MessageTextBox.Text == string.Empty)
            {
                MessageTextBox.Text = messageCoocieValue;
            }
        }

        protected void SendButton_Click(object sender, EventArgs e)
        {
            InvalidAddressLabel.Visible = false;

            Response.Cookies.Add(_cookiesWorker.CreateCookie("Address", AddressTextBox.Text));
            Response.Cookies.Add(_cookiesWorker.CreateCookie("Message", MessageTextBox.Text));

            if (_validator.IsValideAddress(AddressTextBox.Text))
            {
                Response.Redirect("/ShippingNotice.aspx");
            }
            else
            {
                InvalidAddressLabel.Visible = true;
            }
        }

        protected void MessageTextBox_TextChanged(object sender, EventArgs e)
        {
            Response.Cookies.Add(_cookiesWorker.CreateCookie("Message", MessageTextBox.Text));
        }

        protected void AddressTextBox_TextChanged(object sender, EventArgs e)
        {
            Response.Cookies.Add(_cookiesWorker.CreateCookie("Address", AddressTextBox.Text));
        }
    }
}