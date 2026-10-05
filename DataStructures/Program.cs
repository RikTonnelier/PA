LinkedList list = new LinkedList("Rabbit");
list.AddHead("Horse");
list.AddHead("Donkey");
list.Print();

list.AddTail("Duck");
list.AddTail("Chicken");
list.Print();

Console.WriteLine(list.Search("Duck"));
Console.WriteLine(list.Search("Horse"));
Console.WriteLine(list.Search("Badger"));

list.Delete("Chicken");
list.Print();
list.Delete("Donkey");
list.Print();
list.Delete("Rabbit");
list.Print();