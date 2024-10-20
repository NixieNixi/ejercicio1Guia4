using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio1Guia4
{
    public partial class Form1 : Form
    {

        /// <summary>
        /// Autor: NixieNixi
        /// Fecha: 19/10/2024
        /// Version: 1.0.0
        /// Demostracion:Sentencias controladas por contadores.
        ///Problema:Realice un programa que ingrese una cantidad N de números enteros y 
        ///al final imprima lasuma de los números ingresados
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIngresarDato_Click(object sender, EventArgs e)
        {
            //Declaracion de variables
            int i = 0, num = 0,cant = 0, suma = 0;

            //Inicio Try Catch
            try
            {
                //Solicita al usuario la cantidad de nuemros que se desee ingresar
                cant = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox
                    ("Ingrese la cantidad de numero", "Ingrese la cantidad"));

                //Bucle for para solicitar al usuario que ingrese los nuemros de uno en uno
                for(i = 0; i < cant; i++)
                {
                    //Solita un dato al usuario y lo convierte de tipo entero (int)
                    num = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox
                        ("Ingrese el numero","Ingreso de numeros"));

                    //Acumula la suma de los numeros que el usuario ingrese
                    suma = suma + num;

                }

                //Muestra un messagebox con el resultado de la suma
                MessageBox.Show(string.Format("la suma total es: {0}", suma));
            }
            catch(Exception)
            {
                //Muestrame un messagebox en caso de que ingrese un dato de tipo null
                MessageBox.Show("El dato que ingreso es null", 
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            //Cierra la ejecucion del programa
            Application.Exit();
        }
    }
}
