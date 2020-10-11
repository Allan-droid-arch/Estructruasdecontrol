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
    public partial class FrmMultiplicacion1 : Form
    {
        public FrmMultiplicacion1()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double n,to;
            for(int i=0; i <= 12; i++)
            {
                n = double.Parse(multiplicar.Text.Trim());
                if (n >= 1 && n<=10){
                    to = n * i;
                    respuesta.Text =respuesta.Text +n+"*"+i+":" +to+",".ToString();
                }
                else
                {
                    MessageBox.Show("Ingrese del 1 al 10");
                    return;
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            multiplicar.Clear();
            respuesta.Clear();
        }
    }
}
