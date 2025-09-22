string[] lines = File.ReadAllLines("sorted_numbers.txt");

Random rand = new Random();
int target = rand.Next(Convert.ToInt32(lines[0]), Convert.ToInt32(lines[lines.Length - 1]));
Console.WriteLine("Target number: " + target);

int guess = rand.Next(Convert.ToInt32(lines[0]), Convert.ToInt32(lines[lines.Length - 1]));

int count = 1;
while (guess != target)
{
    guess = rand.Next(Convert.ToInt32(lines[0]), Convert.ToInt32(lines[lines.Length - 1]));
    count = count + 1;
}

Console.WriteLine("Studid search: Number was " + guess + ", guessed in " + count + " guesses!");

count = 0;
for (int i = 0; i < lines.Length; i++)
{
    count = count + 1;
    if (Convert.ToInt32(lines[i]) == target)
    {
        Console.WriteLine("Linear search: Number was " + guess + ", guessed in " + count + " guesses!");
        break;
    }
}

int start = 0;
int end = lines.Length - 1;

int middle = (start + end + 1) / 2;
count = 1;

while (Convert.ToInt32(lines[middle]) != target)
{
    if (target > Convert.ToInt32(lines[middle]))
    {
        start = middle + 1;
    }
    else
    {
        end = middle - 1;
    }

    middle = (start + end + 1) / 2;
    count = count + 1;
}

 Console.WriteLine("Binary search: Number was " + guess + ", guessed in " + count + " guesses!");