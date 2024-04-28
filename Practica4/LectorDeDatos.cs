using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica4
{
    internal class LectorDeDatos
    {
        public int numeroPorTeclado()
        {
            Console.WriteLine("Ingrese un numero: ");
            return int.Parse(Console.ReadLine());
        }

        public string stringPorTeclado()
        {
            return Console.ReadLine();
        }
    }
}
