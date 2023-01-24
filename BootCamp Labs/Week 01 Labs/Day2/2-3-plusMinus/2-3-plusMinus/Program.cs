Console.WriteLine("Write the size of an array:");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Enter {size} values in an array:");
string s;
int[] arr = new int[size];
for(int i=0; i<size; i++)
{
    arr[i] = Convert.ToInt32(Console.ReadLine());
}

plusMinus(arr);

void plusMinus(int[] arr)
{
    float neg = 0, zer = 0, pos = 0;
    for(int i=0; i<size; i++)
    {
        if(arr[i] < 0)
        {
            neg++;
        }
        if (arr[i] == 0)
        {
            zer++;
        }
        if (arr[i] > 0)
        {
            pos++;
        }
    }
    float result1 = neg/size, result2 = zer/size, result3 = pos/size;
    Console.WriteLine($"\nResults in Ratio:\nnegative: {result1.ToString("0.000000")}\nzero: {result2.ToString("0.000000")}" +
        $"\npositive: {result3.ToString("0.000000")}");
}
