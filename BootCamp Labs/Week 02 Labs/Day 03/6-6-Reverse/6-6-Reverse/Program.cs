namespace _6_6_Reverse
{
    internal class Program
    {
        static void Main()
        {
            LinkedList list = new LinkedList();
            Console.WriteLine("Enter 'a' to add Node:\nEnter 'e' to Exit");
            char c = Convert.ToChar(Console.ReadLine());
            int v = 0;
            while(c != 'e')
            {
                if(c == 'a')
                {
                    Console.WriteLine("\nEnter integer to store:");
                    v = Convert.ToInt32(Console.ReadLine());
                    list.Add(v);
                }
                if (c == 'r')
                {
                    list.Reverse();
                    Console.WriteLine("\n********************\nList has been Reversed:\n********************\n");
                }
                if (c == 'p')
                {
                    list.printList();
                }
                Console.WriteLine("Enter 'a' to add Node:\nEnter 'r' to reverse list:\nEnter 'p' to print list:\nEnter 'e' to Exit");
                c = Convert.ToChar(Console.ReadLine());
            }
        }
    }
}