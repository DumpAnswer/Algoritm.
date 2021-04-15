using System;
using System.Collections.Generic;
using System.Text;

namespace Treaning
{
    class Program
    {
        public class TestCase
        {
            public int X { get; set; }
            public int Expected { get; set; }
            public Exception ExpectedException { get; set; }
        }
        static void SimpleTest(TestCase test)
        {
            try
            {
                var actual = SimpleNumber(test.X);
                if (actual == test.Expected)
                {
                    Console.WriteLine("Тест дествительный");
                }
                else
                {
                    Console.WriteLine("Тест не дествительный");
                }
            }
            catch(Exception ex)
            {
                if(test.ExpectedException != null)
                {
                    Console.WriteLine("Тест дествительный");
                }
                else
                {
                    Console.WriteLine("Тест не дествительный");
                }
            }
        }
        public  static int SimpleNumber(int n)
        {
            if (n < 0)
            {
                throw new ArgumentException("Число не может быть отрицательным");
            }

            int d = 0;
            
            for(int i = 2; i < n; i++)
            {
                if(n % i == 0)
                {
                    d++;
                }
            }

            if (d == 0)
            {
                return 1; // Простое
            }
            else
            {
                return 0; // Не простоепростое
            }
        }





        static void Main(string[] args)
        {

            var testCase1 = new TestCase()
            {
                X = 6,
                Expected = 0,
                ExpectedException = null


            };
            

            
            var testCase2 = new TestCase()
            {
                X = 33,
                Expected = 0,
                ExpectedException = null


            };
            var testCase3 = new TestCase()
            {
                X = -2,
                Expected = 0,
                ExpectedException = null


            }; 
            var testCase4 = new TestCase()
            {
                X = 0,
                Expected = 0,
                ExpectedException = null


            };
            





            SimpleTest(testCase1);
            SimpleTest(testCase2);
            SimpleTest(testCase3);
            SimpleTest(testCase4);
            
           
        }
    }    
}

