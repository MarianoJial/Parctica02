using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculadora_6B.libreria
{
    public class Metodos
    {
        /// <summary>
        /// Metodo publico que envia saludo
        /// </summary>
        /// <returns>Una cadena</returns>

        public string saludar()
        {
            return "Hola Mundo";
        }
        /// <summary>
        /// Funcion que realiza la suma de 2 nùmeros
        /// </summary>
        /// <param name="valor1">flotante</param>
        /// <param name="valor2">flotante</param>
        /// <returns>resultado flotante</returns>

        public float sumar(float valor1, float valor2)
        {
            var resultado = valor1 + valor2;
            return resultado;
            

        }
        public float restar(float valor1, float valor2)
        {
            var resultado = valor1 - valor2;
            return resultado;


        }
        public float multiplicar(float valor1, float valor2)
        {
            var resultado = valor1 * valor2;
            return resultado;


        }
        public float dividir(float valor1, float valor2)
        {
            var resultado = valor1 / valor2;
            return resultado;


        }
    }
}
