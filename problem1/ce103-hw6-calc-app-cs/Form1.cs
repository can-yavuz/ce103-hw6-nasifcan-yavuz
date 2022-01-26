using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fullCalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            basicCalc.Form1 frm = new basicCalc.Form1();
            DialogResult dialogResult = frm.ShowDialog();

        }

        private void btnGraphCalc_Click(object sender, EventArgs e)
        {
            GraphCalc.CalcForm frm = new GraphCalc.CalcForm();
            DialogResult dialogResult = frm .ShowDialog();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
