using System;
namespace Sorting
{
    public class SelectionSort
    {

        public void Sort(int[] array)
        {
            if (array.Length < 2)
                return;

            // (N-1) + (N-2) + .... +1+0 Operations
            // N(N-1)/2  ~ N^2/2
            //O(N) => N^2 = Qudardict
            for (int index = array.Length - 1; index > 0; index--)
            {
                int largest = 0;

             
                for (int i = 0; i <= index; i++)
                {
                    if (array[i] > array[largest])
                    {
                        largest = i;
                    }
                }

                Swap(array, largest, index);
            }
        }


        private void Swap(int[] array, int i, int j)
        {
            if (i == j)
                return;

            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;

        }
      
    }
}
