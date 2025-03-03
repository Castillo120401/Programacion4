using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EXAMEN
{
    public partial class Form1 : Form
    {
        public object Private { get; private set; }

        public Form1()
        {
            //ingresamos datos para el combobox
            InitializeComponent();
            cbboxDia.Items.Add("1");
            cbboxDia.Items.Add("2");
            cbboxDia.Items.Add("3");
            cbboxDia.Items.Add("4");
            cbboxDia.Items.Add("5");
            cbboxDia.Items.Add("6");
            cbboxDia.Items.Add("7");
            cbboxDia.Items.Add("8");
            cbboxDia.Items.Add("9");
            cbboxDia.Items.Add("10");
            cbboxDia.Items.Add("11");
            cbboxDia.Items.Add("12");
            cbboxDia.Items.Add("13");
            cbboxDia.Items.Add("14");
            cbboxDia.Items.Add("15");
            cbboxDia.Items.Add("16");
            cbboxDia.Items.Add("17");
            cbboxDia.Items.Add("18");
            cbboxDia.Items.Add("19");
            cbboxDia.Items.Add("20");
            cbboxDia.Items.Add("21");
            cbboxDia.Items.Add("22");
            cbboxDia.Items.Add("23");
            cbboxDia.Items.Add("24");
            cbboxDia.Items.Add("25");
            cbboxDia.Items.Add("26");
            cbboxDia.Items.Add("27");
            cbboxDia.Items.Add("28");
            cbboxDia.Items.Add("29");
            cbboxDia.Items.Add("30");
            cbboxDia.Items.Add("31");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnsigno_Click(object sender, EventArgs e)
        {
            //agregamos un IF para seleccionar un dia en el combobox
            if (cbboxDia.SelectedIndex == -1)
            {
                MessageBox.Show("ingresa un dia");
            }
            //seleccion del dia
            int dia = int.Parse(cbboxDia.SelectedItem.ToString());
            //variable para guardar el mes
            string mes = "";

            //radiobutton seleccionado
            if (rbE.Checked) mes = "ENERO";
            else if (rbF.Checked) mes = "FEBRERO";
            else if (rbM.Checked) mes = "MARZO";
            else if (rbA.Checked) mes = "ABRIL";
            else if (rbMayo.Checked) mes = "MAYO";
            else if (rbJun.Checked) mes = "JUNIO";
            else if (rbJul.Checked) mes = "JULIO";
            else if (rbAgo.Checked) mes = "AGOSTO";
            else if (rbSep.Checked) mes = "SEPTIEMBRE";
            else if (rbOct.Checked) mes = "OCTUBRE";
            else if (rbNov.Checked) mes = "NOVIEMBRE";
            else if (rbDic.Checked) mes = "DICIEMBRE";

            //si no esta seleccionado un mes, tiene que mostrar un mensaje
            //el IsNullorEmapty nos ayuda para cuando queramos avanzar y no este seleccionado nos aparezca la opcion nula
            if (string.IsNullOrEmpty(mes))

            {
                MessageBox.Show("Por favor selecciona un mes");
                return;
                
            }
            string Signo = ObtenerSignoZodiacal(mes, dia);

            MessageBox.Show("Tu signo zodiacal es: " + Signo);
        }
       
            //metodo para obtener el signo zodical basado en el mes y dia

        private string ObtenerSignoZodiacal(string Mes, int Dia)
        {
            switch (Mes)
            {
                /*EN ENERO MARCAMOS EL SINGO EMPIEZA EL 20 Y ES MAYOR QUE 18 QUE ES EL DIA
                 * DE ESTA FOMRA LO REPRESENATMOS CADA MES*/
                case "ENERO":
                    return (Dia >= 20) ? "ACUARIO" : "CAPRICORNIO";
                case "FEBRERO":
                    return (Dia <= 18) ? "ACUARIO" : "PISCIS";
                case "MARZO":
                    return (Dia <= 20) ? "PISCIS" : "ARIES";
                case "ABRIL":
                    return (Dia <= 19) ? "ARIES" : "TAURO";
                case "MAYO":
                    return (Dia <= 20) ? "TAURO" : "GEMINIS";
                case "JUNIO":
                    return (Dia <= 20) ? "GEMINIS" : "CANCER";
                case "JULIO":
                    return (Dia <= 22) ? "CANCER" : "LEO";
                case "AGOSTO":
                    return (Dia <= 22) ? "LEO" : "VIRGO";
                case "SEPTIEMBRE":
                    return (Dia <= 22) ? "VIRGO" : "LIBRA";
                case "OCTUBRE":
                    return (Dia >= 22) ? "LIBRA" : "ESCORPIO";
                case "NOVIEMBRE":
                    return (Dia >= 21) ? "ESCORPIO" : "SAGITARIO";
                case "DICIEMBRE":
                    return (Dia <= 21) ? "SAGITARIO" : "CAPRICORNIO";
                default:
                    return "FECHA INVALIDA";// EN CASO DE ERROR
            }
        }
    }
}



