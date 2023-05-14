namespace _6_4_bubbleSort
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter the size of an array:");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[size];
            Console.WriteLine($"Enter {size} values in an array:");
            for (int i=0; i<size; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            BubbleSort sort = new BubbleSort();
            int[] sortedArray = sort.bubbleSort(arr);
            Console.WriteLine("\nSorted Array:");
            sort.printArray(sortedArray);
        }
    }
}