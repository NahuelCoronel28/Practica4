using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Practica4
{
    internal class ClaveValor
    {
        Numero clave;
        Comparable valor;

        public ClaveValor(Numero clave, Comparable valor)
        {
            this.clave = clave;
            this.valor = valor;
        }
        public Numero getClave()
        {
            return clave;
        }
        public Comparable getValor()
        {
            return valor;
        }
    }
}
