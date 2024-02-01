using System;

internal class QuickSort
{
    public static int[] Quicksort(int[] array, int leftIndex, int rightIndex)
    {
        var i = leftIndex;
        var j = rightIndex;
        var pivot = array[(leftIndex + rightIndex) / 2];

        while (i <= j)
        {
            while (array[i] < pivot)
            {
                i++;
            }

            while (array[j] > pivot)
            {
                j--;
            }

            if (i <= j)
            {
                int temp = array[i];
                array[i] = array[j];
                array[j] = temp;
                i++;
                j--;
            }
        }

        if (leftIndex < j)
            Quicksort(array, leftIndex, j);

        if (i < rightIndex)
            Quicksort(array, i, rightIndex);

        return array;
    }

}

