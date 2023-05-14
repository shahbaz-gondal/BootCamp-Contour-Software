using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_6_insertAtHead
{
    internal class LinkedList
    {
        public Node head;
        public LinkedList()
        {
            this.head = head;
        }
        public void insertAtHead(Object data)
        {
            Node newNode = new Node(data);
            if(head == null)
            {
                head = newNode;
            }
            else
            {
                Node temp = head;
                head = newNode;
                newNode.next = temp;
            }
        }
        public void printList()
        {
            Node temp = head;
            while(temp!=null)
            {
                Console.WriteLine(temp.data + " ");
                temp = temp.next;
            }
        }
    }
}
