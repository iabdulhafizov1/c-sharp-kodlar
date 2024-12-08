using System;
using System.Collections.Generic;
class BucketSort
{
    public static void Sort(int[] array)
    {
        int minValue = array[0];
        int maxValue = array[0];
        
        foreach (int num in array)
        {
            if (num < minValue)
                minValue = num;
            if (num > maxValue)
                maxValue = num;
        }
        int bucketCount = (int)Math.Sqrt(array.Length);
        int range = (maxValue - minValue) / bucketCount + 1;
        
        // Bucketlarni yaratish
        List<int>[] buckets = new List<int>[bucketCount];
        for (int i = 0; i < bucketCount; i++)
        {
            buckets[i] = new List<int>();
        }
        foreach (int num in array)
        {
            int bucketIndex = (num - minValue) / range;
            buckets[bucketIndex].Add(num);
        }
        foreach (var bucket in buckets)
        {
            InsertionSort(bucket);
        }
        int index = 0;
        foreach (var bucket in buckets)
        {
            foreach (int num in bucket)
            {
                array[index++] = num;
            }
        }
    }
    // Insertion sort algoritmi
    private static void InsertionSort(List<int> bucket)
    {
        for (int i = 1; i < bucket.Count; i++)
        {
            int key = bucket[i];
            int j = i - 1;

            // Keyni tartiblashtirish
            while (j >= 0 && bucket[j] > key)
            {
                bucket[j + 1] = bucket[j];
                j--;
            }
            bucket[j + 1] = key;
        }
    }

    // Natijani ko'rsatish
    public static void PrintArray(int[] array)
    {
        foreach (int num in array)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }

    public static void Main(string[] args)
    {
        int[] array = { 12, 3, 21, 22, 32, 1, 31 };
        Console.WriteLine("Dastlabki massi:");
        PrintArray(array);
        Sort(array);
        Console.WriteLine("Tartiblangan massiv:");
        PrintArray(array);
        Console.ReadKey(true);
    }
}


