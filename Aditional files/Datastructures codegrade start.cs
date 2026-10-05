using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] commands = input.Split(' ');

            LinkedList list = new LinkedList(commands[1]);

            while (input != null)
            {
                commands = input.Split(' ');
                switch (commands[0]) {
                    case "inserthead":
                        list.AddHead(commands[1]);
                        break;
                    case "inserttail":
                        list.InsertTail(commands[1]);
                        break;
                    case "search":
                        Console.WriteLine(list.Search(commands[1]));
                        break;
                    case "delete":
                        list.Delete(commands[1]);
                        break;
                    case "print":
                        list.Print();
                        break;
                    default:
                        break;
                }
                input = Console.ReadLine();
            }
        }
    }
}