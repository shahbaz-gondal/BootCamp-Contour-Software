namespace _6_6_printElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            Console.WriteLine("Enter the size of a Linked List:");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"\nEnter {n} values:");
            for (int i=1; i<=n; i++)
            {
                int v = Convert.ToInt32(Console.ReadLine());
                list.addAtLast(v);
            }
            Console.WriteLine("\nAll Elements of list:");
            list.printList();
        }
    }
}