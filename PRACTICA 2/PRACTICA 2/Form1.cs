using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRACTICA_2
{
    public partial class Form1 : Form
    {
        //VARIABLES 
        private object vResultado1;
        private object vResultado2;

        public Form1()
        {
            
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            vResultado1 = Convert.ToDecimal(Txt1.Text) * 9 / 5 + 32;
            lblResultado.Text = vResultado1.ToString() + "°F";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //El resultado2 tenemos que seguir el orden matematico para que se pueda observar el resultado
            vResultado2 = (Convert.ToDecimal(txt2.Text) - 32) * 5 / 9;
            lblresultado2.Text = vResultado2.ToString() + "°C";
        }
    }
}