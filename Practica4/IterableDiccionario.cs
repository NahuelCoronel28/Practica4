using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica4
{
    internal class IterableDiccionario : Iterable
    {
        int indice;
        Diccionario diccionario;
        public IterableDiccionario(Diccionario auxDiccionario)
        {
            this.diccionario = auxDiccionario;
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
            return indice == diccionario.cuantos();
        }
        public Comparable actual()
        {
            return diccionario.DiccionarioEjemplo()[indice].getValor();
        }
    }
}
