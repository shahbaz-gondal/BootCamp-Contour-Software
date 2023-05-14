using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_6_insertAtTail
{
    internal class LinkedList
    {
        public Node head;
        public LinkedList()
        {
            head = null;
        }
        public void insertAtTail(Object data)
        {
            Node newNode = new Node(data);
            if(head == null)
            {
                head = newNode;
            }
            else
            {
                Node temp = head;
                while(temp.next!=null)
                {
                    temp = temp.next;
                }
                temp.next = newNode;
            }
        }
        public void printList()
        {
            Console.WriteLine("\nElements of list:");
            Node temp = head;
            while (temp != null)
            {
                Console.WriteLine(temp.data + " ");
                temp = temp.next;
            }
        }
    }
}
