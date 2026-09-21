public class Linear
{
    public int Count = 0;

    public Linear() {}

    public int Guess(int[] nums, int target)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            Count++;
            if (nums[i] == target) return i;
        }

        return -1;
    }
}