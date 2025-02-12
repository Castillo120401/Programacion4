using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica01
{

    // VARIABLES

    public partial class Form1 : Form
    {
        private object vResultado;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            vResultado = Convert.ToInt32(txtNum1.Text) + Convert.ToInt32(txtNum2.Text);
            lblResultado.Text = vResultado.ToString();
            lblsingo.Text = "+";
        }

        private void txtNum2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            vResultado = Convert.ToInt32(txtNum1.Text) - Convert.ToInt32(txtNum2.Text);
            lblResultado.Text = vResultado.ToString();
            lblsingo.Text = "-";
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            vResultado = Convert.ToInt32(txtNum1.Text) * Convert.ToInt32(txtNum2.Text);
            lblResultado.Text = vResultado.ToString();
            lblsingo.Text = "X";
        }

        private void btnDivi_Click(object sender, EventArgs e)
        {
            vResultado = Convert.ToInt32(txtNum1.Text) / Convert.ToInt32(txtNum2.Text);
            lblResultado.Text = vResultado.ToString();
            lblsingo.Text = "/";
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNum1.Text = " ";
            txtNum2.Text = "";
            lblResultado.Text = "000";
            lblsingo.Text = "|";
        }
    }
}
