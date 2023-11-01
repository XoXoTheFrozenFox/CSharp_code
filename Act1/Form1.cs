using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Act1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 MyForm = new Form2();
            openToolStripMenuItem.Enabled = false;
            MyForm.MdiParent = this;
            MyForm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
