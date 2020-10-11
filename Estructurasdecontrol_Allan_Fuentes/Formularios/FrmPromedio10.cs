using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estructurasdecontrol_Allan_Fuentes.Formularios
{
    public partial class FrmPromedio10 : Form
    {
        public FrmPromedio10()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btncancelar_Click(object sender, EventArgs e)
        {

            foreach (TextBox text in this.Controls.OfType<TextBox>())
            {
                text.Clear();
            }
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double to, n1, n2, n3, n4, n1_2, n2_2, n3_2, n4_2,n1_3,n2_3,n4_3,n3_3,n1_4,n2_4,n3_4,n4_4,n1_5,n2_5,n3_5,n4_5;
            double n1_6, n2_6, n3_6, n4_6, n1_7, n2_7, n3_7, n4_7, n1_8, n2_8, n3_8, n4_8, n1_9, n2_9, n3_9, n4_9, n1_10, n2_10, n3_10, n4_10;
            double to2, to3, to4, to5, to6, to7, to8, to9, to10, pro, pro2, pro3, pro4, pro5, pro6, pro7, pro8, pro9, pro10;
            n1 = double.Parse(textnota1_1.Text);
            n2 = double.Parse(textnota2_1.Text);
            n3 = double.Parse(textnota3_1.Text);
            n4 = double.Parse(textnota4_1.Text);
            n1_2= double.Parse(textnota1_2.Text);
            n2_2= double.Parse(textnota2_2.Text);
            n3_2= double.Parse(textnota3_2.Text);
            n4_2= double.Parse(textnota4_2.Text);
            n1_3= double.Parse(textnota1_3.Text);
            n2_3 = double.Parse(textnota2_3.Text);
            n3_3 = double.Parse(textnota3_3.Text);
            n4_3 = double.Parse(textnota4_4.Text);
            n1_4 = double.Parse(textnota1_4.Text);
            n2_4 = double.Parse(textnota2_4.Text);
            n3_4 = double.Parse(textnota3_4.Text);
            n4_4 = double.Parse(textnota4_4.Text);
            n1_5 = double.Parse(textnota1_5.Text);
            n2_5 = double.Parse(textnota2_5.Text);
            n3_5 = double.Parse(textnota3_5.Text);
            n4_5 = double.Parse(textnota4_5.Text);
            n1_6 = double.Parse(textnota1_6.Text);
            n2_6 = double.Parse(textnota2_6.Text);
            n3_6 = double.Parse(textnota3_6.Text);
            n4_6 = double.Parse(textnota4_6.Text);
            n1_7 = double.Parse(textnota1_7.Text);
            n2_7 = double.Parse(textnota2_7.Text);
            n3_7 = double.Parse(textnota3_7.Text);
            n4_7 = double.Parse(textnota4_7.Text);
            n1_8 = double.Parse(textnota1_8.Text);
            n2_8 = double.Parse(textnota2_8.Text);
            n3_8 = double.Parse(textnota3_8.Text);
            n4_8 = double.Parse(textnota4_8.Text);
            n1_9 = double.Parse(textnota1_9.Text);
            n2_9 = double.Parse(textnota2_9.Text);
            n3_9 = double.Parse(textnota3_9.Text);
            n4_9 = double.Parse(textnota4_9.Text);
            n1_10 = double.Parse(textnota1_10.Text);
            n2_10= double.Parse(textnota2_10.Text);
            n3_10= double.Parse(textnota3_10.Text);
            n4_10 = double.Parse(textnota4_10.Text);
            to = (n1 + n2 + n3 + n4) ;
            to2 = (n1_2 + n2_2 + n3_2 + n4_2);
            to3 = (n1_3 + n2_3 + n3_3 + n4_3);
            to4 = (n1_4 + n2_4 + n3_4 + n4_4);
            to5 = (n1_5 + n2_5 + n3_5 + n4_5);
            to6 = (n1_6 + n2_6 + n3_6 + n4_6);
            to7 = (n1_7 + n2_7 + n3_7 + n4_7);
            to8 = (n1_8 + n2_8 + n3_8 + n4_8);
            to9 = (n1_9 + n2_9 + n3_9 + n4_9);
            to10 = (n1_10 + n2_10 + n3_10 + n4_10);
            pro = to / 4;
            pro2 = to2 / 4;
            pro3 = to3 / 4;
            pro4 = to4 / 4;
            pro5 = to5 / 4;
            pro6 = to6 / 4;
            pro7 = to7 / 4;
            pro8 = to8 / 4;
            pro9 = to9 / 4;
            pro10 = to10 / 4;
            textprom1.Text = pro.ToString();
            textprom2.Text = pro2.ToString();
            textprom3.Text = pro3.ToString();
            textprom4.Text = pro4.ToString();
            textprom5.Text = pro5.ToString();
            textprom6.Text = pro6.ToString();
            textprom7.Text = pro7.ToString();
            textprom8.Text = pro8.ToString();
            textprom9.Text = pro9.ToString();
            textprom10.Text = pro10.ToString();

            if (pro >= 65)
            {
               
                

                textap1.Text = "Aprobado";
            }
            else
            {
             
               
                textap1.Text = "Reprobado";
            }
            if (pro2 >= 65)
            {
               
                

                textap2.Text = "Aprobado";
            }
            else
            {
                
                textap2.Text = "Reprobado";
            }
            if (pro3 >= 65)
            {
                
                

                textap3.Text = "Aprobado";
            }
            else
            {
             
                
                textap3.Text = "Reprobado";
            }
            if (pro4 >= 65)
            {
                
                

                textap4.Text = "Aprobado";
            }
            else
            {
               
               
                textap4.Text = "Reprobado";
            }
            if (pro5 >= 65)
            {
               
                textap5.Text = "Aprobado";
            }
            else
            {
                
               
                textap5.Text = "Reprobado";
            }
            if (pro6 >= 65)
            {
                
             

                textap6.Text = "Aprobado";
            }
            else
            {
                
                
                textap3.Text = "Reprobado";
            }
            if (pro7 >= 65)
            {
   
                textap7.Text = "Aprobado";
            }
            else
            {
              
                textap7.Text = "Reprobado";
            }
            if (pro8 >= 65)
            {
             
                textap8.Text = "Aprobado";
            }
            else
            {
               
                textap8.Text = "Reprobado";
            }
            if (pro9 >= 65)
            {
               

                textap9.Text = "Aprobado";
            }
            else
            {
             
                textap9.Text = "Reprobado";
            }
            if (pro10 >= 65)
            {
               

                textap10.Text = "Aprobado";
            }
            else
            {
                
                textap10.Text = "Reprobado";
            }
        }
    }
}
