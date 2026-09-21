public class Binary
{
    public int Count = 0;

    public Binary() {}

    public int Guess(int[] nums, int target)
    {
        int low = 0;
        int high = nums.Length - 1;
        while (low <= high)
        {
            Count++;
            int middle = (low + high) / 2;

            if(nums[middle] == target) return middle;
            else if(nums[middle] < target) low = middle + 1;
            else high = middle - 1;
        }

        return -1;
    }
}