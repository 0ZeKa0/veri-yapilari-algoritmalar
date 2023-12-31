using System;
using Trees;

class Program
{
    static void Main()
    {
       BinarySearch tree = new BinarySearch();
        tree.insert(new Node(10));
        tree.insert(new Node(7));
        tree.insert(new Node(11));
        tree.insert(new Node(6));
        tree.insert(new Node(8));
        tree.insert(new Node(20));
        tree.insert(new Node(1));
        tree.insert(new Node(9));
        tree.insert(new Node(14));
        tree.insert(new Node(22));

        //Yanlış sonuç veriyor.
        Console.WriteLine("InOrder ile gösterimi");
        tree.Displayinorder();
        Console.WriteLine("PreOder ile gösterimi");
        tree.Displaypreorder();
        Console.WriteLine("PostOrder ile gösterimi");
        tree.Displaypostorder();
    }
}