public class Hanoi
{
    public void Solve(int discs, char from, char temp, char to)
    {
        // base case
        if (discs == 1)
        {
            Console.WriteLine($"Move disc 1 from {from} to {to}.");
            return;
        }

        // recursive case
        Solve(discs - 1, from, to, temp);
        Console.WriteLine($"Move disc {discs} from {from} to {to}.");
        Solve(discs - 1, temp, from, to);
    }
}