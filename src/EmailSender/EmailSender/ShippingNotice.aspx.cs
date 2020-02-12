using System;

namespace EmailSender
{
    public partial class ShippingNotice : System.Web.UI.Page
    {
        private CookiesWorker _cookiesWorker;

        protected void Page_Load(object sender, EventArgs e)
        {
            _cookiesWorker = new CookiesWorker(Request);

            ShippingNoticeOKButton.Text = Resource.OK;
            ShippingResultLabel.Text = $"{Resource.ShippingResult}{_cookiesWorker.GetByName("Address")}";
        }

        protected void ShippingNoticeOKButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Default.aspx");
        }
    }
}