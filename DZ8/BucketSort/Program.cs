using System.Collections.Generic;
using System;
namespace BucketSort
{
    class Program
    {
        public static void BucketsSort(int[] items)
        {
            // Предварительная проверка элементов исходного массива
            if (items == null || items.Length < 2)
            {
                return;
            }

            // Поиск элемента с максимальными и минимальными значениями
            int maxValue = items[0];
            int minValue = items[0];

            for (int i = 1; i < items.Length; i++)
            {
                if (items[i] > maxValue)
                {
                    maxValue = items[i];
                }
                if (items[i] < minValue)
                {
                    minValue = items[i];
                }
            }
            // Создание временного массива "карманов" в количестве,
            // достаточном для хранения всех возможных элементов,
            // чьи значения лежат в диапазоне между minValue и maxValue.
            // Т.е. для каждого элемента массива выделяется "карман" List<int>.
            // При заполнении данных "карманов" элементы исходного не отсортированного массива
            // будут размещаться в порядке возрастания собственных значений "слева направо".

            List<int>[] bucket = new List<int>[maxValue - minValue + 1];
            for (int i = 0; i < bucket.Length; i++)
            {
                bucket[i] = new List<int>();
            }

            // Занесение значений в пакеты

            for (int i = 0; i < items.Length; i++)
            {
                bucket[items[i] - minValue].Add(items[i]);
            }


            // Восстановление элементов в исходный массив
            // из карманов в порядке возрастания значений

            int position = 0;
            for (int i = 0; i < bucket.Length; i++)
            {
                if (bucket[i].Count > 0)
                {
                    for (int j = 0; j < bucket[i].Count; j++)
                    {
                        items[position] = bucket[i][j];
                        position++;
                    }
                }
            }



        }
        static void Main(string[] args)
        {
            int[] array = new int[20];
            Random rand = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(50);
            }



            BucketsSort(array);

        }
    }
}
