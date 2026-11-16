public class BST {
    public Node Root {get; set;}

    public BST(int value)
    {
        Root = new Node(value);
    }

    public void Add(int value)
    {
        AddRecursive(value, Root);
    }

    private void AddRecursive(int value, Node current)
    {
        if(value < current.Value)
        {
            if (current.Left == null) current.Left = new Node(value);
            else AddRecursive(value, current.Left);
        }
        else
        {
            if (current.Right == null) current.Right = new Node(value);
            else AddRecursive(value, current.Right);
        }
    }
}