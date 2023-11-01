using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PresentationButtons
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Color clr = Color.FromArgb(255, 150, 255);
            Color clr2 = Color.FromArgb(255, 0, 100);
            Label1.Font.Bold = true;
            Label1.Font.Italic = true;
            Label1.Font.Underline = true;
            Label1.ForeColor = clr; 
            Button1.ForeColor = clr;
            Button2.ForeColor = clr;
            Button3.ForeColor = clr;
            Button3.ForeColor = clr;
            Button4.ForeColor = clr2;
            lblShow.ForeColor = clr2;
            //System.Drawing.color.IndianRed
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Button1.Enabled = false;
            Button2.Enabled = true;
            Button3.Enabled = true;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Button1.Enabled = true;
            Button2.Enabled = false;
            Button3.Enabled = true;
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Button1.Enabled = true;
            Button2.Enabled = true;
            Button3.Enabled = false;
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            if (Button1.Enabled == false)
            {
                lblShow.Text = "This student would like to book a lesson for the: " + Button1.Text;
            }
            else if (Button2.Enabled == false) 
            {
                lblShow.Text = "This student would like to book a lesson for the: " + Button2.Text;
            }
            else if (Button3.Enabled == false)
            {
                lblShow.Text = "This student would like to book a lesson for the: " + Button3.Text;
            }
            else
            {
                string sReturn = "None of the options were selected, select a option.";
                Response.Write("<script>alert('" + sReturn + "');</script>");
            }
        }
    }
}