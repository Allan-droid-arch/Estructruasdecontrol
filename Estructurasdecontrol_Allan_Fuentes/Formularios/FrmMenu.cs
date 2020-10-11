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
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Formularios.FrmPromedio promedio = new Formularios.FrmPromedio();
            promedio.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Formularios.FrmMayoryMenor mayor = new Formularios.FrmMayoryMenor();
            mayor.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Formularios.FrmPositivo_Negativo positivo = new Formularios.FrmPositivo_Negativo();
            positivo.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Formularios.FrmDoble_Cubo cubo = new Formularios.FrmDoble_Cubo();
            cubo.ShowDialog();
        }

        private void btnCompra_Click(object sender, EventArgs e)
        {
            Formularios.FrmCompra_de_Discos compra = new Formularios.FrmCompra_de_Discos();
            compra.ShowDialog();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnBoletos_Click(object sender, EventArgs e)
        {
            Formularios.FrmBoletos boleto = new Formularios.FrmBoletos();
            boleto.ShowDialog();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Formularios.FrmOrdenar ordenar = new Formularios.FrmOrdenar();
            ordenar.ShowDialog();


        }

        private void button6_Click(object sender, EventArgs e)
        {
            Formularios.FrmMultiplo mult = new Formularios.FrmMultiplo();
            mult.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Formularios.FrmPromedio10 promedio10 = new Formularios.FrmPromedio10();
            promedio10.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Formularios.FrmCompra_de_10_Productos compra = new Formularios.FrmCompra_de_10_Productos();
            compra.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Formularios.FrmPromedio_de_Edades edad = new Formularios.FrmPromedio_de_Edades();

            edad.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Formularios.Frmpro10 nota = new Formularios.Frmpro10();
            nota.ShowDialog();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Formularios.FrmMultiplicacion1 multi = new Formularios.FrmMultiplicacion1();
            multi.ShowDialog();

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Formularios.FrmPositivo_Negativo positivo = new Formularios.FrmPositivo_Negativo();
            positivo.ShowDialog();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Formularios.FrmSuma_del_1_al_100 suma = new Formularios.FrmSuma_del_1_al_100();
            suma.ShowDialog();

        }

        private void button13_Click(object sender, EventArgs e)
        {
            Formularios.Frm_100_hasta_200 mostrar = new Formularios.Frm_100_hasta_200();
            mostrar.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
