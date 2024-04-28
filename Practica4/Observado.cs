using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica4
{
    internal interface Observado
    {
        void agregar(Observador observador);
        void quitar(Observador observador);
        void notificar();
    }
}
