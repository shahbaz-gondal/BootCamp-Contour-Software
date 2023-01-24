using System.Globalization;

Console.WriteLine("Enter a size of an Array:");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Enter {n} numbers in an Array:");
int[] arr = new int[n];

for (int i=0; i<n; i++)
{
    arr[i] = Convert.ToInt32(Console.ReadLine());
}

int[] result = reverseArray(arr);
Console.WriteLine("Reversed Array is:");
for (int i = 0; i < result.Length; i++)
{
    Console.Write(result[i]+" ");
}

int[] reverseArray(int[] arr)
{
    int[] arr1 = new int[arr.Length];
    int j = 0;
    for(int i=arr.Length-1; i>=0; i--)
    {
        arr1[j] = arr[i];
        j++;
    }
    return arr1;
}