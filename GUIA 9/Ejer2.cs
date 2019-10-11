using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUIA_9
{
    class Ejer2
    {
        public struct Alumno
        {
            public string carnet;
            public string nombre;
            public string carrera;
            private decimal cum;
            public void setCum(decimal cum)
            {
                if (cum > 0 && cum < 10)
                {
                    this.cum = cum;
                }
            }
            public decimal getCum()
            {
                return cum;
            }
        }
        public void ejercicio2()
        {
            Dictionary<string, Alumno> datos = new Dictionary<string, Alumno>();
            int op, n = 1;
            string carnet = "";
            Alumno a = new Alumno();
            do
            {
                Console.Clear();                
                Console.WriteLine("\t*** INICIO ***");
                Console.WriteLine("* 1 * Agregar Alumno.");
                Console.WriteLine("* 2 * Mostrar Alumnos.");
                Console.WriteLine("* 3 * Eliminar Alumno.");
                Console.WriteLine("* 4 * Buscar Alumno.");
                Console.WriteLine("* 5 * Vaciar Diccionario.");
                Console.WriteLine("* 6 * Salir.");
                int.TryParse(Console.ReadLine(), out op);
                switch (op)
                {
                    case 1:
                        do
                        {
                            Console.Write("Ingrese carnet asignado:");
                            a.carnet = Console.ReadLine();
                            if (datos.ContainsKey(a.carnet))
                            {
                                Console.WriteLine("Este carnet ya esta registrado. "+a.carnet);
                            }
                        } while (datos.ContainsKey(a.carnet));
                        Console.WriteLine("Nombre:");
                        a.nombre = Console.ReadLine();
                        Console.WriteLine("Carrera: ");
                        a.carrera = Console.ReadLine();
                        Console.WriteLine("CUM: ");
                        a.setCum(Convert.ToDecimal(Console.ReadLine()));
                        datos.Add(a.carnet, a);
                        Console.WriteLine("\nPresione <ENTER> para continuar");
                        Console.ReadKey();
                        break;
                    case 2:
                        showDiccionary(datos, n);
                        /*foreach (KeyValuePair<string, Alumno> item in datos)
                           {
                               Console.WriteLine(item);
                           }*/
                        Console.WriteLine("\nPresione <ENTER> para continuar");
                        Console.ReadKey();
                        break;
                    case 3:
                        int op3;
                        Console.Write("Ingrese carnet:");
                        carnet = Console.ReadLine();
                        if (datos.ContainsKey(carnet))
                        {
                            Console.WriteLine("Desea borar los datos correspondientes al carnet: "+carnet);
                            Console.WriteLine("* 1 * Si.\n* 2 * No.");
                            int.TryParse(Console.ReadLine(), out op3);
                            if (op3==1)
                            {
                                datos.Remove(carnet);
                            }
                            else
                            {
                                Console.WriteLine("Presione <ENTER> para continuar");
                                Console.ReadKey();
                            }
                        }
                        else
                        {
                            Console.WriteLine("Carnet: "+carnet+" NO existe.");
                        }
                            break;
                    case 4:
                        Console.Write("Ingrese carnet:");
                        carnet = Console.ReadLine();
                        if (datos.ContainsKey(carnet))
                        {
                            Console.WriteLine("\tCarnet: \t" + datos[carnet].carnet);
                            Console.WriteLine("\tNombre: \t"+datos[carnet].nombre);
                            Console.WriteLine("\tCarrera: \t"+ datos[carnet].carrera);
                            Console.WriteLine("\tCum: \t"+ datos[carnet].getCum()); 
                        }
                        else
                        {
                            Console.WriteLine("Carnet: "+carnet+" NO existe.");
                        }
                        Console.WriteLine("\nPresione <ENTER> para continuar");
                        Console.ReadKey();
                        break;
                    case 5:
                        Console.WriteLine("Desea borar los datos correspondientes al carnet: " + carnet);
                        Console.WriteLine("* 1 * Si.\n* 2 * No.");
                        int.TryParse(Console.ReadLine(), out op3);
                        if (op3 == 1)
                        {
                            datos.Clear();
                        }
                        Console.WriteLine("\nPresione <ENTER> para continuar");
                        Console.ReadKey();
                            break;
                }
            } while (op!=6);
            Console.WriteLine("\nPresione <ENTER> para CERRAR.");
           
            Console.ReadKey();
        }
        #region
        public void showDiccionary(Dictionary<string, Alumno> datos, int n)
        {
            Console.WriteLine("\t*** DICCIONARIO ACTUAL ***");
            foreach (KeyValuePair<string, Alumno> info in datos)
            {
                Alumno alum = info.Value;
                Console.WriteLine("\n\tALUMNO Nª: " + n);
                Console.WriteLine("\tCarnet: " + alum.carnet);
                Console.WriteLine("\tNombre: " + alum.nombre);
                Console.WriteLine("\tCarrera: " + alum.carrera);
                Console.WriteLine("\tCum: " + alum.getCum());
                Console.WriteLine("\t**********************************");
                n++;
            }
        }
        #endregion
    }
}
