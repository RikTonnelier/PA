public class Queens
{
    public static char[,] Board { get; set; }
    public static int NrOfQueens { get; set; }
    public Queens(int n)
    {
        Board = new char[n, n];
        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < n; col++)
            {
                Board[row, col] = '.';
            }
        }

        NrOfQueens = n;
    }

    public bool Solve(int col)
    {
        if (NrOfQueens == col)
        {
            return true;
        }

        for (int i = 0; i < NrOfQueens; i++)
        {
            bool safe = IsSafe(i, col);
            if (safe == true)
            {
                Board[i, col] = 'Q';
                bool isSolved = Solve(col + 1);
                if (isSolved == true)
                {
                    return true;
                }
                Board[i, col] = '.';
            }
        }

        return false;
    }

    public bool IsSafe(int row, int col)
    {
        // Collumns
        for (int i = col; i >= 0; i--)
        {
            if (Board[row, i] == 'Q')
            {
                return false;
            }
        }

        // Rows
        for (int i = row; i >= 0; i--)
        {
            if (Board[i, col] == 'Q')
            {
                return false;
            }
        }

        // Upper diagonal
        for (int i = row, j = col; i >= 0 && j >= 0; i--, j--)
        {
            if (Board[i, j] == 'Q')
            {
                return false;
            }
        }

        // Lower diagonal
        for (int i = row, j = col; i < NrOfQueens && j >= 0; i++, j--)
        {
            if (Board[i, j] == 'Q')
            {
                return false;
            }
        }

        return true;
    }

    public override string ToString()
    {
        string output = "";

        for (int row = 0; row < NrOfQueens; row++)
        {
            for (int col = 0; col < NrOfQueens; col++)
            {
                output += Board[row, col] + " ";
            }
            output += "\n";
        }

        return output;
    }
}