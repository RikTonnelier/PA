public class Factorial
{
    public Factorial() {}

    public int Iterative(int number)
    {
        int factorial = 1;

        for (int i = 1; i <= number; i++)
        {
            factorial *= i;
            Console.WriteLine($"Factorial of {i}: {factorial}");
        }

        return factorial;
    }

    public int Recursive(int number)
    {
        Console.WriteLine($"Call with number: {number}");
        // Base case
        if (number == 1)
        {
            return 1;
        }

        // Recursive case
        else
        {
            return number * Recursive(number - 1);
        }
    }
}