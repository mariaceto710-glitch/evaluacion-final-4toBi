using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace evaluacion_final_4toBi
{
    public partial class Form3 : Form
    {
        private string potencia;
        private string potenciaProducto;

        public Form3(string potenciaProducto)
        {
            this.potenciaProducto = potenciaProducto;
        }

        public Form3()
        {
            InitializeComponent();
        }

        private void BtnProducto_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(TextVar1.Text);
            int num2 = int.Parse(TextVar2.Text);
            int producto = num1 + num2;
            MessageBox.Show("el resultado del producto es" + producto);
        }

        private void BtnSuma_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(TextVar1.Text);
            int num2 = int.Parse(TextVar2.Text);
            int suma = num1 + num2;
            MessageBox.Show("el resultado de la suma es" + suma);
        }

        private void BtnPotencia_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(TextVar1.Text);
            int num2 = int.Parse(TextVar2.Text);
            int num3 = 1;
            int potencia = 1;

            while (num3 != num2)
            {
                potencia = potencia * num1;
                num3 = num3 + 1;
            }
            MessageBox.Show("El resultado de la potencia es" + potencia);
        }

        private void BtnDivision_Click(object sender, EventArgs e)
        {
            float num1 = int.Parse(TextVar1.Text);
            float num2 = int.Parse(TextVar2.Text);

            if (num2 > 0)
            {
                float division = num1 / num2;
                MessageBox.Show("el resultado es" + division);
            }
            else
            {
                MessageBox.Show("la division es indefenida");

            }
        }
    }
}
