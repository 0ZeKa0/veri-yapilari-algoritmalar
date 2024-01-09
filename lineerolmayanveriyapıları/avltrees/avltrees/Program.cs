// See https://aka.ms/new-console-template for more information
using avltrees;

Console.WriteLine("Hello, World!");

AVLTrees avlTree = new AVLTrees();

// Insert nodes into the AVL tree
avlTree.Insert(10);
avlTree.Insert(20);
avlTree.Insert(30);
avlTree.Insert(15);
avlTree.Insert(50);
avlTree.Insert(60);
avlTree.Insert(3);
avlTree.Insert(8);



// Perform in-order traversal to display the sorted elements
Console.WriteLine("In-order traversal of AVL tree:");
avlTree.InOrderTraversal();