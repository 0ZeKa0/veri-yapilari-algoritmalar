// See https://aka.ms/new-console-template for more information
using System.Collections;

Console.WriteLine("Hello, World!");

Queue dizi = new Queue();
dizi.Enqueue(1);
dizi.Enqueue(2);
dizi.Enqueue(3);

foreach (var item in dizi)
    Console.WriteLine(item);

dizi.Enqueue(4);
dizi.Enqueue(5);

Console.WriteLine(dizi.Peek());

foreach (var item in dizi)
    Console.WriteLine(item);

dizi.Dequeue();

foreach (var item in dizi)
    Console.WriteLine(item);