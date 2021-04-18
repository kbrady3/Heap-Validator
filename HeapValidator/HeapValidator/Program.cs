using System;

namespace HeapValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 100, 19, 36, 17, 3, 25, 1, 2, 7 };
            Heap h = new Heap(arr, arr.Length);
            Console.WriteLine(h.Validate());

            int[] arr2 = { 100, 19034098, 36, 1708231, 3, 25, 1, 29832, 7 };
            Heap h2 = new Heap(arr2, arr2.Length);
            Console.WriteLine(h2.Validate());
        }
    }
}
