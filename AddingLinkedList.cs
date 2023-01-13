using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Day14LinkedList
{
    public class AddingLinkedList
    {
        private int size;
        private Node head;

        public AddingLinkedList()
        {
            this.size = 0;
            this.head = null;
        }

        public void insertNode(int data)
        {
            Node node = new Node();
            node.data = data;
            Node current = this.head;

            if (this.head == null)
            {
                this.head = node;
                this.head.next = null;
                this.size = 1;
                Console.WriteLine(this.head);
            }
            else
            {

                while (current.next != null)
                {
                    current = current.next;
                }
                current.next = node;
                node.next = null;
                this.size += 1;
            }
        }


        public void printNodes()
        {
            if (this.size < 1)
                Console.WriteLine("There are no nodes in the linked list");

            else
            {
                Node current = this.head;
                for (int i = 0; i < this.size; i++)
                {
                    Console.WriteLine("Node " + current.data + " is at location " + i);
                    current = current.next;
                }
            }
        }


        public int ListSize()
        {
            return size;
        }
    }
}
