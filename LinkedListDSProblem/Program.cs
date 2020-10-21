using System;
using System.Collections.Generic;

namespace LinkedListDSProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Linked List Data Structure Problem!");
            LinkedList list = new LinkedList();
            list.Add(56);
            list.Add(30);
            list.Add(70);
            Console.WriteLine("\n=================================================================");
            LinkedList list2 = new LinkedList();
            list2.Add(70);
            list2.AddBefore(30);
            list2.AddBefore(56);
            list.Display();
            Console.WriteLine("\n=================================================================");
            LinkedList list3 = new LinkedList();
            list3.Add(56);
            list3.Add(30);
            list3.Add(70);
            list3.Display();
        }
    }
}
