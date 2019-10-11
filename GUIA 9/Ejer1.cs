using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUIA_9
{
    class Ejer1
    {
        public void Ejercicio1()
        {
            int op;
            List<string> frutas = new List<string>();
            do
            {
                Console.Clear();
                Console.WriteLine("\t*** INICIO ***");
                Console.WriteLine("* 1 * Agregar a la lista.");
                Console.WriteLine("* 2 * Mostrar lista.");
                Console.WriteLine("* 3 * Insertar en la lista.");
                Console.WriteLine("* 4 * Eliminar de la lista.");
                Console.WriteLine("* 5 * Buscar en la lista.");
                Console.WriteLine("* 6 * Vaciar lista.");
                Console.WriteLine("* 7 * Salir.");
                int.TryParse(Console.ReadLine(), out op);
                switch (op)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Ingrese nombre de fruta a agregar: ");
                        frutas.Add(Console.ReadLine());
                        Console.WriteLine("\nPresione <ENTER> para continuar");
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Clear();
                        showList(frutas);
                        Console.WriteLine("\nPresione <ENTER> para continuar");
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.Clear();
                        showList(frutas);
                        int n1;
                        string nombre;
                        Console.WriteLine("\nIngrese posicion: ");
                        int.TryParse(Console.ReadLine(), out n1);
                        Console.WriteLine("Nombre de la fruta a insertar: ");
                        nombre = Console.ReadLine();
                        frutas.Insert(n1 - 1, nombre);
                        Console.WriteLine("\nPresione <ENTER> para continuar");
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.Clear();
                        showList(frutas);
                        Console.WriteLine("\nNombre de fruta a eliminar: ");
                        nombre = Console.ReadLine();
                        Console.WriteLine("Quieres borrar el elemento \'" + nombre + "\"de la lista ?");
                        Console.WriteLine("* 1 * Si. \n* 2 * No.");
                        int.TryParse(Console.ReadLine(), out op);
                        if (op == 1)
                        {
                            frutas.Remove(nombre);
                        }
                        else
                        {
                            Console.WriteLine("\nPresione <ENTER> para salir a inicio.");
                            Console.ReadKey();
                        }
                        break;
                    case 5:
                        Console.Clear();
                        Console.WriteLine("Nombre de fruta a buscar: ");
                        nombre = Console.ReadLine();
                        if (frutas.Contains(nombre))
                        {
                            int pos = frutas.IndexOf(nombre);
                            Console.WriteLine("\"" + nombre + "\" Se escuentra en la posicion: " + (pos + 1) + ".");
                        }
                        else
                        {
                            Console.WriteLine("\"" + nombre + "\" NO se encuentra en la lista.");
                        }
                        Console.WriteLine("\nPresione <ENTER> para continuar");
                        Console.ReadKey();
                        break;
                    case 6:
                        Console.Clear();
                        Console.WriteLine("\nQuieres VACIAR la lista ?");
                        Console.WriteLine("* 1 * Si. \n* 2 * No.");
                        int.TryParse(Console.ReadLine(), out op);
                        if (op == 1)
                        {
                            frutas.Clear();
                            Console.WriteLine("Presione <ENTER> para continuar");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("\nPresione <ENTER> para salir a inicio.");
                            Console.ReadKey();
                        }
                        break;
                }
            } while (op != 7);
            Console.WriteLine("\nPresione <ENTER> para cerrar.");
            Console.ReadKey();
        }
        //mostrar lista
        #region
        public static void showList(List<string> frutas)
        {
            for (int i = 0; i < frutas.Count; i++)
            {

                Console.WriteLine("*" + (i + 1) + " " + frutas[i]);
            }
        }
        #endregion
    }
}