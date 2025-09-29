public class Stack
{
    public LinkedList linkedList { get; set; }
    public int Count { get; set; }
    public int Limit { get; set; }

    public Stack(string value, int limit)
    {
        linkedList = new LinkedList(value);
        Count = 1;
        Limit = limit;
    }

    public void Push(string value)
    {
        if (Count < Limit)
        {
            Count++;
            linkedList.InsertHead(value);
        }
        else
        {
            Console.WriteLine("Stackoverflow");
        }
    }

    public override string ToString()
    {
        return linkedList.ToString();
    }
}