Console.WriteLine("Enter the size of an array:");
int size = Convert.ToInt32(Console.ReadLine());

int[] arr = new int[size];

Console.WriteLine($"Enter {size} integers:");
for (int k = 0; k < size; k++)
{
    arr[k] = Convert.ToInt32(Console.ReadLine());
}

int result = simpleArraySum(arr);

Console.WriteLine($"Sum of Array is: {result}");



int simpleArraySum(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        sum = sum + arr[i];
    }
    return sum;
}
