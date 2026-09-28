public class CocktailShaker
{
    public CocktailShaker() {}
    
    public int[] Sort(int[] numbers)
    {
        int left = 0;
        int right = numbers.Length - 1;
        bool swapped = true;

        while (swapped) {
            swapped = false;

            // Bubble right
            for (int i = left; i < right; i++) {
                if (numbers[i] > numbers[i + 1]) {
                    int temp = numbers[i];
                    numbers[i] = numbers[i + 1];
                    numbers[i + 1] = temp;
                    swapped = true;
                }
            }
            right--;
            if (!swapped) return numbers;

            // Bubble left
            for (int i = right; i > left; i--) {
                if (numbers[i] < numbers[i - 1]) {
                    int temp = numbers[i];
                    numbers[i] = numbers[i - 1];
                    numbers[i - 1] = temp;
                    swapped = true;
                }
            }
            left++;
            if (!swapped) return numbers;
        }
        
        return numbers;
    }
}