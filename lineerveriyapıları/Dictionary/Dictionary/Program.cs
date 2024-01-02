// See https://aka.ms/new-console-template for more information
using System.Collections;

Console.WriteLine("Hello, World!");

Dictionary<int, string> list = new Dictionary<int,string>();

list.Add(1,"something");
list.Add(2,"something");

foreach (var item in list)
{
    if (item.Key == 2)
    {
        Console.WriteLine(item.Value);
    }
    else
    {
        Console.WriteLine(item.Key);
    }
}