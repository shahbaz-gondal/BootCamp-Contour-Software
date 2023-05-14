using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_6_deleteNode
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
            if(head == null)
            {
                head= newNode;
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
        public void deleteNode(Object v)
        {
            if (head == null)
            {
                Console.WriteLine("\n************************\nERROR:No Node available to delete(Size=0)\n************************");
            }
            else
            {
                Node temp = head;
                Node prev = head;
                int value = Convert.ToInt32(temp.data);
                int valueGiven = Convert.ToInt32(v), i = 0;
                while (value != valueGiven && temp.next != null)
                {
                    prev = temp;
                    temp = temp.next;
                    value = Convert.ToInt32(temp.data);
                    i++;
                }
                if (value == valueGiven && i == 0)
                {
                    head = temp.next;
                    Console.WriteLine($"\n*******************\nNode '{valueGiven}' is deleted\n*******************");
                }
                else if (value == valueGiven && i != 0)
                {
                    prev.next = temp.next;
                    Console.WriteLine($"\n*******************\nNode '{valueGiven}' is deleted\n*******************");
                }
                else
                {
                    Console.WriteLine($"\n********************\nNode '{valueGiven}' not Found...\n********************");
                }
            }
        }
        public void printList()
        {
            if(head == null)
            {
                Console.WriteLine("\n************************\nERROR:No Node available to Show(Size=0)\n************************");
            }
            else
            {
                Console.WriteLine("\n************************\nAll elements of list:");
                Node temp = head;
                while(temp!=null)
                {
                    Console.Write(temp.data + " ");
                    temp = temp.next;
                }
                Console.WriteLine("\n************************\n");
            }
        }
    }
}
