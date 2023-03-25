using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Security.Cryptography;

namespace CLASES_HERENCIA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Estudiante estudiante = new Estudiante();
            estudiante.Cuenta = "MARIA.m";
            estudiante.Password = "12345";
            estudiante.Nombre = "MARIA";
            estudiante.Matricula = "125478";
            estudiante.login("MARIA.m", "12345");
            estudiante.login();
            Console.ReadKey();

            List<Docente> listaDocentes = new List<Docente>();
            listaDocentes.Add(new Docente()
            {
                Cuenta = "CAROLINAA.C",
                Password = "12365",
                Nombre = "CAROLINA",
                Sueldo = 1236,

            });
            listaDocentes.Add(new Docente()
            {
                Cuenta = "GROVER.V",
                Password = "45698",
                Nombre = "GROVER",
                Sueldo = 12364,

            });
            listaDocentes.Add(new Docente()
            {
                Cuenta = "DANIELA.N",
                Password = "1236512",
                Nombre = "DANIELA",
                Sueldo = 12365,

            });
            MostrarLista(listaDocentes);
            Double promedio = getPromedio(listaDocentes);
            Console.WriteLine("Promedio: {0}", promedio.ToString("##.##"));

            double promedio2 = getPromedioDos(listaDocentes);
            Console.WriteLine("Promedio Dos: {0}", promedio2.ToString("##.##"));


            double promedio3 = getPromedioTres(listaDocentes);
            Console.WriteLine("Promedio Tres: {0}", promedio3.ToString("##.##"));

            double promedio4 = getPromedioCuatro(listaDocentes);
            Console.WriteLine("Promedio Cuatro: {0}", promedio4.ToString("##.##"));



            Console.ReadKey();
        }

        private static double getPromedioCuatro(List<Docente> listaDocentes)
        {
            decimal prom = (
                from item in listaDocentes
                where item.Sueldo < 10000000
                select item.Sueldo
                ).Average();
            return (double)prom;
        }

        private static double getPromedioTres(List<Docente> listaDocentes)
        {
            decimal sum = listaDocentes.Sum(x => x.Sueldo);
            int total = listaDocentes.Count;
            return (double)(sum / total);
        }

        private static double getPromedioDos(List<Docente> listaDocentes)
        {
            decimal promedio = listaDocentes.Average(x => x.Sueldo);
            return (double)promedio;
        }
        private static double getPromedio(List<Docente> listaDocentes)
        {
            Decimal sum = 0;
            foreach (Docente item in listaDocentes)
            {
                sum += item.Sueldo;
            }
            return (double)(sum / listaDocentes.Count());
        }

        private static void MostrarLista(List<Docente> listaDocentes)
        {
            Console.WriteLine("/n-----------LISTA DE DOCENTES------------------/n");
            foreach (Docente item in listaDocentes)
            {
                Console.WriteLine(item.ToString());
            }


            //tarea para casa


                List<Estudiante> listaEstudiantes = new List<Estudiante>();

                listaEstudiantes.Add(new Estudiante()
                {
                    Cuenta = "CAROLINAA.C",
                    Password = "12365",
                    Nombre = "CAROLINA",
                    Matricula = "1236",
                    Edad = 20,

                });
                listaEstudiantes.Add(new Estudiante()
                {
                    Cuenta = "GROVER..G",
                    Password = "4563",
                    Nombre = "GROVER",
                    Matricula = "1452",
                    Edad = 22,

                });
                listaEstudiantes.Add(new Estudiante()
                {
                    Cuenta = "DANIELA.D",
                    Password = "32145",
                    Nombre = "DANIELA",
                    Matricula = "96325",
                    Edad = 22,

                });
                listaEstudiantes.Add(new Estudiante()
                {
                    Cuenta = "RODRIGO.R",
                    Password = "78523",
                    Nombre = "RODRIGO",
                    Matricula = "78965",
                    Edad = 21,

                });
                listaEstudiantes.Add(new Estudiante()
                {
                    Cuenta = "GABRIELA.G",
                    Password = "56455",
                    Nombre = "GABRIELA",
                    Matricula = "77788",
                    Edad = 19,
                });


                MostrarListaE(listaEstudiantes);
                Double promedioEdad1= getPromedioEdad(listaEstudiantes);
                Console.WriteLine("Promedio Edad1: {0}", promedioEdad1.ToString("##.##"));

                double promedioEdad2 = getPromedioEdadDos(listaEstudiantes);
                Console.WriteLine("Promedio EdadDos: {0}", promedioEdad2.ToString("##.##"));


                double promedioEdad3 = getPromedioEdadTres(listaEstudiantes);
                Console.WriteLine("Promedio EdadTres: {0}", promedioEdad3.ToString("##.##"));

                double promedioEdad4 = getPromedioEdadCuatro(listaEstudiantes);
                Console.WriteLine("Promedio EdadCuatro: {0}", promedioEdad4.ToString("##.##"));



                Console.ReadKey();
            }



            private static double getPromedioEdadCuatro(List<Estudiante> listaEstudiantes)
            {
                Decimal prom = (
                from item in listaEstudiantes
                where item.Edad < 100
                select item.Edad
                ).Average();
                return (double)prom;
            }

            private static double getPromedioEdadTres(List<Estudiante> listaEstudiantes)
            {
                decimal sum = listaEstudiantes.Sum(x => x.Edad);
                int total = listaEstudiantes.Count;
                return (double)(sum / total);
            }

            private static double getPromedioEdadDos(List<Estudiante> listaEstudiantes)
            {
                decimal promedio = listaEstudiantes.Average(x => x.Edad);
                return (double)promedio;
            }
            private static double getPromedioEdad(List<Estudiante> listaEstudiantes)
            {
                Decimal sum = 0;
                foreach (Estudiante item in listaEstudiantes)
                {
                    sum += item.Edad;
                }
                return (double)(sum / listaEstudiantes.Count());
            }

            private static void MostrarListaE(List<Estudiante> listaEstudiantes)
            {
                Console.WriteLine("/n--------------------LISTA DE ESTUDIANTES------------------------/n");
                foreach (Estudiante item in listaEstudiantes)
                {
                    Console.WriteLine(item.ToString());
                }


            }
        }
    }

