Console.WriteLine("Enter the size of an array:");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the number of rotations you want to perform:");
int d = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Enter {n} numbers in an array:");

int[] arr = new int[n];

for(int i=0;i<n;i++)
{
    arr[i] = Convert.ToInt32(Console.ReadLine());
}

int[] result = leftRotate(arr);
Console.Write("\n");
for(int i=0;i<n;i++)
{
    Console.Write(result[i] + " ");
}
int[] leftRotate(int[] arr)
{
    int temp = 0, j = 0;
    for(int i=0;i<d;i++)
    {
        temp = arr[0];
        for(j=0; j<n-1; j++)
        {
            arr[j] = arr[j + 1];
        }
        arr[j] = temp;
    }
    return arr;
}
