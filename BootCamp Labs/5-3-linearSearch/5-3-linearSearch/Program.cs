namespace _5_3_linearSearch
{
    internal class Prohram
    {
        public static void Main()
        {
            Search ls = new Search();
            Console.WriteLine("Enter the size of an array");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            Console.WriteLine($"Enter {n} numbers in an array");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Enter a number you want to search:");
            int x = Convert.ToInt32(Console.ReadLine());
            int result = 0;
            result = ls.linearSearch(arr, x);
            if (result == -1)
            {
                Console.WriteLine("\nNumber not found...");
            }
            else
            {
                Console.WriteLine($"\nNumber is at position: {result}");
            }
        }

    }
}

