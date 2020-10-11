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
    public partial class Frm_100_hasta_200 : Form
    {
        public Frm_100_hasta_200()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double to = 0;
            for(int i = -100; i <= 200; i++)
            {
                
                numero.Items.Add(i);
            }
        }
    }
}
