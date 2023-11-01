//Bernard Swanepoel 39909476
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;//import this to use sqlcommands like SqlDataAdapter etc.
using System.Drawing.Printing;
using System.Data;//import this to use ds

namespace Assigment2_39909476
{
    public partial class WebForm1 : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            //Design of document to make it look nice.
            txtName.BackColor = System.Drawing.Color.Transparent;
            txtSurname.BackColor = System.Drawing.Color.Transparent;
            txtEmail.BackColor = System.Drawing.Color.Transparent;
            ddSeat.BackColor = System.Drawing.Color.Transparent;
            btnContinue.BackColor = System.Drawing.Color.Transparent;
            btnAdminPage.BackColor = System.Drawing.Color.Transparent;
            txtPassword.BackColor = System.Drawing.Color.Transparent;
            ddSeat.BorderColor = System.Drawing.Color.Red;
            ddSeat.BorderWidth = 2;
        }

        protected void btnContinue_Click(object sender, EventArgs e)
        {
            String name, surname, email, seat;

            name = txtName.Text;
            surname = txtSurname.Text;
            email = txtEmail.Text;
            seat = ddSeat.SelectedValue;

            HttpCookie theCookie = new HttpCookie("c1");//Create a new httpCookie called c1
            theCookie["name"] = txtName.Text;//give data to the cookie
            theCookie["surName"] = txtSurname.Text;
            theCookie["email"] = txtEmail.Text;
            theCookie["Seat"] = ddSeat.SelectedValue;
            theCookie.Expires = DateTime.Now.AddDays(7);//Makes so that the cookie exprires in 7 days
            Response.Cookies.Add(theCookie);

            Session["calSelectedDate"] = new DateTime(2023, 2, 14);
           
            DateTime dtDate = DateTime.Now; //Declare a new date time variable with value of now.
            Session["dateOfBooking"] = dtDate.ToString("dddd, dd MMMM yyyy");
            Session["timeOfBooking"] = dtDate.ToString("HH:mm:ss tt");

            WebForm2 myform = new WebForm2();
            try
            {

                myform.conn = new SqlConnection(myform.constr);//Make a new sqlconnection with connection string constr.Get these variables form webform 2 so the data can be used on that form(admin form).
                myform.conn.Open();//Open connection
                myform.conn.Close();// Close connection

                myform.conn = new SqlConnection(myform.constr);
                myform.conn.Open();
                myform.adap = new SqlDataAdapter();//Create a new sqladapter
                myform.ds = new DataSet();//Create a new sqlDataset
                string sql = "SELECT * FROM tblBookings";//Sql statment to select all the data from the database
                myform.comm = new SqlCommand(sql, myform.conn);
                myform.adap.SelectCommand = myform.comm;
                myform.adap.Fill(myform.ds, "SourceTable");
                myform.conn.Close();

                myform.conn = new SqlConnection(myform.constr);
                myform.conn.Open();
                myform.adap = new SqlDataAdapter();
                myform.ds = new DataSet();
                string sql2 = $"INSERT INTO tblBookings VAlUES('{email}','{name}','{surname}','{seat}','{dtDate.ToString("HH:mm:ss tt")}','{dtDate.ToString("dddd, dd MMMM yyyy")}')";//Insert sql that insertes these values into the ds so they can be used later in the datagrid.
                myform.comm = new SqlCommand(sql2, myform.conn);
                myform.adap.InsertCommand = myform.comm;//Selects the insert command 
                myform.adap.InsertCommand.ExecuteNonQuery();
                myform.conn.Close();//Closes the connection
            }
            catch (SqlException ex)
            {
                HttpContext.Current.Response.Write("<script>alert('" + Server.HtmlEncode(ex.Message) + "')</script>");//If there was an error, a message will show in form of a pop-up with the description of the database error.
            }

            Response.Redirect("WebForm3.aspx");
        }

        protected void btnAdminPage_Click(object sender, EventArgs e)
        {
            String Password1 = "WWSSADAD";//A password
            String Password2 = "Frikkie1234HouNieVan12481632";//A password
            String Password = txtPassword.Text;

            if ((Password == Password1) || (Password == Password2)) { Response.Redirect("WebForm2.aspx");}//If the password is typed in correctly it will redirect you to the admin page
            else { Response.Write("<script>alert('Wrong password entered, try again');</script>"); }
        }

        protected void txtName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}