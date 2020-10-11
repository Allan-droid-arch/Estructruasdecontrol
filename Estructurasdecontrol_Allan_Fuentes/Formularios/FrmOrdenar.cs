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
    public partial class FrmOrdenar : Form
    {
        public FrmOrdenar()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

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

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double n1, n2;
            n1 = Convert.ToDouble(textprimer.Text.Trim());
            n2 = Convert.ToDouble(textsegundo.Text.Trim());
            if (n1<n2)
            {
                textresultado.Text = textprimer.Text +","+textsegundo.Text.ToString() ;
            }
            else
            {
                textresultado.Text = textsegundo.Text + "," + textprimer.Text.ToString();
            }
        }
    }
}
