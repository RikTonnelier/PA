public class QuickSort
{
    public QuickSort() {}

    public List<int> Sort(List<int> ints)
    {
        // Base case
        if (ints.Count <= 1)
        {
            return ints;
        }

        // Recursive case
        int pivot = ints[0];

        List<int> smaller = new List<int>();
        List<int> bigger = new List<int>();

        foreach (int item in ints)
        {
            if (item < pivot)
            {
                smaller.Add(item);
            }
            else if (pivot < item)
            {
                bigger.Add(item);
            }
        }

        List<int> sorted = Sort(smaller);
        sorted.Add(pivot);
        sorted.AddRange(Sort(bigger));

        return sorted;
    }
}