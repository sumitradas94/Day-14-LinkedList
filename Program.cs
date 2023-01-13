using Day14LinkedList;
using System.Collections.Generic;

namespace LinkedList
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("Welcome to Linked List Problem");
            Insert insert = new Insert();

            Console.WriteLine("Current Size of the list is: " + insert.getListSize());
            insert.insertNode(56);

            insert.insertNode(70);
            insert.printNodes();

            Console.WriteLine("Adding 30 at 1st Location");
            insert.insertNth(30, 1);
            insert.printNodes();
        }
    }
}
