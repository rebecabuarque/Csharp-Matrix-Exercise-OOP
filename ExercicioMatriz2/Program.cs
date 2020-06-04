using System;

namespace ExercicioMatriz2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split(' ');
            int n = int.Parse(s[0]);
            int m = int.Parse(s[1]);
            int[,] mat = new int [n, m];

            for (int i = 0; i < n; i++)
            {
                string[] s1 = Console.ReadLine().Split(' ');
                for (int j = 0; j < m; j++)
                {
                    mat[i, j] = int.Parse(s1[j]);
                }
            }
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (mat[i,j] == number)
                    {
                        Console.WriteLine($"Position {i},{j}");
                        if (j > 0)
                        {
                            Console.WriteLine("Left: " + mat[i , j -1]);
                        }
                        if(i > 0)
                        {
                            Console.WriteLine("UP:  " + mat[i - 1, j]);
                        }
                        if (j < m-1)
                        {
                            Console.WriteLine("Right: " + mat[i, j+1]);
                        }
                        if (i < n -1 )
                        {
                            Console.WriteLine("Down: " + mat[i+1,j]);
                        }
                    }
                }
            }


        }
    }
}
