public class Sort
{
    public static void PrintArray(int[] array)
    {
        foreach (int element in array)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine();
    }

    public static void BubbleSort(int[] array)
    {
        for (int i = 0; i <= array.Length - 2; i++)
        {
            bool flag = false;
            PrintArray(array);

            for (int j = 0; j <= array.Length - 2 - i; j++)
            {
                if (array[j] > array[j + 1])
                {
                    int temp = array[j + 1];
                    array[j + 1] = array[j];
                    array[j] = temp;
                    flag = true;
                }
            }

            if (!flag)
            {
                break;
            }
        }
    }

    public static void SelectionSort(int[] array)
    {
        for (int i = 0; i <= array.Length - 2; i++)
        {
            PrintArray(array);
            int minIndex = i;
            for (int j = i + 1; j <= array.Length - 1; j++)
            {
                if (array[j] < array[minIndex])
                {
                    minIndex = j;
                }
            }
            if (minIndex != i)
            {
                int temp = array[i];
                array[i] = array[minIndex];
                array[minIndex] = temp;
            }
        }
    }

    public static void InsertionSort(int[] array)
    {
        for (int i = 1; i <= array.Length - 1; i++)
        {
            PrintArray(array);
            int key = array[i];
            int j = i - 1;

            while (j >= 0 && array[j] > key)
            {
                array[j + 1] = array[j];
                j = j - 1;
            }

            array[j + 1] = key;
        }
    }
}