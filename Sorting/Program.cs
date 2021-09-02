using System;

namespace Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 10, -1, 20, 5, 8, 0, 9 };

            // SelectionSort selectionSort = new SelectionSort();
            //selectionSort.Sort(array);

            BubbleSort bubbleSort = new BubbleSort();
            bubbleSort.Sort(array);

        }
    }
}
