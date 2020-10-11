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
    public partial class FrmPromedio : Form
    {
        public FrmPromedio()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double n1, n2, n3, i, pro;
             string r, a;
            n1 = Convert.ToDouble(textNota1.Text.Trim());
            n2 = Convert.ToDouble(textNota2.Text.Trim());
            n3 = Convert.ToDouble(textNota3.Text.Trim());

            pro = (n1 + n2 + n3) / 3;

            if (pro >= 65)
            {
                a = "Aprobado";
                textAyR.Text = a;

            }
            else
            {
                textAyR.Text = "Reprobado";
            }
            textPromedio.Text = pro.ToString();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            foreach (TextBox text in this.Controls.OfType<TextBox>())
            {
                text.Clear();

            }
        }
    }
}
