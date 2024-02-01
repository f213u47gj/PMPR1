using System;

class Bubblesort
{

    public static (int[], int) sortbubble(int[] array)
    {
        int temp = 0;
        int swaps = 0;

        for (int write = 0; write < array.Length; write++)
        {
            for (int sort = 0; sort < array.Length - 1; sort++)
            {
                if (array[sort] > array[sort + 1])
                {
                    temp = array[sort + 1];
                    array[sort + 1] = array[sort];
                    array[sort] = temp;

                    swaps++;
                }
            }
        }
        return (array, swaps);

    }
}