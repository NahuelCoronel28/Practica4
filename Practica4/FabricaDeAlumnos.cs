using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica4
{
    internal class FabricaDeAlumnos : FabricaDeComparables
    {
        GeneradorDeDatosAleatorios generador = new GeneradorDeDatosAleatorios();
        LectorDeDatos lector = new LectorDeDatos();
        public override Comparable crearAleatorio()
        {
            int numero_auxiliar = lector.numeroPorTeclado();
            return new Alumno(generador.stringAleatorio(numero_auxiliar), generador.numeroAleatorio(numero_auxiliar), generador.numeroAleatorio(numero_auxiliar), generador.numeroAleatorio(numero_auxiliar));
        }

        public override Comparable crearPorTeclado()
        {
            return new Alumno(lector.stringPorTeclado(), lector.numeroPorTeclado(), lector.numeroPorTeclado(), lector.numeroPorTeclado());
        }
    }
}
