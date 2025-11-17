
public class Maze
{
    public List<int>[] Nodes { get; set; }

    public Maze(int size)
    {
        Nodes = new List<int>[size];
        for (int i = 0; i < size; i++)
        {
            Nodes[i] = new List<int>();
        }
    }

    public void AddEdge(int node1, int node2)
    {
        // Add node1 as connection to node2
        Nodes[node1].Add(node2);
        // Add node2 as connection to node1
        Nodes[node2].Add(node1);
    }

    public void Dijkstra(int start, int end = 0)
    {
        List<int> visited = new List<int>();
        int[] distances = new int[Nodes.Length];
        int[] previous = new int[Nodes.Length];

        for (int i = 0; i < distances.Length; i++)
        {
            distances[i] = Int32.MaxValue;
        }

        distances[start] = 0;

        while (true)
        {
            if (visited.Count == Nodes.Length)
            {
                break;
            }

            int nextnode = GetNextNode(visited, distances);
            visited.Add(nextnode);

            foreach (int childnode in Nodes[nextnode])
            {
                int distance = distances[nextnode] + Math.Abs(childnode - nextnode);
                if (distances[childnode] > distance)
                {
                    distances[childnode] = distance;
                    previous[childnode] = nextnode;
                }
            }
        }

        for (int i = 0; i < distances.Length; i++)
        {
            Console.WriteLine($"Node: {i} --> cost: {distances[i]} --> previous node: {previous[i]}");
        }

        int node = end;
        List<int> path = new List<int>();
        path.Add(node);

        while (node != start)
        {
            node = previous[node];
            path.Add(node);
        }

        path.Reverse();

        Console.WriteLine(string.Join(',', path));
    }

    public int GetNextNode(List<int> visited, int[] distances)
    {
        int smallest = Int32.MaxValue;
        int index = 0;

        for (int i = 0; i < distances.Length; i++)
        {
            if (distances[i] < smallest && !visited.Contains(i))
            {
                smallest = distances[i];
                index = i;
            }
        }

        return index;
    }

    public override string ToString()
    {
        string output = "";

        for (int i = 0; i < Nodes.Length; i++)
        {
            output += $"{i} -->";

            foreach (int j in Nodes[i])
            {
                output += $" {j}";
            }

            output += "\n";
        }

        return output;
    }
}