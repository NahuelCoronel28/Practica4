using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica4
{
    internal abstract class FabricaDeColeccionables
    {
        public static Coleccionable crearColeccionable(int opcion)
        {

            FabricaDeColeccionables fabrica = null;
            switch (opcion)
            {
                case 1:
                    fabrica = new FabricaDeColas();
                    break;
                case 2:
                    fabrica = new FabricaDePilas();
                    break;
                case 3:
                    fabrica = new FabricaDeDiccionarios();
                    break;
                case 4:
                    fabrica = new FabricaDeConjuntos();
                    break;
            }
            return fabrica.crearColeccionable();
        }
        abstract public Coleccionable crearColeccionable();
    }
}
