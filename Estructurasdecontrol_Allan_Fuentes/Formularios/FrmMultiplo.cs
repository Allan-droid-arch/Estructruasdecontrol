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
    public partial class FrmMultiplo : Form
    {
        public FrmMultiplo()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

            
              for (int i = 0; i <= 300; i++)
            {
                if (i % 5 == 0)
                {
                    textmul.Text = textmul.Text + i+ ",".ToString();
                }
                
               
            }
           
            return;
        }
    }
}
