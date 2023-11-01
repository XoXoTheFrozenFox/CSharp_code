using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;//

namespace Act1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        string constr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\CODE\Code\DEMI\Act1\Database1.mdf;Integrated Security=True; connect timeout = 30";
        SqlConnection conn;
        SqlCommand comm;
        SqlDataAdapter adap;
        DataSet ds;
        SqlDataReader dr;

        public void displayAll()
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

            cmbDelete.Items.Clear();
            try
            {
                conn.Open();
                string sql;
                sql = "SELECT DISTINCT * FROM [Table]";
                comm = new SqlCommand(sql, conn);
                dr = comm.ExecuteReader();
                while (dr.Read())
                {
                    cmbDelete.Items.Add(dr.GetValue(0));
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
            displayAll();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
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

            displayAll();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                adap = new SqlDataAdapter();
                ds = new DataSet();
                string sql = "SELECT * FROM [Table] WHERE CutDifficult = '" + txtDifficulty.Text + "'";
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
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                adap = new SqlDataAdapter();
                ds = new DataSet();
                string sql = "SELECT * FROM [Table] WHERE DogType LIKE '%"+ txtDogBreed.Text +"%' ";
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
        }

        private void btnSelectBetween_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                adap = new SqlDataAdapter();
                ds = new DataSet();
                string sql = "SELECT * FROM [Table] WHERE PricePerWash BETWEEN 150 AND 300";
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
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                adap = new SqlDataAdapter();
                string sql = "DELETE FROM [Table] WHERE DogType = '" + cmbDelete.Text + "' ";
                comm = new SqlCommand(sql, conn);
                adap.DeleteCommand = comm;
                adap.DeleteCommand.ExecuteNonQuery();
                MessageBox.Show("Record deleted sucessfully");
                conn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            displayAll();
        }
        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                adap = new SqlDataAdapter();
                string sql = "INSERT INTO [Table](DogType,PricePerCut,PricePerWash,CutDifficult) VALUES('"+txtInsertDogType.Text+ "'," + txtInsertPricePerWash.Text + "," + txtInsertPricePerCut.Text + "," + txtInsertCutDifficult.Text + ")";
                comm = new SqlCommand(sql, conn);
                adap.InsertCommand = comm;
                adap.InsertCommand.ExecuteNonQuery();
                MessageBox.Show("Record inseted sucessfully");
                conn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            displayAll();
        }
    }
}
