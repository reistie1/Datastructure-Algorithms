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
            WeightedGraph<string> weightGraph = new WeightedGraph<string>();
            var s = weightGraph.AddNode("S");
            var a = weightGraph.AddNode("A");
            var b = weightGraph.AddNode("B");
            var c = weightGraph.AddNode("C");
            var d = weightGraph.AddNode("D");
            var t = weightGraph.AddNode("T");


            weightGraph.AddEdge(a,b,6);
            weightGraph.AddEdge(b,t,5);
            weightGraph.AddEdge(d,t,2);
            weightGraph.AddEdge(c,d,3);
            weightGraph.AddEdge(c,s,8);
            weightGraph.AddEdge(a,s,7);
            weightGraph.AddEdge(b,c,4);
            weightGraph.AddEdge(a,c,3);
            weightGraph.AddEdge(b,d,2);

            var result = weightGraph.KruskalAlgorithm();

            foreach(var item in result)
            {
                Console.WriteLine("Source: " + item.GetSource()._identifier + " Destination: " + item.GetDestination()._identifier + " Weight: " + item.GetWeight());
            }

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
