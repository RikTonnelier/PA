string[] lines = File.ReadAllLines("sorted_numbers.txt");
int[] nums = new int[lines.Length];

for (int i = 0; i< lines.Length; i++)
{
    nums[i] = Convert.ToInt32(lines[i]);
}

Random random = new Random();
int targetIndex = random.Next(0, nums.Length-1);
int target = nums[targetIndex];

Console.WriteLine($"Target: {target} at index {targetIndex}");

Stupid stupid = new Stupid();
int stupidGuess = stupid.Guess(nums, target);

Console.WriteLine($"Stupid guess: {stupidGuess} | it took {stupid.Count} tries");

Linear linear = new Linear();
int linearGuess = linear.Guess(nums, target);

Console.WriteLine($"Linear guess: {linearGuess} | it took {linear.Count} tries");

Binary binary = new Binary();
int binaryGuess = binary.Guess(nums, target);

Console.WriteLine($"Binary: {binaryGuess} | it took {binary.Count} tries");