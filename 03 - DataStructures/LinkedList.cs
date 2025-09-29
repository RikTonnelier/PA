public class LinkedList
{
    public Node Head { get; set; }

    public LinkedList(string value)
    {
        Node node = new Node(value);
        Head = node;
    }

    public void InsertTail(string value)
    {
        Node node = new Node(value);
        Node lastnode = Head;

        while (lastnode.Next != null)
        {
            lastnode = lastnode.Next;
        }

        lastnode.Next = node;
    }

    public bool Search(string value)
    {
        Node currentNode = Head;
        while (currentNode != null)
        {
            if (currentNode.Data == value)
            {
                return true;
            }
            else
            {
                currentNode = currentNode.Next;
            }
        }

        return false;
    }

    public void Delete(string value)
    {
        if (Head == null)
        {
            return;
        }

        if (Head.Data == value)
        {
            Head = Head.Next;
            return;
        }

        Node current = Head;
        while (current.Next != null && current.Next.Data != value)
        {
            current = current.Next;
        }

        if (current.Next != null)
        {
            current.Next = current.Next.Next;
        }
    }

    public void InsertHead(string value)
    {
        Node node = new Node(value);
        node.Next = Head;
        Head = node;
    }

    public override string ToString()
    {
        string list = Head.Data;
        Node lastnode = Head;

        while (lastnode.Next != null)
        {
            lastnode = lastnode.Next;
            list += " -> " + lastnode.Data;
        }

        return list;
    }
}