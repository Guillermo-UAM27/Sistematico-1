using Operaciones.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Operaciones
{
    public partial class Form1 : Form
    {
        OperacionesMat operaciones = new OperacionesMat();
        public Form1()
        {
            InitializeComponent();
        }
        

        private void LblMostrarResultados_Click(object sender, EventArgs e)
        {

        }


        private void BtnResta_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(TbNum1.Text);
            int num2 = int.Parse(TbNum2.Text);

            double resultado = operaciones.Restando(num1,num2);
            LblMostrarResultados.Text = "Resultado: " + resultado.ToString();

        }

        private void BtnMultiplicacion_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(TbNum2.Text);
            int num2 = int.Parse(TbNum1.Text);

            double resultado = operaciones.Multiplicando(num1, num2);
            LblMostrarResultados.Text = "Resultado: " + resultado.ToString();

        }

        private void BtnDivision_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(TbNum1.Text);
            int num2 = int.Parse(TbNum2.Text);

            double resultado = operaciones.Dividiendo(num1, num2);
            LblMostrarResultados.Text = "Resultado: " + resultado.ToString();

        }

        private void BtnSuma_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(TbNum1.Text); 
            int num2 = int.Parse(TbNum2.Text);

            double resultado = operaciones.Sumando(num1,num2);
            LblMostrarResultados.Text = "Resultado: " + resultado.ToString();
        }
    }
}
