using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_6_printElements
{
    internal class LinkedList
    {
        Node head;
        public LinkedList()
        {
            head = null;
        }
        public void addAtLast(int data)
        {
            Node newNode =new Node(data);
            if(head == null)
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
        public void printList()
        {
            Node temp = head;
            while (temp != null)
            {
                Console.Write(temp.data+" ");
                temp = temp.next;
            }
        }
    }
}
