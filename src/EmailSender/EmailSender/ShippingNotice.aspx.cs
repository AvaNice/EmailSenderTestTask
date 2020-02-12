using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

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
    }
}