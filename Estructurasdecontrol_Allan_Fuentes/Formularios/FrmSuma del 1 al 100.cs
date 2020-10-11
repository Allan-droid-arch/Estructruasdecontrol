using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estructurasdecontrol_Allan_Fuentes.Formularios
{
    public partial class FrmSuma_del_1_al_100 : Form
    {
        public FrmSuma_del_1_al_100()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double n = 0;
            for (int i = 1; i <= 100; i++)
            {
                n = i*(i + 1) / 2;
                suma.Text =  n.ToString();
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            suma.Clear();
        }
    }
}
