using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estructurasdecontrol_Allan_Fuentes.Formularios
{
    public partial class Frmpro10 : Form
    {
        int Contador = 0, Contador1=0;
        public Frmpro10()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnagregar_Click(object sender, EventArgs e)
        {

            if (alumno.Text.Trim().Length == 0)
            {
                MessageBox.Show("Ingrese el nombre del alumno");
                alumno.Focus();
                return;
            }
            if (nota.Text.Trim().Length == 0)
            {
                MessageBox.Show("Ingrese la nota");
                nota.Focus();
                return;
            }

            listnombre.Items.Add(alumno.Text.Trim());
            listnota.Items.Add(nota.Text.Trim());

            double cal;


            cal = double.Parse(nota.Text.Trim());
            if (cal >= 65)
            {
                listobsevacion.Items.Add("Aprobado");


                Contador++;
            }
            if (cal < 65)
            {
                listobsevacion.Items.Add("Reprobado");



                Contador1++;



                
            }

            aprobado.Text = Contador.ToString();
            reprobado.Text = Contador1.ToString();
            alumno.Clear();
            nota.Clear();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            listnombre.Items.Clear();
            listnota.Items.Clear();
            listobsevacion.Items.Clear();
            aprobado.Clear();
            reprobado.Clear();
        }

        private void Frmpro10_Load(object sender, EventArgs e)
        {

        }
    }
    }
 
