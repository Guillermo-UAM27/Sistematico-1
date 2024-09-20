using Ejercicio_4.clase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_4
{
    public partial class Form1 : Form
    {
       Usuario us = new Usuario();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (us.Intentos < us.Maxintentos)
            {
                try
                {
                    int usuario = int.Parse(tbNombre.Text);
                    int contrasena = int.Parse(tbContra.Text);

                    
                    if (usuario == us.UsuarioCorrecto && contrasena == us.ContrasenaCorrecta)
                    {
                        lbSalida.Text = "Usuario Correcto. ¡Acceso concedido!";
                    }
                    else
                    {
                        us.Intentos++;
                        lbSalida.Text = $"Datos incorrectos. Intento {us.Intentos} de {us.Maxintentos}.";
                    }
                }
                catch (FormatException)
                {
                    
                    lbSalida.Text = $"Formato incorrecto. Intento {us.Intentos} de {us.Maxintentos}.";
                }
            }
            else
            {
                lbSalida.Text = "Has alcanzado el máximo de intentos. Acceso denegado.";
            }

        }
    }
}
