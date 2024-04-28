﻿// See https://aka.ms/new-console-template for more information
using System;
using MetodologíasDeProgramaciónI;
using Practica4;

namespace Practica4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Teacher profesor = new Teacher();
            List <AlumnoAdapter> lista_auxiliar = new List<AlumnoAdapter>();
            for (int i = 1; i <= 10; i++)
            {
                Comparable comparable_auxiliar1 = FabricaDeComparables.crearAleatorio(3);
                AlumnoAdapter alumno_aux = new AlumnoAdapter ((Alumno)comparable_auxiliar1);
                alumno_aux.getAlumno().setComparadorAlumno(new PorCalificacion());
                profesor.goToClass(alumno_aux);
                //StudentsFactory a = new StudentsFactory(alumno_aux);
                //a.creadorDeDecoradores();

                Comparable comparable_auxiliar2 = FabricaDeComparables.crearAleatorio(5);
                AlumnoAdapter alumno_aux2 = new AlumnoAdapter((Alumno)comparable_auxiliar2);
                alumno_aux2.getAlumno().setComparadorAlumno(new PorCalificacion());
                profesor.goToClass(alumno_aux2);
                //StudentsFactory b = new StudentsFactory(alumno_aux2);
                //b.creadorDeDecoradores();
                lista_auxiliar.Add(alumno_aux);
                lista_auxiliar.Add(alumno_aux2);
            }
            profesor.teachingAClass();

            foreach (AlumnoAdapter ele in lista_auxiliar)
            {
                StudentsFactory a = new StudentsFactory(ele);
                a.creadorDeDecoradores();
            }

            Console.WriteLine("Hello world!");
        }
        public static void llenar(Coleccionable coleccionable_ejemplo, int opcion)
        {
            int contador = 1;
            for (int i = 1; i <= 20; i++)
            {
                Console.WriteLine(contador);
                contador++;
                Comparable comparable_auxiliar = FabricaDeComparables.crearAleatorio(opcion);
                coleccionable_ejemplo.agregar(comparable_auxiliar);
            }
        }


        public static void informar(Coleccionable coleccionable_ejemplo, int opcion)
        {
            Console.WriteLine("la cantidad es: " + coleccionable_ejemplo.cuantos());
            Console.WriteLine("el promedio minimo es: " + coleccionable_ejemplo.minimo());
            Console.WriteLine("el promedio maximo es: " + coleccionable_ejemplo.maximo());
            Comparable comparable_auxiliar = FabricaDeComparables.crearPorTeclado(opcion);
            Iterable2 aux = ((Iterable2)coleccionable_ejemplo);
            Iterable aux2 = aux.crearIterable();
            aux2.primero();
            while (!aux2.fin())
            {
                if ((aux2.actual().sosIgual(comparable_auxiliar)))
                {
                    Console.WriteLine("El elemento leído está en la colección");
                    return;
                }
                aux2.siguiente();
            }
            Console.WriteLine("El elemento leído no está en la colección");
        }

        public static void dictadoDeClase(Profesor profesor)
        {
            for (int i = 1; i <= 5; i++)
            {
                profesor.hablarALaClase();
                profesor.notificar();
                profesor.escribirEnElPizarron();
                profesor.notificar();
            }
        }
    }
}