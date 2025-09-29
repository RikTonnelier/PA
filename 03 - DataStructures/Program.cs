// LinkedList linkedList = new LinkedList("Elephant");
// Console.WriteLine(linkedList.ToString());

// linkedList.InsertTail("Cow");
// Console.WriteLine(linkedList.ToString());
// linkedList.InsertTail("Goat");
// Console.WriteLine(linkedList.ToString());


// linkedList.InsertHead("Chicken");
// Console.WriteLine(linkedList.ToString());
// linkedList.InsertHead("Duck");
// Console.WriteLine(linkedList.ToString());

// Console.WriteLine(linkedList.Search("Duck"));
// Console.WriteLine(linkedList.Search("Chicken"));
// Console.WriteLine(linkedList.Search("Badger"));


// linkedList.Delete("Elephant");
// Console.WriteLine(linkedList.ToString());
// linkedList.Delete("Goat");
// Console.WriteLine(linkedList.ToString());
// linkedList.Delete("Duck");
// Console.WriteLine(linkedList.ToString());

Stack stack = new Stack("Elephant", 5);

Console.WriteLine(stack.ToString());
stack.Push("Goat");
Console.WriteLine(stack.ToString());
stack.Push("Chicken");
Console.WriteLine(stack.ToString());