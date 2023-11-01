using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Act4
{
    public partial class WebForm1 : System.Web.UI.Page
    {

        protected void btnCash_Click(object sender, EventArgs e)
        {
            btnCash.Enabled = false;
            btnCard.Enabled = true;
        }

        protected void btnCard_Click(object sender, EventArgs e)
        {
            btnCash.Enabled = true;
            btnCard.Enabled = false;
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            if ((Calendar1.SelectedDate < Calendar1.TodaysDate) || (Calendar1.SelectedDate == Calendar1.TodaysDate))
            {
                lblError.Text = "Reservations can only be made 1 day in advance!";
            }
            else
            {
                if(btnCard.Enabled == false)
                {
                    lblError.Text = "The reservation was made on " + Calendar1.SelectedDate.ToString("yyyy/MM/dd") + " and will be payed with: " + btnCard.Text;
                }
                else if (btnCash.Enabled == false)
                {
                    lblError.Text = "The reservation was made on " + Calendar1.SelectedDate.ToString("yyyy/MM/dd") + " and will be payed with: " + btnCash.Text;
                }
                else
                {
                    lblError.Text = "Please select a type of payment: cash or card";
                }
            }
        }
    }
}