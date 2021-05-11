using System;

namespace DynamicProg
{
    class Program
    {
        const int N = 7;
        const int M = 7;

        static void Print2(int n,int m, int [,] a)
        {
            for(int i = 0; i<n; i++)
            {
                for(int j = 0; j < m; j++)
                {
                    Console.Write(a[i,j]+ " ");
                    
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            int[,] A = new int[N, M];
            int[,] B = new int[N, M];
            Random rand = new Random();
           
            for (int i = 0; i < N ; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    B[i, j] = rand.Next(2);
                    
                }
            }
            
            
        

            for (int j = 0; j < M; j++)
            {
                if(B[0,j] == 0)
                {
                    A[0, j] = 0;
                }
                else
                {
                    A[0, j] = 1;
                }
                
            }

            for (int i = 1; i < N; i++)
            {
                if (B[i, 0] == 0)
                {
                    A[i, 0] = 0;
                }
                else
                {
                    A[i, 0] = 1;
                }

                for (int j = 1; j < M; j++)
                {
                    if (B[i, j] == 1)
                    {
                        A[i, j] = A[i, j - 1] + A[i - 1, j];
                    }
                    if(B[i,j] == 0)
                    {
                        A[i, j] = 0;
                    }
                }
            }
            Print2(N, M, A);
            Console.WriteLine();
            Print2(N, M, B);
        }
    }
}
