public class Sort
{
    public Sort() {}

    public int Bubble(int[] numbers)
    {
        int count = 0;

        for (int i = 0; i < numbers.Length - 1; i++)
        {
            bool flag = false;
            
            for (int j = 0; j < numbers.Length - i - 1; j++)
            {
                count++;
                if (numbers[j] > numbers[j+1])
                {
                    int temp = numbers[j];
                    numbers[j] = numbers[j+1];
                    numbers[j+1] = temp;
                    flag = true;
                }
            }
            if (!flag)
            {
                break;
            }
        }

        return count;
    }

    public int Selection(int[] numbers)
    {
        int count = 0;

        for (int i = 0; i < numbers.Length -1; i++)
        {
            int minimum = i;

            for (int j = i + 1; j < numbers.Length; j++)
            {
                count ++;
                if (numbers[j] < numbers[minimum])
                {
                    minimum = j;
                }
            }

            int temp = numbers[i];
            numbers[i] = numbers[minimum];
            numbers[minimum] = temp;
        }

        return count;
    }

    public int Insertion(int[] numbers)
    {
        int count = 0;

        for (int i = 1; i < numbers.Length; i++)
        {
            int current = numbers[i];
            int j = i - 1;

            count++;
            while (j >= 0 && numbers[j] > current)
            {
                numbers[j + 1] = numbers [j];
                j--;
            }
            numbers[j + 1] = current;
        }

        return count;
    }
}