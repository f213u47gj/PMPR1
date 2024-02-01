using System;

class Selectionsort
{
    public static (IList<T>, int) SelectionSort<T>(IList<T> list) where T : IComparable<T>
    {
        int swaps = 0;

        for (int i = 0; i < list.Count - 1; ++i)
        {
            int min = i;
            for (int j = i + 1; j < list.Count; ++j)
            {
                if (list[j].CompareTo(list[min]) < 0)
                {
                    min = j;
                }
            }

            if (i != min)
            {
                T temp = list[i];
                list[i] = list[min];
                list[min] = temp;
                swaps++;
            }
        }

        return (list, swaps);
    }
}
