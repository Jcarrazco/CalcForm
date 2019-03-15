using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcForm
{
    class ClaseSingleton
    {
        // Declaramos un atributo del mismo tipo de la clase con carácter estático
        private static ClaseSingleton _instancia = null;

        //Atributos a utilizar
        public Double Valor1 { get; set; }
        public Double Valor2 { get; set; }

        // Constructor privado. Únicamente puede ser invocado desde el interior
        // de la propia clase
        private ClaseSingleton()
        {
            Valor1 = 0;//Inicializo los atributos
            Valor2 = 0;
        }

        // Property de solo lectura
        public static ClaseSingleton Instance
        {
            get
            {
                // Si el singleton no ha sido creado previamente, se instancia.
                // En caso contrario, se devolvera el que haya sido creado previamente
                if (_instancia == null)
                    _instancia = new ClaseSingleton();

                // Se devuelve la instancia
                return _instancia;
            }
        }

        public double suma (double Valor1, double Valor2)//Metodos a usar en la clase
        {
            return Valor1 + Valor2;
        }
        public double Resta (double Valor1, double Valor2)
        {
            return Valor1 - Valor2;
        }
        public double Mult (double Valor1, double Valor2)
        {
            return Valor1 * Valor2;
        }
        public double Div(double Valor1, double Valor2)
        {
            return Valor1 / Valor2;
        }
        public double Pow(double Valor1, double Valor2)
        {
            return Math.Pow(Valor1, Valor2);
        }
        public double Sqr(double Valor1)
        {
            return Math.Sqrt(Valor1);
        }
    }
}
