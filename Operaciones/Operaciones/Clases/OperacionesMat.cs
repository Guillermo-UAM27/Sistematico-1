using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Operaciones.Clases
{
    internal class OperacionesMat
    {
        int num1 = 0;
        int num2 = 0;

        public double Sumando(int num1, int num2)
        {
            return num1 + num2;
           
        }
        public double Restando(int num1, int num2)
        {
            return num1 - num2;
            
        }
        public double Multiplicando(int num1, int num2)
        {
            return num1 * num2;
            
        }
        public double Dividiendo(int num1, int num2)
        {
            if (num2 != 0)
            {
                return num1 / num2;
            }
            else
            {
                MessageBox.Show("Syntax Error");
                return 0;
            }
        }
        
    }
    
}
