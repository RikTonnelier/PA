public class Maze
{
    public List<int>[] Connections {get; set;}
    public bool[] Visited {get; set;}
    public Queue<int> Queue {get; set;}

    public Maze(int size)
    {
        Connections = new List<int>[size];
        Visited = new bool[size];
        Queue = new Queue<int>();

        for (int i = 0; i < size; i++)
        {
            Connections[i] = new List<int>();
        }
    }

    public void AddEdge(int node1, int node2)
    {
        Connections[node1].Add(node2);
        Connections[node2].Add(node1);
    }

    public void Print()
    {
        for(int i = 0; i < Connections.Length; i++)
        {
            Console.WriteLine(i + ":  " + String.Join(" ", Connections[i]));
        }
    }

    public bool Recursion(int current, int target)
    {
        Console.WriteLine("Visit " + current);

        // base case
        if (current == target)
        {
            return true;
        }

        Visited[current] = true;

        // Recursive case
        foreach (int connection in Connections[current])
        {
            if(!Visited[connection])
            {
                bool FoundExit = Recursion(connection, target);
                if (FoundExit)
                {
                    return true;
                }
            }
        }

        return false;
    }

    public bool BFS(int current, int target)
    {
        Queue.Enqueue(current);

        while (Queue.Count > 0)
        {
            current = Queue.Dequeue();

            Console.WriteLine("Visit " + current);

            if (current == target)
            {
                return true;
            }

            Visited[current] = true;

            foreach (int connection in Connections[current])
            {
                if (!Visited[connection])
                {
                    Queue.Enqueue(connection);
                }
            }
        }
        
        return false;
    }
}