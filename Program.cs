using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace subtema4._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            string codigo = "", carrera = "", bienvenido = "";
            do {
                Console.Clear();
                Console.WriteLine("¡¡¡¡¡¡¡¡¡¡¡¡Menu de opciones¡¡¡¡¡¡¡¡¡¡¡¡¡");
                Console.WriteLine("1. Leer codigo de estudiante y carrera.");
                Console.WriteLine("2. Formar una nueva etiqueta textual con ambos(concatenado).");
                Console.WriteLine("3. Mostrar longitud de caracteres del codigo, carrera y etiqueta.");
                Console.WriteLine("4. Mostrar el pprimer y ultimo caracyter del codigo.");
                Console.WriteLine("5. Imprimir la carrera caracter por caracter.");
                Console.WriteLine("6. Cree una nueva etiqueta de bienvenida agregado.");
                Console.WriteLine("7. Salir del menu");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion) {
                    case 1:
                        Console.WriteLine("\nIngrese codigo de estudiante: ");
                        codigo = Console.ReadLine();

                        Console.WriteLine("Ingrese carrera: ");
                        carrera = Console.ReadLine();
                        break;
                    case 2:
                        bienvenido = codigo +" | carrera: "+ carrera;
                        Console.WriteLine("etiqueta generada: "+ bienvenido);
                        break;
                    case 3:
                        Console.WriteLine("La longitud del codigo es: " + codigo.Length);
                        Console.WriteLine("La longitud de la carrera es: " + carrera.Length);
                        Console.WriteLine("La longitud del saludo es: " + bienvenido.Length);
                        break;
                    case 4:
                        Console.WriteLine("El primer caracter del codigo es: " + carrera[0]);
                        Console.WriteLine("El ultimo caracter del codigo es: " + carrera[carrera.Length - 1]);
                        break;
                    case 5:
                        Console.WriteLine("Carrera caracter por caracter: ");
                        for (int i = 0; i < carrera.Length; i++)
                        {
                            Console.WriteLine(carrera[i]);
                        }
                        break;
                    case 6:
                        bienvenido = "Codigo: " + codigo + "|Carrera: " + carrera + " - Periodo: 2026-2";
                        Console.WriteLine("Nueva etiqueta de bienvenida: "+ bienvenido);
                        break;

                    default: Console.WriteLine("opcion no valida");
                        break;
                }
                Console.ReadKey();
         
            }
            while (opcion !=7);
        }
    }
}
