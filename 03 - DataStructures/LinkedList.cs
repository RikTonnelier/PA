public class LinkedList
{
    public Node Head {get; set;}

    public LinkedList(string data)
    {
        Node node = new Node(data);
        Head = node;
    }

    public void AddHead(string data)
    {
        Node node = new Node(data);
        node.Next = Head;
        Head = node;
    }

    public void Print()
    {
        if (Head == null)
        {
            Console.WriteLine("");
            return;
        }

        string toPrint = Head.Data;
        Node next = Head.Next;

        while (next != null)
        {
            toPrint += " -> " + next.Data;
            next = next.Next;
        }

        Console.WriteLine(toPrint);
    }

    public void AddTail(string data)
    {
        if (Head == null)
        {
            Head = new Node(data);
            return;
        }

        Node node = Head;

        while(node.Next != null)
        {
            node = node.Next;
        }

        node.Next = new Node(data);
    }

    public bool Search(string data)
    {
        Node current = Head;
        while (current != null)
        {
            if (current.Data == data)
            {
                return true;
            }

            current = current.Next;
        }

        return false;
    }

    public void Delete(string data)
    {
        if (Head == null)
        {
            return;
        }

        if (Head.Data == data)
        {
            Head = Head.Next;
            return;
        }

        Node previous = null;
        Node current = Head;
        while (current != null)
        {
            if (current.Data == data)
            {
                break;
            }

            previous = current;
            current = current.Next;
        }
        
        if (current == null)
        {
            return;
        }

        previous.Next = current.Next;
    }
}