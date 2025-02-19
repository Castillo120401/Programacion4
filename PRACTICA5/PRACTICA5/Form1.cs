using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRACTICA5
{
    public partial class Form1 : Form
    {
        // No guarda el indice selecionado en la tabla de dgvDatos
        int vindice=0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //linea de codigo para agregar en el combobox
            cbboxP.Items.Add("Mexico");
            cbboxP.Items.Add("Alemania"); 
            cbboxP.Items.Add("Belgica");
            cbboxP.Items.Add("España");
            cbboxP.Items.Add("China");
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            //se agrega una variable en tipo texto para hacer cadena de texto
            string vseleccion = Convert.ToString(cbboxP.Text);
            //linea de codigo que almacena en la variable indice
            int vindice = dgvDatos.Rows.Add();
            //lineas de codigo para que almacene su valor de cada dato en su celda correspondiente
            dgvDatos.Rows[vindice].Cells[0].Value = txtN.Text;
            dgvDatos.Rows[vindice].Cells[1].Value= txtA.Text;
            dgvDatos.Rows[vindice].Cells[2].Value = vseleccion;
            //borrar automaticamente
            txtN.Text = "";
            txtA.Text = "";
            cbboxP.Text = "";
        }

        private void dgvDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            //condicional con la que evualuamos que si 'vindice' es diferente o su valor no es -1 
            //entonces procoedemos a eliminar el item selecionado de lo contrario moastrara un msj de error
            if (vindice != -1)
            {
                //es para no borrar el encabezado
                dgvDatos.Rows.RemoveAt(vindice);
            }
             else
            {
                //muestra mensaje de error
                MessageBox.Show("Seleccion de item incorrecto");
            }
            
        }

        private void dgvDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            vindice = e.RowIndex;
        }
    }
}
