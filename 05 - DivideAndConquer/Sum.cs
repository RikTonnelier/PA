public class Sum
{
    public Sum() {}

    public int Iterative(int[] ints)
    {
        int sum = 0;

        for (int i = 0; i < ints.Length; i++)
        {
            sum += ints[i];
        }

        return sum;
    }

    public int Recursive(int[] ints, int counter)
    {
        // Base case
        if (counter == ints.Length)
        {
            return 0;
        }

        // Recursive case
        int sum = ints[counter] + Recursive(ints, counter + 1);
        return sum;
    }

    public int DivideAndConquer(List<int> ints)
    {
        // Base case
        if (ints.Count <= 0)
        {
            return 0;
        }

        // Recursive case
        int sum = ints[0];
        ints.RemoveAt(0);

        return sum + DivideAndConquer(ints);
    }
}