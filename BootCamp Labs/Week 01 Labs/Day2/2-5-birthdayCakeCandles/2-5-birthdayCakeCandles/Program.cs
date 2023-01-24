using System.Runtime;

Console.WriteLine("Enter size of Candles:");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter height of each Candle:");
int[] arr = new int[n];

for (int i = 0; i<n; i++)
{
    arr[i] = Convert.ToInt32(Console.ReadLine());
}

int result = birthdayCakeCandles(arr);

Console.WriteLine($"Total Heighest Candles are: {result}");

int birthdayCakeCandles(int[] arr)
{
    int large = arr[0], count = 0;
    for(int i=0; i<n; i++)
    {
        if (large < arr[i])
        {
            large = arr[i];
        }
    }
    for (int i = 0; i < n; i++)
    {
        if(large == arr[i])
        {
            count++;
        }
    }
    return count;
}
