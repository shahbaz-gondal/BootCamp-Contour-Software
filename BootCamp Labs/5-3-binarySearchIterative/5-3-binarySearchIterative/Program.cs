namespace _5_3_binarySearchIterative
{
    internal class Program
    {
        public static void Main()
        {
            Sort bs = new Sort();
            Console.WriteLine("Enter Size of an Array:");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            Console.WriteLine($"Enter {n} numbers in an Array:");
            for (int i=0; i<n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            arr = bs.sortArray(arr);
            Console.WriteLine("\nSorted array is:");
            bs.printArray(arr);
            Console.WriteLine("\nEnter the number you want to find:");
            int x = Convert.ToInt32(Console.ReadLine());
            int result = bs.binarySearch(arr, x);
            if (result != -1)
            {
                Console.WriteLine($"\nNumber is at position: {result}");
            }
            else
            {
                Console.WriteLine($"\nNumber not Found...");
            }
        }
    }
}