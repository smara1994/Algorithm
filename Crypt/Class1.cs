using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crypt
{
    class Class1
    {
        
        

        public static void Hanoi(int n, int i, int j)
        {
            if (n > 0)
            {
                Hanoi(n - 1, i, 6 - i - j);
                Console.WriteLine(i + "--->" + j);
                Hanoi(n - 1, 6 - i - j, j);
            }
        }

        public void MetodaDeSortareCuvinte()
        {
            string[] arr = { "dawdawdawdaw", "dawdawdw", "sdsdas", "dsdas", "dsd", "dd", "s" };

            bool decizie = false;
            do
            {
                decizie = false;
                
                for (int i = 0; i < arr.Length - 1; i++)
                {
                  
                    if (arr[i].Length > arr[i + 1].Length)
                    {
                        string temp = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = temp;
                        decizie = true;
                    }
                }
            } while (decizie);
            for (int i = 0; i != arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
        public void SortarePrinAflareaMinimului()
        {
            int[] arr = { -32, -21, -3, 4, 43, 54, 65, 100, 543 };
            for (int i = 0; i <= arr.Length - 1; i++)
            {
                for (int j = 0; j <= arr.Length - 1; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        int aux = arr[i];
                        arr[i] = arr[j];
                        arr[j] = aux;
                    }
                }
            }
            for (int i = 0; i != arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

        }
        public void MetodaPrinInserare()
        {
            int[] arr = { -54, -42, -32, -10, 4, 8, 12, 23, 42 };


            for (int i = 0; i <= arr.Length - 1; i++)
            {
                int j, x;                
                x = arr[i];
                j = i - 1;


                while (j >= 0 && arr[j] < x)
                {
                    
                    arr[j + 1] = arr[j];
                    --j;
                    
                }
              arr[j + 1] = x;

            }
            for (int i = 0; i != arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
        public void MetodaPrinInsertieBinara()
        {
            int[] arr = { -22, -15, 0, 4, 10, 15 };
            for (int i = 0; i <= arr.Length - 1; i++)
            {
                int stanga = 0;
                int aux;
                int dreapta = i - 1;
                int m;
                aux = arr[i];
                while (stanga <= dreapta)
                {
                    m = (dreapta + stanga) / 2;
                    if (aux < arr[m])
                        dreapta = m - 1;
                    else
                        stanga = m + 1;
                }
                for (int j = i - 1; j >= stanga; j--)
                {
                    arr[j + 1] = arr[j];
                    arr[stanga] = aux;
                }

            }
            for (int i = 0; i != arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
        public void MetodaSortareCifre()
        {
            int[] arr = { 987, 765, 543, 432, 323, 212, 123, 94, 54 };


            bool didSwap = true;
            while (didSwap)
            {
                didSwap = false;
                for (int x = 0; x < arr.Length - 1; x++)
                {
                    if (arr[x] > arr[x + 1])
                    {
                        int temp = arr[x];
                        arr[x] = arr[x + 1];
                        arr[x + 1] = temp;
                        didSwap = true;

                    }

                }


            }
            for (int i = 0; i != arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
        
    }
}


