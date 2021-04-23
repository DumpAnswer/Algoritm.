using System;

namespace FibonacciFunction
{
    class Program
    {


        public class TestCase
        {
            public int X { get; set; }
            public int Expected { get; set; }
            public Exception ExpectedException { get; set; }
        }

        static void FibTest(TestCase test)
        {
            try
            {
                var actual = Fib(test.X);

                if (actual == test.Expected)
                {
                    Console.WriteLine("Тест дествителен");
                }
                else
                {
                    Console.WriteLine("Тест не дествителен");
                }
            }
            catch (Exception ex)
            {
                if (test.ExpectedException != null)
                {
                    Console.WriteLine("Тест дествителен");
                }
                else
                {
                    Console.WriteLine("Тест не дествителен");
                }

            }
        }

        static void FibRecTest(TestCase test)
        {
            try
            {
                var actual = FibRec(test.X);

                if (actual == test.Expected)
                {
                    Console.WriteLine("Тест дествителен");
                }
                else
                {
                    Console.WriteLine("Тест не дествителен");
                }
            }
            catch (Exception ex)
            {
                if (test.ExpectedException != null)
                {
                    Console.WriteLine("Тест дествителен");
                }
                else
                {
                    Console.WriteLine("Тест не дествителен");
                }

            }
        }



        static int FibRec (int n)
        {
            
            if (n == 0)
            {
                
                return 0;
            }
            else if (n == 1)
            {
               
                return 1;
                
            }
            
             else   
            {
                
                return FibRec(n - 2) + FibRec(n - 1);
                
            }
           
            
        }
        static int Fib(int n)
        {
            int[] f = new int[n+1];
            f[0] = 0;
            f[1] = 1;
         

                for (int i = 2; i <= n; i++)
                {
                    f[i] = f[i - 2] + f[i - 1];
                }
            
            return f[n];
        }




        static void Main(string[] args)
        {
            var testCase1 = new TestCase()
            {
                X = 1,
                Expected = 1,
                ExpectedException = null
                ///проверка на правильный ответ

            };
            var testCase2 = new TestCase()
            {
                X = 1,
                Expected = 2,
                ExpectedException = null
                /// проверка на ошибку

            };
            var testCase3 = new TestCase()
            {
                X = 10,
                Expected = 55,
                ExpectedException = null
                /// проверка большего числа

            };


            FibRecTest(testCase1);
            FibRecTest(testCase2);
            FibRecTest(testCase3);
            Console.WriteLine();
            FibTest(testCase1);
            FibTest(testCase2);
            FibTest(testCase3);
            

        }
    }
}
