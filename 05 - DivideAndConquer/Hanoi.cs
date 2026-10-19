public class Hanoi {
    public Hanoi() {}

    public void Solve(int discs, string from, string temp, string to) {
        // Base case
        if (discs == 1) {
            Console.WriteLine($"Move disc {discs} from {from} to {to}.");
            return;
        }

        // Recursive case
        Solve(discs - 1, from, to, temp);
        Console.WriteLine($"Move disc {discs} from {from} to {to}.");
        Solve(discs - 1, temp, from ,to);
    }
}