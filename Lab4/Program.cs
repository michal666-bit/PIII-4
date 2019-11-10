using System;

namespace Lab4
{
    class Program
    {
       static int [] Kopiuj(int[] tablica)
        {
            int[] nowa = new int [tablica.Length];
            for (int i = 0; i < nowa.Length; i++)
            {
               nowa[i] = tablica[i];
            }
            return nowa[];
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
            for (int i = 0; i < y.Length; i++)
            {
                
            }
            int[] skopowiana = Kopiuj(y);
            
        //    for (int i = 0; i < y.GetLength(0); i++)
        //    {
        //        for (int j = 0; j < y[i].GetLength(0); j++)
        //        {
        //            Console.Write(y[i][j]);
        //        }
        //       Console.WriteLine();
        //    }
        //    Console.WriteLine();
        }
    }
}



