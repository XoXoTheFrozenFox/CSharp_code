//Bernard Swanepoel 39909476
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;//Used to get the sql variables like SqlConnection
using System.Drawing.Printing;
using System.Data;// Used to get the DataSet

namespace Assigment2_39909476
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        //All the variables needed to do databasemanupilation effectively
        public SqlConnection conn;
        public SqlCommand comm;
        public SqlDataAdapter adap;
        public DataSet ds;
        public string constr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\CODE\Code\DEMI\PRESENTATIONS\Assigment2_39909476\App_Data\dbBookings.mdf;Integrated Security=True";
        public SqlDataReader dr;

        public void load()//A method that contains all the standard select all statements in the ds code.
        {
            try
            {
                conn = new SqlConnection(constr);
                conn.Open();
                adap = new SqlDataAdapter();
                ds = new DataSet();
                string sql = "SELECT * FROM tblBookings";
                comm = new SqlCommand(sql, conn);
                adap.SelectCommand = comm;
                adap.Fill(ds, "SourceTable");
                dr = comm.ExecuteReader();
                while (dr.Read())
                {
                    if (DropDownList1.Items.FindByValue(dr["email"].ToString()) == null)//Is used to take away all the duplicate records in a dropdownlist
                    {
                        DropDownList1.Items.Add(dr["email"].ToString());
                    }

                    if (DropDownList2.Items.FindByValue(dr["email"].ToString()) == null)
                    {
                        DropDownList2.Items.Add(dr["email"].ToString());
                    }
                }
                GridView1.DataSource = ds;
                GridView1.DataBind();
                conn.Close();
            }
            catch (SqlException ex)
            {
                HttpContext.Current.Response.Write("<script>alert('" + Server.HtmlEncode(ex.Message) + "')</script>");
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            //Styling of the page
            GridView1.BackColor = System.Drawing.Color.Transparent;
            btnBack.BackColor = System.Drawing.Color.Transparent;
            btnDelete.BackColor = System.Drawing.Color.Transparent;
            btnNormal.BackColor = System.Drawing.Color.Transparent;
            btnVIP.BackColor = System.Drawing.Color.Transparent;
            txtName.BackColor = System.Drawing.Color.Transparent;
            txtEmail.BackColor = System.Drawing.Color.Transparent;
            txtSurname.BackColor = System.Drawing.Color.Transparent;
            btnVIPplus.BackColor = System.Drawing.Color.Transparent;
            btnDelete.BackColor = System.Drawing.Color.Transparent;
            btnDelete.BackColor = System.Drawing.Color.Transparent;
            btnReset.BackColor = System.Drawing.Color.Transparent;
            btnNameUpdate.BackColor = System.Drawing.Color.Transparent;
            btnSurnameUpdate.BackColor = System.Drawing.Color.Transparent;
            btnNameUpdate.BorderColor = System.Drawing.Color.Red;
            btnSurnameUpdate.BorderColor = System.Drawing.Color.Red;
            btnNameUpdate.BorderWidth = 2;
            btnSurnameUpdate.BorderWidth = 2;
            txtNameUpdate.BackColor = System.Drawing.Color.Transparent;
            txtSurnameUpdate.BackColor = System.Drawing.Color.Transparent;
            DropDownList1.BackColor = System.Drawing.Color.Transparent;
            DropDownList1.BorderWidth = 2;
            DropDownList1.BorderColor = System.Drawing.Color.Red;
            DropDownList2.BackColor = System.Drawing.Color.Transparent;
            DropDownList2.BorderWidth = 2;
            DropDownList2.BorderColor = System.Drawing.Color.Red;
            try
            {
                conn = new SqlConnection(constr);
                conn.Open();
                conn.Close();
            }
            catch (Exception ex)
            {
                HttpContext.Current.Response.Write("<script>alert('" + Server.HtmlEncode(ex.Message) + "')</script>");
            }
            load();
        }

        protected void btnContinue_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebForm1.aspx");
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(constr);
                conn.Open();
                adap = new SqlDataAdapter();
                string sql2 = "DELETE FROM tblBookings WHERE email = '"+ DropDownList1.SelectedValue +"'";//Deletes a record where the selected index in the dropdownlist is = to the record in a database.
                DropDownList1.Items.Clear();
                DropDownList2.Items.Clear();
                comm = new SqlCommand(sql2, conn);
                adap.DeleteCommand = comm;
                adap.DeleteCommand.ExecuteNonQuery();
                load();
                conn.Close();
            }
            catch (SqlException ex)
            {
                HttpContext.Current.Response.Write("<script>alert('" + Server.HtmlEncode(ex.Message) + "')</script>");
            }
        }

        protected void btnNormal_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(constr);
                conn.Open();
                adap = new SqlDataAdapter();
                ds = new DataSet();
                string sql = "SELECT * FROM tblBookings WHERE Seat= 'normal'";//Selects all seats where the seat record is = to normal
                comm = new SqlCommand(sql, conn);
                adap.SelectCommand = comm;
                adap.Fill(ds, "SourceTable");
                GridView1.DataSource = ds;
                GridView1.DataBind();
                conn.Close();
            }
            catch (SqlException ex)
            {
                HttpContext.Current.Response.Write("<script>alert('" + Server.HtmlEncode(ex.Message) + "')</script>");
            }
        }

        protected void btnVIP_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(constr);
                conn.Open();
                adap = new SqlDataAdapter();
                ds = new DataSet();
                string sql = "SELECT * FROM tblBookings WHERE Seat= 'VIP'";//Selects all seats where the seat record is = to VIP
                comm = new SqlCommand(sql, conn);
                adap.SelectCommand = comm;
                adap.Fill(ds, "SourceTable");
                GridView1.DataSource = ds;
                GridView1.DataBind();
                conn.Close();
            }
            catch (SqlException ex)
            {
                HttpContext.Current.Response.Write("<script>alert('" + Server.HtmlEncode(ex.Message) + "')</script>");
            }
        }

        protected void btnVIPplus_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(constr);
                conn.Open();
                adap = new SqlDataAdapter();
                ds = new DataSet();
                string sql = "SELECT * FROM tblBookings WHERE Seat= 'VIP+'";//Selects all seats where the seat record is = to VIP+
                comm = new SqlCommand(sql, conn);
                adap.SelectCommand = comm;
                adap.Fill(ds, "SourceTable");
                GridView1.DataSource = ds;
                GridView1.DataBind();
                conn.Close();
            }
            catch (SqlException ex)
            {
                HttpContext.Current.Response.Write("<script>alert('" + Server.HtmlEncode(ex.Message) + "')</script>");
            }
        }

        protected void txtName_TextChanged(object sender, EventArgs e)
        {
            txtSurname.Text = "";
            txtEmail.Text = "";
            try
            {
                conn = new SqlConnection(constr);
                conn.Open();
                adap = new SqlDataAdapter();
                ds = new DataSet();
                string sql = "Select * from tblBookings WHERE name = '" + txtName.Text + "'";//Selects all records where the typed name in the textbox is = to a name field in a database record
                comm = new SqlCommand(sql, conn);
                adap.SelectCommand = comm;
                adap.Fill(ds, "SourceTable");
                GridView1.DataSource = ds;
                GridView1.DataBind();
                conn.Close();
            }
            catch (SqlException ex)
            {
                HttpContext.Current.Response.Write("<script>alert('" + Server.HtmlEncode(ex.Message) + "')</script>");
            }
        }

        protected void txtSurname_TextChanged(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtEmail.Text = "";
            try
            {
                conn = new SqlConnection(constr);
                conn.Open();
                adap = new SqlDataAdapter();
                ds = new DataSet();
                string sql = "Select * from tblBookings WHERE surname = '" + txtSurname.Text + "'";//Selects all records where the typed surname in the textbox is = to a surname field in a database record
                comm = new SqlCommand(sql, conn);
                adap.SelectCommand = comm;
                adap.Fill(ds, "SourceTable");
                GridView1.DataSource = ds;
                GridView1.DataBind();
                conn.Close();
            }
            catch (SqlException ex)
            {
                HttpContext.Current.Response.Write("<script>alert('" + Server.HtmlEncode(ex.Message) + "')</script>");
            }
        }

        protected void txtEmail_TextChanged(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtSurname.Text = "";
            try
            {
                conn = new SqlConnection(constr);
                conn.Open();
                adap = new SqlDataAdapter();
                ds = new DataSet();
                string sql = "SELECT * FROM tblBookings WHERE email LIKE '" + txtEmail.Text + "'";//Selects all records where the typed email in the textbox is = to a email field in a database record
                comm = new SqlCommand(sql, conn);
                adap.SelectCommand = comm;
                adap.Fill(ds, "SourceTable");
                GridView1.DataSource = ds;
                GridView1.DataBind();
                conn.Close();
            }
            catch (SqlException ex)
            {
                HttpContext.Current.Response.Write("<script>alert('" + Server.HtmlEncode(ex.Message) + "')</script>");
            }
        }

        protected void btnReset_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtSurname.Text = "";
            txtEmail.Text = "";
            load();//Calls the load void function declared earlier
        }

        protected void btnNameUpdate_Click(object sender, EventArgs e)
        {
            txtSurnameUpdate.Text = "";
            try
            {
                conn = new SqlConnection(constr);
                conn.Open();
                adap = new SqlDataAdapter();
                ds = new DataSet();
                string sql = $"UPDATE tblBookings SET name = '" + txtNameUpdate.Text + "' WHERE email = '" + DropDownList2.SelectedValue + "'";//Update the name field where the selected email in the dropdownlist is = to a email field in the database.
                comm = new SqlCommand(sql, conn);
                adap.SelectCommand = comm;
                adap.Fill(ds, "SourceTable");
                load();
                conn.Close();
            }
            catch (SqlException ex)
            {
                HttpContext.Current.Response.Write("<script>alert('" + Server.HtmlEncode(ex.Message) + "')</script>");//Shows a pop-up when there was a database error with the description of the error(ex.message).
            }
        }


        protected void btnSurnameUpdate_Click(object sender, EventArgs e)
        {
            txtNameUpdate.Text = "";
            try
            {
                conn = new SqlConnection(constr);
                conn.Open();
                adap = new SqlDataAdapter();
                ds = new DataSet();
                string sql = $"UPDATE tblBookings SET surname = '"+txtSurnameUpdate.Text+"' WHERE email = '" + DropDownList2.SelectedValue + "'";//Update the surname field where the selected email in the dropdownlist is = to a email field in the database.
                comm = new SqlCommand(sql, conn);
                adap.SelectCommand = comm;
                adap.Fill(ds, "SourceTable");
                load();
                conn.Close();
            }
            catch (SqlException ex)
            {
                HttpContext.Current.Response.Write("<script>alert('" + Server.HtmlEncode(ex.Message) + "')</script>");
            }
        }
    }

}