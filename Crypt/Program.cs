using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crypt
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 cl = new Class1();
            var watch = System.Diagnostics.Stopwatch.StartNew();
            





            Console.WriteLine(" Alege metoda de ordonare ");
            Console.WriteLine(" Metoda de Sortare = 1 ");
            Console.WriteLine(" Metoda prin inserare = 2 ");
            Console.WriteLine(" Metoda de aflare a minimului = 3 ");
            Console.WriteLine(" Metoda prin insertie binara = 4 ");
            string alege = Convert.ToString(Console.ReadLine());
            switch (alege)
            {
                case "1":
                    cl.MetodaSortareCifre();
                    Console.WriteLine("Time of execution ");
                    watch.Stop();
             var    elapsedMs = watch.Elapsed;
                    Console.WriteLine(elapsedMs);
                    break;
                case "2":
                    cl.MetodaPrinInserare();
                    Console.WriteLine("Time of execution ");
                    watch.Stop();
                    elapsedMs = watch.Elapsed;
                    Console.WriteLine(elapsedMs);
                    break;
                case "3":
                    cl.SortarePrinAflareaMinimului();
                    Console.WriteLine("Time of execution ");
                    watch.Stop();
                    elapsedMs = watch.Elapsed;
                    Console.WriteLine(elapsedMs);
                    break;
                case "4":
                    cl.MetodaPrinInsertieBinara();
                    Console.WriteLine("Time of execution ");
                    watch.Stop();
                    elapsedMs = watch.Elapsed;
                    Console.WriteLine(elapsedMs);
                    break;
                default:
                    cl.MetodaDeSortareCuvinte();
                    Console.WriteLine("Time of execution ");
                    watch.Stop();
                    elapsedMs = watch.Elapsed;
                    Console.WriteLine(elapsedMs);
                    break;


            }










        }



            









        }
    }

    
