using System;
using System.Collections.Generic;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace HashSet
{
    class Program
    {

        static  void Main(string[] args)
        {
            BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).Run(args);
        }
      
    }

    public class BenchmarkClass
    {
        string[] arr;
        HashSet<string> hashSet;
        Random rand = new Random();

        public BenchmarkClass()
        {
            arr = StringArray();
            hashSet = new HashSet<string>(arr);
        }
        
        static string[] StringArray(int size = 10000)  //создание массива
        {
            string [] arr = new string[size];
            for(int i =0; i< size; i++)
            {
                arr[i] = Guid.NewGuid().ToString();    
            }
            
            return arr;


        }

        public  string [] SearchValue()     //создание  рандомного элемента    
        {
            var values = new string[1];
            for(int i = 0; i < 1; i++)
            {
                values[i] = arr[rand.Next(0, arr.Length - 1)];
            }
            return values;
        }
     

        [Benchmark]
        [ArgumentsSource(nameof(SearchValue))]      // указание метода 
        public int arrayTest(string target)  // поиск элемента в массиве 
        {
            
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == target)
                {
                    return i;
                }
            }
            return -1;
        }
        [ArgumentsSource(nameof(SearchValue))]      // указание метода 
        [Benchmark]
        public string HashTest(string target) // поиск элемента в Hashset таблице
        {
            return hashSet.TryGetValue(target, out var result) ? result : null;
        }
           

    }
}
