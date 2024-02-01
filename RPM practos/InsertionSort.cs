using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class InsertionSort
{
    public static (int[], int) Insertionsort(int[] array)
    {
        int swaps = 0;

        for (int i = 1; i < array.Length; i++)
        {
            int key = array[i];
            int j = i - 1;

            while (j >= 0 && key < array[j])
            {
                array[j + 1] = array[j];
                j--;
                swaps++;
            }

            array[j + 1] = key;
        }

        return (array, swaps);
    }



}