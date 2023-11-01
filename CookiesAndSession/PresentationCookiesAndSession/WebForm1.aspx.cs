using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PresentationCookiesAndSession
{
    public partial class WebForm1 : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebForm2.aspx");
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            HttpCookie Cookie = new HttpCookie("Email");
            Cookie["Email"] = TextBox1.Text;
            Cookie.Expires = DateTime.Now.AddDays(7);
            Response.Cookies.Add(Cookie);
        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {
            HttpCookie Cookie = new HttpCookie("Address");
            Cookie["Address"] = TextBox2.Text;
            Cookie.Expires = DateTime.Now.AddDays(7);
            Response.Cookies.Add(Cookie);
        }

        protected void TextBox3_TextChanged(object sender, EventArgs e)
        {
            Session["RentalMovie"] = TextBox3.Text;
        }
    }
}