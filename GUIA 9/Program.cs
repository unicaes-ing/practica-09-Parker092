using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUIA_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int op;
            do
            {
                Console.WriteLine("\t*** GUIA 9 ***");
                Console.WriteLine("* 1 * Ejercicio 1");
                Console.WriteLine("* 2 * Enercicio 2");
                Console.WriteLine("* 3 * Salir.");
                int.TryParse(Console.ReadLine(), out op);
                switch (op)
                {
                    case 1:
                        Ejer1 a = new Ejer1();
                        a.Ejercicio1();
                        break;
                    case 2:
                        Ejer2 b = new Ejer2();
                        b.ejercicio2();
                        break;
                }

            } while (op!=3);
          
        }

    }
}
