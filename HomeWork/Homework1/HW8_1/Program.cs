using System;

namespace HW8_1
{
    class Program
    {
        static void Main(string[] args)
        {
            BucketSortClass bucketSortClass = new BucketSortClass();
            var arrayToSort = GetRandomArray(50, 1, 100);
            Console.WriteLine("Начальный массив: " + string.Join(", ", arrayToSort) + "\n");
            Console.WriteLine("Отсортированный массив: " + string.Join(", ",bucketSortClass.BucketSortMethod(arrayToSort)));
            Console.ReadLine();
        }
        static int[] GetRandomArray(int arraySize, int minValue, int maxValue)
        {
            var random = new Random();
            var randomArray = new int[arraySize];
            for (var i = 0; i < randomArray.Length; i++)
            {
                randomArray[i] = random.Next(minValue, maxValue);
            }

            return randomArray;
        }
    }
}
