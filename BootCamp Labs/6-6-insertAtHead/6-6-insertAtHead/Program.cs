namespace _6_6_insertAtHead
{
    internal class Program
    {
        static void Main()
        {
            LinkedList list = new LinkedList();
            Console.WriteLine("Enter 'y' to insert at head:\nEnter 'e' to exit program:");
            char c = Convert.ToChar(Console.ReadLine());
            int v = 0;
            while (c == 'y' || c == 'p')
            {
                if(c=='y')
                {
                    Console.WriteLine("Enter an integer you want to insert at head:");
                    v = Convert.ToInt32(Console.ReadLine());
                    list.insertAtHead(v);
                }
                if(c=='p')
                {
                    Console.WriteLine("\nAll elements of list:");
                    list.printList();
                }
                Console.WriteLine("Enter 'y' to insert at head:\nEnter 'p' to print values:\nEnter 'e' to exit program:");
                c = Convert.ToChar(Console.ReadLine());
            }
        }
    }
}
