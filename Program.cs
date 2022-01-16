using System;
using DatastructureAlgorithms.Linked_Lists;
using DatastructureAlgorithms.Stack;
using DatastructureAlgorithms.Queue;
using DatastructureAlgorithms.BinaryTree;
using DatastructureAlgorithms.DoublyLinkedList;

namespace DatastructureAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            // DoublyLinkedLists doublyLinked = new DoublyLinkedLists();
            // doublyLinked.InsertAtStart(4);
            // doublyLinked.InsertAtStart(32);
            // doublyLinked.InsertAtStart(13);
            // doublyLinked.InsertAtStart(8);
            // doublyLinked.InsertAtStart(12);
            // doublyLinked.InsertAtEnd(48);
            // doublyLinked.InsertAfter(13, 99);
            // doublyLinked.PrintForward();

            //tree.PreOrder();
            //tree.PostOrder();
            //tree.DeleteNode(50);
            //tree.InOrder();
            string input = "";

                Console.WriteLine("Menu Options");
                Console.WriteLine("-----------------");
                Console.WriteLine("Linked List - ll\nBinary Search Tree - bst\nQueue - queue\nStack - stack \n");
                Console.WriteLine("Please select an options");

            do{
                input = Console.ReadLine();

                switch(input)
                {
                    case "ll":
                        Console.WriteLine("You have chosen to use a linked list\n");
                        break;
                    case "bst":
                        Console.WriteLine("You have chosen a binary search tree\n");
                        break;
                    case "queue":
                        Console.WriteLine("You have chosen a queue\n");
                        break;
                    case "stack":
                        Console.WriteLine("You have chosen a stack\n");
                        break;
                    default:
                        break;
                }
            }while(input != "quit");
        }
    }
}
