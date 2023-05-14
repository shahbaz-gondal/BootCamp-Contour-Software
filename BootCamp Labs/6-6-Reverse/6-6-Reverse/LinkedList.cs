using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_6_Reverse
{
    internal class LinkedList
    {
        public Node head;
        public LinkedList()
        {
            head = null;
        }
        public void Add(Object data)
        {
            Node newNode = new Node(data);
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = newNode;
            }
        }
        public void Reverse()
        {
            if(head == null)
            {
                Console.WriteLine("\n************************\nERROR:No Node available to Show(Size=0)\n************************");
            }
            else
            {
                Node prev = head;
                Node temp = head.next;
                head = temp.next;
                prev.next = null;
                while(head.next!=null)
                {
                    temp.next = prev;
                    prev = temp;
                    temp = head;
                    head = temp.next;
                }
                temp.next = prev;
                head.next = temp;
            }
        }
        public void printList()
        {
            if (head == null)
            {
                Console.WriteLine("\n************************\nERROR:No Node available to Show(Size=0)\n************************");
            }
            else
            {
                Console.WriteLine("\n************************\nAll elements of list:");
                Node temp = head;
                while (temp != null)
                {
                    Console.Write(temp.data + " ");
                    temp = temp.next;
                }
                Console.WriteLine("\n************************\n");
            }
        }
    }
}
