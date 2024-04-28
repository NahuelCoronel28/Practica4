using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica4
{
    internal class FabricaDePilas : FabricaDeColeccionables
    {
        public override Coleccionable crearColeccionable()
        {
            return new Pila();
        }
    }
}
