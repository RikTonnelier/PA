
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

    public void DFS(bool[] visited, int start, int end = 0)
    {
        Stack<int> stack = new Stack<int>();
        stack.Push(start);

        while (stack.Count > 0)
        {
            int node = stack.Pop();

            Console.WriteLine(node);
            visited[node] = true;

            if (node == end)
            {
                return;
            }

            foreach (int i in Nodes[node])
            {

                if (visited[i] == false)
                {
                    stack.Push(i);
                }
            }
        }
    }
    
    public void BFS(bool[] visited, int start, int end = 0)
    {
        Queue<int> queue = new Queue<int>();
        queue.Enqueue(start);

        while(queue.Count > 0)
        {
            int node = queue.Dequeue();

            Console.WriteLine(node);
            visited[node] = true;

            if (node == end)
            {
                return;
            }

            foreach(int i in Nodes[node])
            {
                
                if(visited[i] == false)
                {
                    queue.Enqueue(i);
                }
            }
        }
    }

    public void DFSRecursion(bool[] visited, int start, int end = 0)
    {
        Console.WriteLine(start);
        visited[start] = true;

        // Base case: when do we stop?
        if (start == end)
        {
            return;
        }

        // Recursive case: explore the adjecent nodes
        foreach(int child in Nodes[start])
        {
            if (visited[child] == false)
            {
                DFSRecursion(visited, child, end);
                return;
            }
        }
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