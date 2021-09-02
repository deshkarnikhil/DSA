using System;
namespace Sorting
{
    public class BubbleSort
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
                
                for (int i = 0; i < index; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        Swap(array, i, i + 1);
                    }
                }

                
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
