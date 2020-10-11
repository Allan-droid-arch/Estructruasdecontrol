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
    public partial class FrmDoble_Cubo : Form
    {
        public FrmDoble_Cubo()
        {
            InitializeComponent();
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

        private void textCalcular_Click(object sender, EventArgs e)
        {
            double n, t;
            n = Convert.ToDouble(textDouble.Text.Trim());
            if (n>=10)
            {
                t = Math.Pow(n, 2);
                textResp.Text = t.ToString() +""+ "El numero fue elvado al cuadrado";

            }
            else
            {

                t = Math.Pow(n, 3);
                textResp.Text = t.ToString() +""+ "El numero fue elvado al cubo";

            }
        }
    }
}
