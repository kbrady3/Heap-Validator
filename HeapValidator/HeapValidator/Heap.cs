using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HeapValidator
{
    public class Heap
    {
        private int[] HeapArray;
        private int Size;
        private int Root;

        public Heap() { }

        public Heap(int[] heapArray, int size)
        {
            HeapArray = heapArray;
            Size = size;
            Root = HeapArray[0];
        }

        public bool Validate()
        {
            bool minHeap = false;
            bool maxHeap = false;

            int smallest = HeapArray.Min();
            int largest = HeapArray.Max();

            //Check that root is either the smallest or largest value in the array
            if (smallest.Equals(Root))
            {
                minHeap = true;
            }
            else if (largest.Equals(Root))
            {
                maxHeap = true;
            }

            //Now we check to make sure each element in the array is valid for the type of heap it is
            if (minHeap) //Validate min heap
            {
                for (int i = 0; i < HeapArray.Length; i++)
                {
                    if (HeapArray[2 * i + 1] < HeapArray[i])
                    {
                        return false;
                    }
                    if (2 * i + 2 < HeapArray.Length && HeapArray[2 * i + 2] > HeapArray[i])
                    {
                        return false;
                    }
                }
                return true;
            }
            else if (maxHeap) //Validate max heap
            {
                for (int i = 0; i < HeapArray.Length; i++)
                {
                    if ((2 * i + 1 < HeapArray.Length) && (HeapArray[i] < HeapArray[i * 2 + 1]))
                    {
                        return false;
                    }
                    if ((2 * i + 2 < HeapArray.Length) && (HeapArray[i] < HeapArray[i * 2 + 2]))
                    {
                        return false;
                    }
                }
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
