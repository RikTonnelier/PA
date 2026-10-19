int[] ints = new int[] {1, 2, 3, 4, 5, 6};
int[] unsortedInts = new int[] {12, 56, 34, 78, 23, 89, 45, 67, 90, 21};

Sum sum = new Sum();

Console.WriteLine(sum.Iterative(ints));
Console.WriteLine(sum.Recursive(ints, 0));
Console.WriteLine(sum.DivideAndConquer(ints.ToList()));

QuickSort quickSort = new QuickSort();
foreach(int item in quickSort.Sort(unsortedInts.ToList()))
{
   Console.Write(item + " ");
}

Hanoi hanoi = new Hanoi();
hanoi.Solve(5, "A", "B", "C");