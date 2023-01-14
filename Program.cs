using Day14LinkedList;
using System.Collections.Generic;

namespace LinkedList
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("Welcome to Linked List Problem");
            /* DeleteLast list = new DeleteLast();
             Console.WriteLine("Current Size of the list is: " + list.getListSize());

             list.insertNode(56);
             list.insertNode(30);
             list.insertNode(70);
             list.printNodes();

             Console.WriteLine("---------------");
             Console.WriteLine("Deleting Last node");
             list.deleteLastNode();
             list.printNodes();*/

            /*SearchLS list = new SearchLS();
            list.insertNode(56);
            list.insertNode(30);
            list.insertNode(70);
            list.printNodes();

            Console.WriteLine("----------------");
            Console.WriteLine("Finding 30 in the Lineked list");
            list.findNode(30);
            list.printNodes();*/

            /*insert40 list = new insert40();
             list.insertNode(56);
             list.insertNode(30);
             list.insertNode(70);
             list.printNodes();
             Console.WriteLine("---------------");
             Console.WriteLine("Adding 40 at second Location");
             list.insertNth(40, 2);
             list.printNodes();*/

            Delete40 list = new Delete40();
            Console.WriteLine("Current Size of the list is: " + list.getListSize());

            list.insertNode(56);
            list.insertNode(30);
            list.insertNode(40);
            list.insertNode(70);
            list.printNodes();
            Console.WriteLine("Current Size of the list is: " + list.getListSize());

            Console.WriteLine("-------------");
            Console.WriteLine("Deleting node from 2nd location");
            list.deleteNthNode(2);
            list.printNodes();
            Console.WriteLine("Current Size of the list is: " + list.getListSize());
        }
    }
}
