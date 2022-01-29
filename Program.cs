﻿using System;
using DatastructureAlgorithms.Linked_Lists;
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

namespace DatastructureAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            Graph graph = new Graph();
            graph.AddNode(new GraphNode("Adam"));
            graph.AddNode(new GraphNode("Josh"));
            graph.AddEdge(new GraphEdge(graph._nodeSet.First().Value, graph._nodeSet.Last().Value, 19));
            Console.WriteLine(graph.ToString()); 
            
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