public class QuickSort
{
    public List<int> Sort(List<int> list)
    {
        // Base case
        if (list.Count <= 1)
        {
            return list;
        }

        // Recursive case
        int pivot = list.First();
        list.RemoveAt(0);

        // Divide part
        List<int> smaller = new List<int>();
        List<int> bigger = new List<int>();

        foreach (int element in list)
        {
            if (element <= pivot)
            {
                smaller.Add(element);
            }
            else
            {
                bigger.Add(element);
            }
        }

        // Conquer part
        List<int> merged = new List<int>();

        List<int> sortedSmaller = Sort(smaller);
        List<int> sortedBigger = Sort(bigger);

        merged.AddRange(sortedSmaller);
        merged.Add(pivot);
        merged.AddRange(sortedBigger);

        return merged;
    }
}