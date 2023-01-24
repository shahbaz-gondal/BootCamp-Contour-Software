Console.WriteLine("Enter size of an array:");
int n = Convert.ToInt32(Console.ReadLine());

if (!(n > 0 && n < 1000))
{
    Console.WriteLine("\nError: Enter size greater in range of 0 to 1000.");
    System.Environment.Exit(0);
}


Console.WriteLine($"Enter {n} integers:");
int[] arr = Console.ReadLine()
    .Split(' ')
    .Select(item => int.Parse(item))
    .ToArray();

if (!(arr.Length == n))
{
    Console.WriteLine($"\nError: Enter {n} numbers only.");
    System.Environment.Exit(0);
}

for (int i = 0; i < arr.Length; i++)
{
    if (!(arr[i] > 0 && arr[i] < 100))
    {
        Console.WriteLine("\nError: Enter number in range of 0 to 1000.");
        System.Environment.Exit(0);
    }
}

Console.WriteLine($"\nSum of all the values of an array is:\n{arraySum(arr)}");

int arraySum(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < n; i++)
    {
        sum = sum + arr[i];
    }
    return sum;
}
