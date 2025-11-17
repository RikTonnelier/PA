
public class ChickenMaze
{
    public List<KeyValuePair<int, int>>[] Nodes { get; set; }

    public ChickenMaze(int size)
    {
        Nodes = new List<KeyValuePair<int, int>>[size];
        for (int i = 0; i < size; i++)
        {
            Nodes[i] = new List<KeyValuePair<int, int>>();
        }
    }

    public void AddEdge(int node1, int node2, int weight)
    {
        // Add node1 as connection to node2
        Nodes[node1].Add(new KeyValuePair<int, int> (node2, weight));
        // Add node2 as connection to node1
        Nodes[node2].Add(new KeyValuePair<int, int> (node1, weight));
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

            foreach (KeyValuePair<int, int> childnode in Nodes[nextnode])
            {
                int distance = distances[nextnode] + childnode.Value;
                if (distances[childnode.Key] > distance)
                {
                    distances[childnode.Key] = distance;
                    previous[childnode.Key] = nextnode;
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
}