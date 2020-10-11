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
    public partial class FrmCompra_de_10_Productos : Form
    {
        public FrmCompra_de_10_Productos()
        {
            InitializeComponent();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void FrmCompra_de_10_Productos_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double total, tot=0;
            foreach(object item in listpre.Items)
            {
                total =  Convert.ToDouble(item);
                tot = tot + total;
                total1.Text = tot.ToString();
                
            }
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void textBox21_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            foreach (TextBox text in this.Controls.OfType<TextBox>())
            {
                text.Clear();

            }
            listname.Items.Clear();
            listpre.Items.Clear();
            listuni.Items.Clear();

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)

        {
            double c, d,to;
                c =double.Parse(uni1.Text);
            d = double.Parse(p1.Text);
            to = c * d;
            listname.Items.Add(name.Text);
            listuni.Items.Add(uni1.Text);
            listpre.Items.Add(to);
            if(listpre.Items.Count >10&& listname.Items.Count>10&&listuni.Items.Count>10 )
            {
                MessageBox.Show("Ha llegado al limite");
            }
        }

        private void listname_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            p1.Clear();
            uni1.Clear();
            name.Clear();
        }
    }
}
