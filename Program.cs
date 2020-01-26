using System;

namespace Lab4
{
    class Program
    {
       static int [] Kopiuj( ref int[] tablica)
        {
            int[] nowa = new int [tablica.Length];
            for (int i = 0; i < nowa.Length; i++)
            {
               nowa[i] = tablica[i];
            }
            return nowa;
        }
        static void Main(string[] args)
        {

            /* int[] x = { 1, 2, 3, 4, 5 };
             int[] y = new int[x.Length];
             for (int i = 0; i < x.Length; i++)
             {
                 y[i] = x[i];

             }
             x[2] = 100;
             for (int i = 0; i < x.Length; i++)
             {
                 Console.WriteLine(x[i]+" ");
             }
             Console.WriteLine();
             for (int i = 0; i < x.Length; i++)
             {
                 Console.WriteLine(y[i]+" ");
             }
         }
     }*/
           

            int[,] x = {
                        {1, 2, 3, 4, 5 },
                        {1, 2, 3, 4, 5 },
                        {1, 2, 3, 4, 5 },
                        {1, 2, 3, 4, 5 },
            };
            int[][] y =
                {
                new int[] { },
                new[]{1},
                new[]{1,2},
                new[]{1,2,3},
                new[]{1,2,3,4},
                new[]{1,2,3,4,5},
                };

            Console.WriteLine("Przed kopiowaniem:");

            int[] x1 = new int[4] { 1, 2, 3, 4 };
            int[] x2 = new int[2] { 5, 6 };
            int[] x3 = new int[3] { 1, 2, 2 };
            int[] x4 = new int[4] { 5, 4, 3, 2 };
            int[][] z = new int[][] { x1, x2, x3, x4 };

            for (int i = 0; i < x.GetLength(0); i++)
            {
                for (int j = 0; j < z[i].Length; j++)
                {
                    Console.Write(z[i][j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            //int[][] z = new int[5][];
            //for (int i = 0; i < z.Length; i++)
            //{
            //    z[i] = new int[i + 1];
            //    for (int j = 0; j < z[i].Length; j++)
            //    {
            //        z[i][j] = i + j;

            //    }
            //}


            Kopiuj(ref x1);
            Console.WriteLine("Po kopiowaniu:");
            //for (int i = 0; i < z.Length; i++)
            //{
            //    for (int j = 0; j < z[i].Length; j++)
            //    {
            //        Console.Write(z[i][j] + ", ");
            //    }
            //    Console.WriteLine();
            //}

            /*
            for (int i = 0; i < y.GetLength(0); i++)
            {
                for (int j = 0; j < y.GetLength(1); j++)
                {
                    Console.Write(y[i, j]);
                }
                Console.WriteLine();
            }
            */

            for (int i = 0; i < x.GetLength(0); i++)
            {
                for (int j = 0; j < z[i].Length; j++)
                {
                    Console.Write(z[i][j] + " ");
                }
                Console.WriteLine();
            }

        }
    }
}