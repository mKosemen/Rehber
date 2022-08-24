using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonelDB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void checkBox1_Click(object sender, System.EventArgs e)
        {
            if (cbxSil.Checked)
            {
                btnGüncelle.Text = "SİL";
            }
            else
            {
                btnGüncelle.Text = "GÜNCELLE";
            }
        }
    }
}