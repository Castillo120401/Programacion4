using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_5._1
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btnC_Click(object sender, EventArgs e)
        {

            //VariableS
            int Vp1, Vp2, Vp3;
            double VPromedio;
            string VNom;
            //ingresar datos al dgv
            int vdgv = dgvDatos.Rows.Add(); ;
            //entrada de datos
            VNom = Convert.ToString(txtN.Text);
            Vp1 = Convert.ToInt32(txtP1.Text);
            Vp2 = Convert.ToInt32(txtP2.Text);
            Vp3 = Convert.ToInt32(txtP3.Text);
            //AGREAR AL DGV
            dgvDatos.Rows[vdgv].Cells[0].Value = VNom;
            dgvDatos.Rows[vdgv].Cells[1].Value = Vp1;
            dgvDatos.Rows[vdgv].Cells[2].Value = Vp2;
            dgvDatos.Rows[vdgv].Cells[3].Value = Vp3;
            //CALCULAR PROMEDIO SE SUMAN LAS NOTAS Y SE DIVIDE

            VPromedio = (Vp1 + Vp2 + Vp3) / 3;
            lblP.Text = VPromedio.ToString();

            //INGRESAMOS UN IF PARA PONER LAS CONDICIONES
            if (VPromedio >= 95)
            {
                MessageBox.Show(" Tu Calificacion es " + VPromedio + " EXENTO :3 ");
            }

            else if (VPromedio >= 70 && VPromedio < 94)
            {
                MessageBox.Show(" Tu Calificacion es " + VPromedio + " ORDINARIO :) ");
            }
            else if (VPromedio >= 50 && VPromedio < 69)
            {
                MessageBox.Show(" Tu Calificacion es " + VPromedio + " EXTRAORDINARIO :( ");
            }
            else if (VPromedio <= 49)
            {
                MessageBox.Show(" Tu Calificacion es  " + VPromedio + "  ESPECIAL :C  ");
            }
            dgvDatos.Rows[vdgv].Cells[4].Value = VPromedio;
            
           
        } 

        
          

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnB_Click(object sender, EventArgs e)
        {
            //indicamos que el boton borre los resultados
     
            txtN.Text = "";

            txtP1.Text = "";
            txtP2.Text = "";
            txtP3.Text = "";
        }

        private void dgvDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
