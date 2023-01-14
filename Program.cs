using Day14LinkedList;
using System.Collections.Generic;

namespace LinkedList
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Linked List Problem");
            OrderdLinkedList list = new OrderdLinkedList();

            list.insertNode(56);
            list.insertNode(30);
            list.insertNode(40);
            list.insertNode(70);
            list.printNodes();

            Console.WriteLine();
            list.orderNodes();

        }
    }
}
