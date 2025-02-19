using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public Frm2 Frm2 { get; private set; }

        private void btnIngresa_Click(object sender, EventArgs e)
        {
            if(txtU.Text=="admin" && txtC.Text=="1234")
            {
                Frm2 = new Frm2();
                Frm2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("USUARIO O CONTRASEÑA INCORRECTO");

            }
        }
    }
}
