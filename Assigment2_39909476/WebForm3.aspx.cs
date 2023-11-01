//Bernard Swanepoel 39909476
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assigment2_39909476
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Styling of the document
            Calendar1.BackColor = System.Drawing.Color.Transparent;
            btnBack.BackColor = System.Drawing.Color.Transparent;

            //Makes so that you can't change the selected date on the calandar because of it being statically for 14 February 2023
            Calendar1.Enabled = false;

            HttpCookie theCookie = Request.Cookies["c1"];//Request the cookie called c1

            if ((theCookie != null) && (Session["calSelectedDate"] != null) && (Session["dateOfBooking"] != null) && (Session["timeOfBooking"] != null))//If none of the values are == to nothing then the statement will continue
            {

                Label1.Text = "Congratulations " + theCookie["name"]+ " " + theCookie["surName"] + ", you have sucessfully booked your " + theCookie["Seat"] + " seats for 2023 on valentines day to watch the Romeo and Juliet musical at the San Carlo Theater!";
                Label2.Text = "You will be emailed a week before the concert begins as a reminder and also recieve more information regarding the event, email: " + theCookie["email"]+" .";
                Label3.Text = "Payments are determined by the seat and payed at entrance. This booking was placed on: "+ Session["dateOfBooking"]+" "+ Session["timeOfBooking"]+" .";

                this.Calendar1.SelectedDate = this.Calendar1.VisibleDate = (DateTime)Session["calSelectedDate"];//Parse session calSelectedDate down to datetime so it can show in the calandar
            }
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebForm1.aspx");//Redirects you to the main page where data in entered and inserted in the database, there is also a admin page at the bottom where you can enter a password and go to the database page.
        }
    }
}