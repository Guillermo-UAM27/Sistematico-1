using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operaciones.Clases
{
    internal class OperacionesMat
    {
        int num1 = 0;
        int num2 = 0;

        public double Sumando(int num1, int num2)
        {
            int suma = this.num1 + this.num2;
            return suma;
        }
        public double Restando(int num1, int num2)
        {
            int resta = this.num1 + this.num2;
            return resta;
        }
        public double Multiplicando(int num1, int num2)
        {
            int multiplicacion = this.num1 * this.num2;
            return multiplicacion;
        }
        public double Dividiendo(int num1, int num2)
        {
            int division = this.num1 / this.num2;
            return division;
        }
        
    }
    
}
