using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica4
{
    internal class IterableConjunto : Iterable
    {
        int indice;
        Conjunto conjunto;
        public IterableConjunto(Conjunto auxConjunto)
        {
            this.conjunto = auxConjunto;
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
            return indice == conjunto.cuantos();
        }
        public Comparable actual()
        {
            return conjunto.ListaElementos()[indice];
        }
    }
}
