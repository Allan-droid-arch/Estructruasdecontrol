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
    public partial class FrmBoletos : Form
    {
        public FrmBoletos()
        {
            InitializeComponent();
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
            double uni, pre, to;
            uni = Convert.ToDouble(textunidades1.Text.Trim());
            if (uni >= 10)
            {
                pre = 80;
                textprecio1.Text =pre.ToString() ;
            }
            else
            {
                pre = 100;
                textprecio1.Text = pre.ToString();
            }
            to = uni * pre;
            textTotal.Text = to.ToString();
        }
    }
}
