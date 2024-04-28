using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica4
{
    internal abstract class FabricaDeComparables : IFabricaDeComparables
    {
        public static Comparable crearAleatorio(int opcion)
        {

            FabricaDeComparables fabrica = null;
            switch (opcion)
            {
                case 1:
                    fabrica = new FabricaDeNumeros();
                    break;
                case 2:
                    fabrica = new FabricaDePersonas();
                    break;
                case 3:
                    fabrica = new FabricaDeAlumnos();
                    break;
                case 4:
                    fabrica = new FabricaDeProfesores();
                    break;
                case 5:
                    fabrica = new FabricaDeAlumnosMuyEstudiosos();
                    break;
            }
            return fabrica.crearAleatorio();
        }
        public static Comparable crearPorTeclado(int opcion)
        {
            FabricaDeComparables fabrica = null;
            switch (opcion)
            {
                case 1:
                    fabrica = new FabricaDeNumeros();
                    break;
                case 2:
                    fabrica = new FabricaDePersonas();
                    break;
                case 3:
                    fabrica = new FabricaDeAlumnos();
                    break;
                case 4:
                    fabrica = new FabricaDeProfesores();
                    break;
            }
            return fabrica.crearPorTeclado();
        }

        abstract public Comparable crearAleatorio();

        abstract public Comparable crearPorTeclado();

    }
}
