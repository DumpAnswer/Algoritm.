using System;

namespace FunctionComplexity
{
    class Program
    {
        // Общая асимпотическая сложность O(N^3)
        public static int StrangeSum(int[] inputArray)
        {
            int sum = 0;
            for (int i = 0; i < inputArray.Length; i++) // O(N)
            {
                for (int j = 0; j < inputArray.Length; j++)// O(N)
                {
                    {
                        for (int k = 0; k < inputArray.Length; k++)// O(N)
                        {
                            {
                                int y = 0;// O(1)

                                if (j != 0)
                                {
                                    y = k / j; //O(1)
                                }

                                sum += inputArray[i] + i + k + j + y; //O(1)
                            }
                        }
                    }
                    return sum; // O(1)


                }
                
            }
                


                static void Main(string[] args)
                {
                    Console.WriteLine();
                }
            
        }
    }
}
