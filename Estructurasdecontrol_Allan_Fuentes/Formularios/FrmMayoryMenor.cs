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
    public partial class FrmMayoryMenor : Form
    {
        public FrmMayoryMenor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            foreach (TextBox text in this.Controls.OfType<TextBox>())
            {
                text.Clear();

            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double n1, n2;
            n1 = Convert.ToDouble(textNum.Text.Trim());
            n2 = Convert.ToDouble(textnum1.Text.Trim());

            if (n1<n2)
            {
                textResu.Text = "El Menor es:"+ ""+ n1;
            }
            else
            {
                textResu.Text = "El Menor es: "+ "" + n2;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
