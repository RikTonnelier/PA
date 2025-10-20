Sum sum = new Sum();

int[] ints = new int[] { 1, 2, 3, 4, 5 };
Console.WriteLine(sum.Iterative(ints));
Console.WriteLine(sum.Recursive(ints, 0, 0));
Console.WriteLine(sum.Recursive2(ints, 0));
Console.WriteLine(sum.DC(ints.ToList()));

List<int> list = new List<int>() {12, 50, 34, 78, 23, 83, 45, 67, 90, 21};
QuickSort quickSort = new QuickSort();
List<int> sorted = quickSort.Sort(list);

string output = "";
foreach (int element in sorted)
{
    output += element + " ";
}

Console.WriteLine(output);

Hanoi hanoi = new Hanoi();
hanoi.Solve(5, 'A', 'B', 'C');