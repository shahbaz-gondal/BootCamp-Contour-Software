using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_6_insertAtSpecificPosition
{
    internal class LinkedList
    {
        public Node head;
        public LinkedList()
        {
            head = null;
        }
        public int insertAtPosition(Object data, int p, int i)
        {
            Node newNode = new Node(data);
            Node temp;
            if (p == 0)
            {
                temp = head;
                newNode.next = temp;
                head = newNode;
                i++;
                return i;
            }
            else
            {
                temp = head;
                int count = -1;
                while (temp != null)
                {
                    temp = temp.next;
                    count++;
                }
                if (p > count + 1)
                {
                    Console.WriteLine("\n************************\nERROR:Entered position is out of index...\n************************");
                    return i;
                }
                else
                {
                    temp = head;
                    Node prev = head;
                    count = 0;
                    while (count < p)
                    {
                        prev = temp;
                        temp = temp.next;
                        count++;
                    }
                    newNode.next = temp;
                    prev.next = newNode;
                    i++;
                    return i;
                }
            }
        }
        public void printList()
        {
            Console.WriteLine("\n**********************");
            Console.WriteLine("All Elements of list:");
            Node temp = head;
            while(temp!=null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
            Console.WriteLine("\n**********************\n");
        }
    }
}
