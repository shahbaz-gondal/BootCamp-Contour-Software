Console.WriteLine("Enter the size of an array in range of 1 to 10:");
int n = Convert.ToInt32(Console.ReadLine());
if(!(n >=1 && n<=10))
{
    Console.WriteLine("\nError: Enter the size of an array in range of 1 to 10.");
    System.Environment.Exit(0);
}
Console.WriteLine($"Enter {n} space-separated values in range of 0 to 10e10:");
long[] arr = Console.ReadLine()
        .Split(' ')
        .Select(item => long.Parse(item))
        .ToArray();

for (int i=0; i<arr.Length; i++)
{
    if (!(arr[i] >=0 && arr[i] <= 10e10))
    {
        Console.WriteLine("\nError: Enter a number in range of 0 to 10e10.");
        System.Environment.Exit(0);
    }
}

long result = bigSum(arr);

Console.WriteLine($"\nSum of all the number is:\n{result}");
long bigSum(long[] arr)
{
    long sum = 0;
    for(int i=0; i<arr.Length; i++)
    {
        sum = sum + arr[i];
    }
    return sum;
}