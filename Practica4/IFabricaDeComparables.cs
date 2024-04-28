using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica4
{
    internal interface IFabricaDeComparables
    {
        public abstract static Comparable crearAleatorio(int opcion);
        public abstract static Comparable crearPorTeclado(int opcion);
    }
}
