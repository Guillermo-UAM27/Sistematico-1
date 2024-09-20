using Ejercicio_1.clase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_1
{
    public partial class Form1 : Form
    {
        Matriz mat = new Matriz();
       int columna= 0, fila=0;

        private void button1_Click(object sender, EventArgs e)
        {
            int num1;
            int num2;
            try
            {
                
                num1 = int.Parse(tbMatriz1.Text);
                num2 = int.Parse(tbMatriz2.Text);

                if (columna < 4)
                {

                    switch (columna)
                    {
                        case 0:
                            mat.Matriz1[columna, fila] = num1;
                            mat.Matriz2[columna, fila] = num2;
                            fila++;
                            break;
                        case 1:
                            mat.Matriz1[columna, fila] = num1 * 2;
                            mat.Matriz2[columna, fila] = num2 * 2;
                            fila++;
                            break;

                        case 2:
                            mat.Matriz1[columna, fila] = num1 - 1;
                            mat.Matriz2[columna, fila] = num2 - 1;
                            fila++;
                            break;

                        case 3:
                            mat.Matriz1[columna, fila] = num1 + 5;
                            mat.Matriz2[columna, fila] = num2 + 5;
                            fila = 0;
                            columna++;
                            break;

                        default:
                            Console.WriteLine("Opción no válida.");
                            break;

                    }
                }
                else { MessageBox.Show("Matriz llena"); }

                for (int i= 0; i<4; i++)
                {
                    for (int j= 0; j<4; j++)
                    {
                        mat.MatrizFinal[i,j]= mat.Matriz2[i,j] + mat.Matriz1[i,j];
                    }
                }

                lbSalida.Items.Clear();
                string linea="";

                for (int i= 0;i<4; i++)
                {
                    for(int j= 0;j<4; j++)
                    {
                        linea += mat.MatrizFinal[i, j] + " ";
                    }
                    lbSalida.Items.Add(linea);
                    linea = "";
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public Form1()
        {
            InitializeComponent();
        }
    }
}
