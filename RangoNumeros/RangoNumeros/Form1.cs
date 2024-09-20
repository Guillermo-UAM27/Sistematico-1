using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RangoNumeros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Limpiar el ListBox antes de mostrar los nuevos números
            listBox1.Items.Clear();

            // Leer los valores de los TextBox
            int x, y;

            // Validar que los TextBox contengan números válidos
            if (int.TryParse(textBox1.Text, out x) && int.TryParse(textBox2.Text, out y))
            {
                // Llamar al método para mostrar los números
                MostrarNumeros(x, y);
            }
            else
            {
                MessageBox.Show("Por favor, ingresa números válidos en ambos campos.");
            }
        }


        // Método para mostrar los números en el ListBox
        private void MostrarNumeros(int x, int y)
        {
            if (x <= y)
            {
                // Si x es menor o igual que y, mostrar en orden ascendente
                for (int i = x; i <= y; i++)
                {
                    listBox1.Items.Add(i); // Agregar al ListBox
                }
            }
            else
            {
                // Si x es mayor que y, mostrar en orden descendente
                for (int i = x; i >= y; i--)
                {
                    listBox1.Items.Add(i); // Agregar al ListBox
                }
            }
        }
    }
}
