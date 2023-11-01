using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PresentationCookiesAndSession
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie theCookie = Request.Cookies["Email"];
            HttpCookie theCookie2 = Request.Cookies["Address"];
            if((theCookie != null) && (theCookie2 != null) && (Session["RentalMovie"] != null))
            {
                Label1.Text = theCookie["Email"].ToString() + theCookie2["Address"].ToString() + Session["RentalMovie"].ToString();
            }
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebForm1.aspx");
        }
    }
}