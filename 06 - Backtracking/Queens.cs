public class Queens
{
    public char[,] Board { get; set;}
    public int Size { get; set;}
    public Queens(int queens)
    {
        Size = queens;
        Board = new char[queens, queens];

        for(int row = 0; row < queens; row++)
        {
            for(int col = 0; col < queens; col++)
            {
                Board[row, col] = '.';
            }
        }
    }

    public bool Solve(int col)
    {
        // Base case
        if (col == Size)
        {
            return true;
        }

        // Recursive case
        for (int i = 0; i < Size; i++)
        {
            if (IsSafe(i, col))
            {
                // Place queen
                Board[i, col] = 'Q';

                // Continue solving with next column
                bool solved = Solve(col + 1);

                // Return if true, backtrack if false
                if (solved)
                {
                    return true;
                } else
                {
                    Board[i, col] = '.';
                }
            }
        }

        return false;
    }

    public bool IsSafe(int row, int col)
    {
        // Check if a queen is in the spot
        if (Board[row, col] == 'Q')
        {
            return false;
        }

        // Check if a queen is on the same row to the left
        for (int j = 0; j< col; j++)
        {
            if (Board[row, j] == 'Q')
            {
                return false;
            }
        }

        // Check if a queen is on the same diagonals (upper and lower) to the left
        // Upper
        for (int i = row, j = col; i >= 0 && j >= 0; i--, j--)
        {
            if (Board[i, j] == 'Q')
            {
                return false;
            }
        }

        // Lower
        for (int i = row, j = col; i < Size && j >= 0; i++, j--)
        {
            if (Board[i, j] == 'Q')
            {
                return false;
            }
        }

        // Return false is the spot is unsafe
        // Return true if the spot is safe
        return true;
    }

    public void Print()
    {
        for (int row = 0; row < Size; row ++)
        {
            for (int col = 0; col < Size; col++)
            {
                Console.Write(Board[row, col] + " ");
            }
            Console.WriteLine();
        }
    }
}