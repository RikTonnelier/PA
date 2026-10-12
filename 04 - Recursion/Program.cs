// Factorial factorial = new Factorial();
// Console.WriteLine(factorial.Iterative(5));
// Console.WriteLine(factorial.Recursive(5));
using TM.ProgrammingAdvanced;

//string basefolder = Data.Folders(@"C:\Temp");
string basefolder = @"C:\Temp";
KeyInBox keyInBox = new KeyInBox();
Console.WriteLine(keyInBox.SearchIterative(basefolder));
Console.WriteLine(keyInBox.SearchRecursive(basefolder));