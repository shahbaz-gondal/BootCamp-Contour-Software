namespace _6_6_insertAtSpecificPosition
{
    internal class Program
    {
        static void Main()
        {
            LinkedList list = new LinkedList();
            Console.WriteLine("Enter 'r' to insert value:\nEnter 'e' to Exit:");
            char c = Convert.ToChar(Console.ReadLine());
            int i = 0;
            while(c != 'e')
            {
               
                if(c == 'r')
                {
                    Console.WriteLine("Enter an integer you want to store:");
                    int n = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"Enter Position where you want to store\n(Select position from 0 to {i}):");
                    int p = Convert.ToInt32(Console.ReadLine());
                    i = list.insertAtPosition(n, p, i);
                }
                if(c == 'p')
                {
                    list.printList();
                }
                if(c!='r' || c!='p' ||c!='e')
                {
                    Console.WriteLine("\nERROR: Entered Wrong Key\nTryAgain...");
                }
                Console.WriteLine("\nEnter 'r' to insert more:\nEnter 'p' to print list:\nEnter 'e' to Exit:");
                c = Convert.ToChar(Console.ReadLine());
            }
            Console.WriteLine("\n************************\nProgram Terminated:\n************************");
        }
    }
}