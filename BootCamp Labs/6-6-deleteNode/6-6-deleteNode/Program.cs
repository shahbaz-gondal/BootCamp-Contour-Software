namespace _6_6_deleteNode
{
    internal class Program
    {
        static void Main()
        {
            LinkedList list = new LinkedList();
            Console.WriteLine("Enter 'a' to add Node:\nEnter 'd' to delete Node:\nEnter 'p' to print data:\nEnter 'e' to exit:");
            char c = Convert.ToChar(Console.ReadLine());
            Object v = 0;
            while(c != 'e')
            {
                if(c == 'a')
                {
                    Console.WriteLine("\nEnter data you wants to store:");
                    v = Convert.ToInt32(Console.ReadLine());
                    list.Add(v);
                }
                else if(c == 'd')
                {
                    Console.WriteLine("\nEnter data you wants to delete:");
                    v = Convert.ToInt32(Console.ReadLine());
                    list.deleteNode(v);
                }
                else if(c == 'p')
                {
                    list.printList();
                }
                Console.WriteLine("\nEnter 'a' to add Node:\nEnter 'd' to delete Node:\nEnter 'p' to print data:\nEnter 'e' to exit:");
                c = Convert.ToChar(Console.ReadLine());
            }
        }
    }
}
