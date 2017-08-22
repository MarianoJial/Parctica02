using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Calculadora_6B.libreria;

namespace Calculadora_6B.consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Metodos misMetodos = new Metodos();
            Console.WriteLine(misMetodos.saludar());
            Console.ReadKey();
        }
    }
}
