using System;
using System.Diagnostics;
using System.Threading;
using static System.Collections.Specialized.BitVector32;

class Program
{
    static void Main()
    {
        Marge marge = new Marge();
        Cocktail cocktail = new Cocktail();
        Bubblesort bubblesort = new Bubblesort();
        Selectionsort selectionsort = new Selectionsort();
        InsertionSort insertionSort = new InsertionSort();
        QuickSort quickSort = new QuickSort();

        Console.Write("Введите размерность массива: ");
        int size;

        while (!int.TryParse(Console.ReadLine(), out size) || size <= 0)
        {
            Console.WriteLine("Введите положительное целое число.");
            Console.Write("Введите размерность массива: ");
        }

        int[] array = generatearray(size);

        int rightIndex = size - 1;
        int leftIndex = 0;
        int middleIndex = (size / 2) - 1;

        Console.WriteLine("Сгенерированный массив:");
        // printarray(array);
        Console.WriteLine("Время сортировки Bubble sort");
        timer(() =>
        {
            Bubblesort.sortbubble(array);
        });

        Console.WriteLine("Время сортировки Selection sort");
        timer(() =>
        {
            Selectionsort.SelectionSort(array);
        });

        Console.WriteLine("Время сортировки Insertion sort");
        timer(() =>
        {
            InsertionSort.Insertionsort(array);
        });

        Console.WriteLine("Время сортировки Quick sort");
        timer(() =>
        {
            QuickSort.Quicksort(array, leftIndex, rightIndex);
        });

        Console.WriteLine("Время сортировки Merge sort");
        timer(() =>
        {
            Marge.Merge(array, leftIndex, middleIndex, rightIndex);
        });

        Console.WriteLine("Время сортировки Cocktail sort");
        timer(() =>
        {
            Cocktail.cocktailSort(array);
        });
    }

    static int[] generatearray(int size)
    {
        Random random = new Random();
        int[] array = new int[size];

        for (int i = 0; i < size; i++)
        {
            array[i] = random.Next(1, 10000);
        }

        return array;
    }

    static void printarray(int[] array)
    {
        foreach (var element in array)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine();
    }

    public static void timer(Action action)
    {
        Stopwatch stopwatch = new Stopwatch();

        stopwatch.Start();
        action.Invoke();
        stopwatch.Stop();

        Console.WriteLine($"Время сортировки - {stopwatch.Elapsed.TotalSeconds}");
    }
}