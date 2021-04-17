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
            bool invalid = false;

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
            else
            {
                invalid = true;
            }

            //Now we check to make sure each element in the array is valid for the type of heap it is
            if (minHeap)
            {

            }
            else if (maxHeap)
            {

            }
            else
            {
                return false;
            }
        }
    }
}
