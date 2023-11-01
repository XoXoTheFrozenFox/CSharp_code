using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Act2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string constr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\CODE\Code\DEMI\Act2\Database1.mdf;Integrated Security=True";
        SqlConnection conn;
        SqlCommand comm;
        SqlDataAdapter adap;
        DataSet ds;
        SqlDataReader dr;

        public void DisplayAll()
        {
            try
            {  
                conn.Open();
                adap = new SqlDataAdapter();
                ds = new DataSet();
                string sql = "SELECT * FROM [Table]";
                comm = new SqlCommand(sql, conn);
                adap.SelectCommand = comm;
                adap.Fill(ds, "SourceTable");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "SourceTable";
                conn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            listBox1.Items.Clear();
            try
            {
                conn.Open();
                string sql = "SELECT * FROM [Table]";
                comm = new SqlCommand(sql, conn);
                dr = comm.ExecuteReader();
                while (dr.Read())
                {
                    listBox1.Items.Add(dr.GetValue(0) + "\t" + dr.GetValue(1) + "\t\t" + dr.GetValue(2));
                }
                conn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //textbox
        //combobox
        private void Form1_Load(object sender, EventArgs e)
        {
            hScrollBar1.Maximum = 10000;
            hScrollBar1.Minimum = 1;
            hScrollBar1.SmallChange = 1;
            hScrollBar1.LargeChange = 1;
            try
            {
                conn = new SqlConnection(constr);
                conn.Open();
                conn.Close();
                MessageBox.Show("Database connection Sucessful");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            DisplayAll();
        }

        public void insert()
        {   
            //NAME,SURNAME and AGE
            Form2 myForm = new Form2();
            myForm.ShowDialog();///////////
            try
            {   //NAME SURNAME AGE
                //INSERT INTO TABLE VALUES('{NAME}','{SURNAME}',{AGE});
                string insert_query = $"INSERT INTO [Table] VALUES('{myForm.InstrumentName}','{myForm.InstrumentType}',{myForm.Price})";
                conn = new SqlConnection(constr);
                conn.Open();
                SqlDataAdapter adap = new SqlDataAdapter();
                comm = new SqlCommand(insert_query, conn);
                adap.InsertCommand = comm;
                adap.InsertCommand.ExecuteNonQuery();
                MessageBox.Show("Record inserted sucessfully!");
                conn.Close();
                DisplayAll();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            insert();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
           this.Close();
        }
        public void delete()
        {
            Form3 myForm = new Form3();
            myForm.ShowDialog();
            try
            {
                string insert_query = $"DELETE FROM [Table] WHERE Instrument = '" + myForm.InstrumentName + "'";
                conn = new SqlConnection(constr);
                conn.Open();
                SqlDataAdapter adap = new SqlDataAdapter();
                comm = new SqlCommand(insert_query, conn);
                adap.DeleteCommand = comm;
                adap.DeleteCommand.ExecuteNonQuery();
                MessageBox.Show("Record deleted sucessfully!");
                conn.Close();
                DisplayAll();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            delete();
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            label1.Text = hScrollBar1.Value.ToString();
            try
            {
                conn.Open();
                adap = new SqlDataAdapter();
                ds = new DataSet();
                string sql = "SELECT * FROM [Table] WHERE averagePrice <= " + hScrollBar1.Value + "";
                comm = new SqlCommand(sql, conn);
                adap.SelectCommand = comm;
                adap.Fill(ds, "SourceTable");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "SourceTable";
                conn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            listBox1.Items.Clear();
            try
            {
                conn.Open();
                string sql = "SELECT * FROM [Table] WHERE averagePrice <= " + hScrollBar1.Value + "";
                comm = new SqlCommand(sql, conn);
                dr = comm.ExecuteReader();
                while (dr.Read())
                {
                    listBox1.Items.Add(dr.GetValue(0) + "\t" + dr.GetValue(1) + "\t\t" + dr.GetValue(2));
                }
                conn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDisplayAll_Click(object sender, EventArgs e)
        {
            DisplayAll();
        }
    }
}
