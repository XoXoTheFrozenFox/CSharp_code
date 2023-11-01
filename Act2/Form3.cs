using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Act2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        public string InstrumentName;

        private void btnContinue_Click(object sender, EventArgs e)
        {
            InstrumentName = txtInstrument.Text;
            this.Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            txtInstrument.Text = "";
        }
    }
}
