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
using System.Collections.Generic;
using DatastructureAlgorithms.WeightedGraphs;

namespace DatastructureAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            Graph<string> weightGraph = new Graph<string>();
            var s = weightGraph.AddNode(new GraphNode<string>("S"));
            var a = weightGraph.AddNode(new GraphNode<string>("A"));
            var b = weightGraph.AddNode(new GraphNode<string>("B"));
            var c = weightGraph.AddNode(new GraphNode<string>("C"));
            var d = weightGraph.AddNode(new GraphNode<string>("D"));

            weightGraph.AddEdge(s,a);
            weightGraph.AddEdge(s,b);
            weightGraph.AddEdge(s,c);
            weightGraph.AddEdge(a,d);
            weightGraph.AddEdge(b,d);
            weightGraph.AddEdge(c,d);


            weightGraph.DepthFirstSearch();

            //weightGraph.KruskalAlgorithm();

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
