public class Fibonnaci
{
    public int Iterative(int n)
    {
        if (n <= 1)
        {
            return 0;
        }

        int prev = 0;
        int current = 1;
        int next = prev + current;

        for (int i = 2; i < n; i++)
        {
            prev = current;
            current = next;
            next = prev + current;
        }

        return current;
    }

    public int Recursive(int n)
    {
        Console.WriteLine($"Currently calculating {n}");
        // Base case
        if (n <= 1)
        {
            return n;
        }

        // Recursive case
        return Recursive(n - 1) + Recursive(n - 2);
    }

    public int RecursiveMemo(int n, int[] array)
    {
        // Base case
        if (n <= 1)
        {
            return n;
        }

        if (array[n] > 0)
        {
            return array[n];
        }

        // Recursive case
        Console.WriteLine($"Recursive case for {n}");
        array[n] = RecursiveMemo(n - 1, array) + RecursiveMemo(n - 2, array);
        return array[n];
    }

    public int[] Array { get; set; }

    public Fibonnaci()
    {
        Array = new int[10];
        Array[0] = 0;
        Array[1] = 1;
    }

    public int Tabulation(int n)
    {
        if (n == 0 || Array[n] != 0)
        {
            return Array[n];
        }

        int index = 1;
        for (int i = index; i < Array.Length; i++)
        {
            if (Array[i] > 0)
            {
                index = i;
            }
            else
            {
                break;
            }
        }
        
        for (int i = index + 1; i <= n; i++)
        {
            Array[i] = Array[i - 2] + Array[i - 1];
            Console.WriteLine("Doing a new iteration");
        }

        Console.WriteLine(string.Join(',', Array));
        return Array[n];
    }
}