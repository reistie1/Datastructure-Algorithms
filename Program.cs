using System;
using DatastructureAlgorithms.Linked_Lists;
using DatastructureAlgorithms.Stack;
using DatastructureAlgorithms.Queue;
using DatastructureAlgorithms.BinaryTree;
using DatastructureAlgorithms.DoublyLinkedList;
using DatastructureAlgorithms.DataTypes;
using DatastructureAlgorithms.AVLTree;
using DatastructureAlgorithms.AVLTreeNodes;
using DatastructureAlgorithms.ArraySorting;

namespace DatastructureAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            AVLTrees tree = new AVLTrees();
            tree.insert(20);
            tree.insert(43);
            tree.insert(55);
            tree.insert(50);
            tree.insert(40);
            //tree.InOrder();
            //Console.WriteLine(ArraySortings.SelectionSort(new int[] {3,54,89,46,11,70,32,2})[7]);
            // list.printList();
            // tree.PreOrder();
            // tree.PostOrder();
            // tree.DeleteNode(50);
            // tree.InOrder();
            // string input = "";

            //     Console.WriteLine("Menu Options");
            //     Console.WriteLine("-----------------");
            //     Console.WriteLine("Linked List - ll\nBinary Search Tree - bst\nQueue - queue\nStack - stack \n");
            //     Console.WriteLine("Please select an options");

            // do{
            //     input = Console.ReadLine();

            //     switch(input)
            //     {
            //         case "ll":
            //             Console.WriteLine("You have chosen to use a linked list\n");
            //             break;
            //         case "bst":
            //             Console.WriteLine("You have chosen a binary search tree\n");
            //             break;
            //         case "queue":
            //             Console.WriteLine("You have chosen a queue\n");
            //             break;
            //         case "stack":
            //             Console.WriteLine("You have chosen a stack\n");
            //             break;
            //         default:
            //             break;
            //     }
            // }while(input != "quit");
        }
    }
}
