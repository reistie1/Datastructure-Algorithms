using System;
using DatastructureAlgorithms.Linked_Lists;

namespace DatastructureAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedLists lists = new LinkedLists();
            string input = "";
            do
            {
                Console.WriteLine("Menu Options");
                Console.WriteLine("-----------------");
                Console.WriteLine("Linked List - ll\nBinary Search Tree - bst\nQueue - queue\nStack - stack \n");
                Console.WriteLine("Please select an options");

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
