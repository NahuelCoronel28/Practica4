using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica4
{
    internal class FabricaDeProfesores : FabricaDeComparables
    {
        GeneradorDeDatosAleatorios generador = new GeneradorDeDatosAleatorios();
        LectorDeDatos lector = new LectorDeDatos();
        public override Comparable crearAleatorio()
        {
            int numero_auxiliar = lector.numeroPorTeclado();
            return new Profesor(generador.stringAleatorio(numero_auxiliar), generador.numeroAleatorio(numero_auxiliar), generador.numeroAleatorio(numero_auxiliar));
        }
        public override Comparable crearPorTeclado()
        {
            return new Profesor(lector.stringPorTeclado(), lector.numeroPorTeclado(), lector.numeroPorTeclado());
        }
    }
}
