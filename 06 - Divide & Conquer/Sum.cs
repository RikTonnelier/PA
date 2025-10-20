public class Sum
{
    public int Iterative(int[] array)
    {
        int sum = 0;

        foreach (int i in array)
        {
            sum += i;
        }

        return sum;
    }

    public int Recursive(int[] array, int index, int sum)
    {
        if (index >= array.Length)
        {
            return sum;
        }

        sum += array[index];
        return Recursive(array, index + 1, sum);
    }

    public int Recursive2(int[] array, int index)
    {
        if (index >= array.Length)
        {
            return 0;
        }

        return array[index] + Recursive2(array, index + 1);
    }

    public int DC(List<int> list)
    {
        if (list.Count == 0)
        {
            return 0;
        }
        
        int temp = list.First();
        list.RemoveAt(0);

        return temp + DC(list);
    }
}