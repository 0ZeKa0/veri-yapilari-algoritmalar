// See https://aka.ms/new-console-template for more information
using System.Collections;

Console.WriteLine("Hello, World!");

Stack stack = new Stack();

stack.Push(4);
stack.Push(5);
stack.Push(6);
stack.Push(7);
stack.Push(8);
stack.Pop();
Console.WriteLine(stack.Peek());