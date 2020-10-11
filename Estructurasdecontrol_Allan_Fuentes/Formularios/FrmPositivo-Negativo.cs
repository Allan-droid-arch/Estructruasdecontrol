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
    public partial class FrmPositivo_Negativo : Form
    {
        public FrmPositivo_Negativo()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textre_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

            foreach (TextBox text in this.Controls.OfType<TextBox>())
            {
                text.Clear();

            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            double n;
            n = Convert.ToDouble(textne.Text.Trim());
            if (n >= 0)
            {
                textre.Text = " Positivo ";

            }
            else
            {
               
                textre.Text =  " Negativo";
            }
        }
    }
}
