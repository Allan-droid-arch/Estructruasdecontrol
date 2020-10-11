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
    public partial class FrmCompra_de_Discos : Form
    {
        public FrmCompra_de_Discos()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
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

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double pre, un, des, to, subt;
            pre = Convert.ToDouble(textprecio.Text.Trim());
            un = Convert.ToDouble(textunidades.Text.Trim());
            subt = pre * un;

            if (un >= 3)
            {
                des = subt * 0.20;
                textdescuento.Text = des.ToString();

            }else
            {
                des = 0;
                textdescuento.Text = des.ToString();
            }
            to = subt - des;
            texttotal.Text = to.ToString();

        }
    }
}
