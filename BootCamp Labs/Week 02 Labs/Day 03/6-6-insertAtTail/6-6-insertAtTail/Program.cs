namespace _6_6_insertAtTail
{
    internal class Program
    {
        static void Main()
        {
            LinkedList list = new LinkedList();
            Console.WriteLine("Enter 'y' to insert node at tail\nEnter 'e' to exit program:");
            char c = Convert.ToChar(Console.ReadLine());
            int v;
            while (c == 'y' || c == 'p')
            {
                if(c == 'y')
                {
                    Console.WriteLine("Enter an integer to store:");
                    v = Convert.ToInt32(Console.ReadLine());
                    list.insertAtTail(v);
                }
                if(c== 'p')
                {
                    list.printList();
                }
                Console.WriteLine("\nEnter 'y' to insert node at tail\nEnter 'p' to print values\nEnter 'e' to exit program:");
                c = Convert.ToChar(Console.ReadLine());
            }
        }
    }
}
