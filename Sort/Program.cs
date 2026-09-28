//int[] numbers = new int[] {32, 7, 45, 7, 23, 41, 19, 28, 50, 1, 37};

int[] numbers = Array.ConvertAll(File.ReadAllLines("sorted_numbers.txt"), Convert.ToInt32);

Sort sort = new Sort();

int countBubble = sort.Bubble(numbers);
int countSelect = sort.Selection(numbers);
int countInsert = sort.Insertion(numbers);

Console.WriteLine($"Bubble count: {countBubble}");
Console.WriteLine($"Selection count: {countSelect}");
Console.WriteLine($"Insertion count: {countInsert}");