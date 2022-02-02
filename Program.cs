using System;
using DatastructureAlgorithms.Linked_List;
using DatastructureAlgorithms.Stack;
using DatastructureAlgorithms.Queue;
using DatastructureAlgorithms.BinaryTree;
using DatastructureAlgorithms.DoublyLinkedList;
using DatastructureAlgorithms.DataTypes;
using DatastructureAlgorithms.AVLTree;
using DatastructureAlgorithms.AVLTreeNodes;
using DatastructureAlgorithms.ArraySorting;
using DatastructureAlgorithms.ArraySearch;
using DatastructureAlgorithms.MaxHeap;
using DatastructureAlgorithms.Graphs;
using DatastructureAlgorithms.GraphNodes;
using DatastructureAlgorithms.GraphEdges;
using System.Linq;
using DatastructureAlgorithms.HashTables;

namespace DatastructureAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            Graph graph = new Graph();
            var s = graph.AddNode(new GraphNode("S"));
            var a = graph.AddNode(new GraphNode("A"));
            var c = graph.AddNode(new GraphNode("C"));
            var d = graph.AddNode(new GraphNode("D"));
            var b = graph.AddNode(new GraphNode("B"));

            graph.AddEdge(new GraphEdge(s, a, 0));
            graph.AddEdge(new GraphEdge(s, b, 0));
            graph.AddEdge(new GraphEdge(s, c, 0));
            graph.AddEdge(new GraphEdge(a, d, 0));
            graph.AddEdge(new GraphEdge(b, d, 0));
            graph.AddEdge(new GraphEdge(c, d, 0));

            graph.DepthFirstSearch();


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
