using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estructurasdecontrol_Allan_Fuentes.Formularios
{
    public partial class FrmPromedio_de_Edades : Form
    {
        public FrmPromedio_de_Edades()
        {
            InitializeComponent();
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
           
            
            if ( nombre.Text.Trim().Length==0) 

            {
                MessageBox.Show("Ingrese el nombre ");
                
                return;
            }
            
            if (edad.Text.Trim().Length == 0)
            {
                MessageBox.Show("Ingrese la edad");
                
                return;
            }
            
            listnombre.Items.Add(nombre.Text.Trim());
            listedad.Items.Add(edad.Text.Trim());
            if (listnombre.Items.Count > 10 && listedad.Items.Count > 10)
            {
                MessageBox.Show("Ha llegado al limite");
                nombre.Focus();
            }
            edad.Clear();
            nombre.Clear();
            nombre.Focus();
            
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double to = 0,pro;
            foreach(object item in listedad.Items)
            {
                to +=Convert.ToDouble(item);
                pro = to / 10;
                promedio.Text = pro.ToString();

            }
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            listedad.Items.Clear();
            listnombre.Items.Clear();
            promedio.Clear();
        }
    }
}
