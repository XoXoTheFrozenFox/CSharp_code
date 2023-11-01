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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public string InstrumentName;
        public string InstrumentType;
        public int Price;

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            InstrumentName = txtInstrument.Text;
            InstrumentType = txtType.Text;
            Price = int.Parse(txtPrice.Text);
            this.Close();
        }

        private void Form2_Load_1(object sender, EventArgs e)
        {

        }
    }
}
