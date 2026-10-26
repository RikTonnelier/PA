Queens queens = new Queens(3);
if(queens.Solve(0))
{
    queens.Print();
}
else
{
    Console.WriteLine("No solution found.");
}