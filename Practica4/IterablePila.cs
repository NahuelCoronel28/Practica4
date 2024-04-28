using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica4
{
    internal class IterablePila : Iterable
    {
        int indice;
        Pila pila;
        public IterablePila(Pila auxPila)
        {
            this.pila = auxPila;
            indice = 0;
        }

        public void primero()
        {
            indice = 0;
        }
        public void siguiente()
        {
            indice++;
        }
        public bool fin()
        {
            return indice == pila.cuantos();
        }
        public Comparable actual()
        {
            return pila.Elementos_pila()[indice];
        }
    }
}
