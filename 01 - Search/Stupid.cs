public class Stupid
{
    public int Count = 0;

    public Stupid() {}

    public int Guess(int[] nums, int target)
    {
        Random random = new Random();
        int counter = 0;

        while(counter < 10000)
        {
            Count++;
            int guess = random.Next(0, nums.Length-1);
            if (nums[guess] == target) return guess;
            counter++;
        }

        return -1; 
    }
}