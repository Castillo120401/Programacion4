using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRACTICA3
{
    public partial class Form1 : Form
    {
     
 

        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
         double Radio = Convert.ToDouble(txt1.Text);
         double varea = Math.PI * Math.Pow(Radio, 2);
            lblR1.Text = varea.ToString("F2");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            double radio = Convert.ToDouble(txt1.Text);
            double P = 2 * Math.PI * radio;
            lblR2.Text = P.ToString("f2");

        }
    }
}
