using System.ComponentModel.DataAnnotations;

int[,] arr = new int[6,6];

Console.WriteLine("Enter 6 values in 1 Row (1/6):");
for (int i = 0; i<6; i++)
{
    for(int j = 0; j<6; j++)
    {
        arr[i, j] = Convert.ToInt32(Console.ReadLine());
        if (arr[i, j]<-9 || arr[i, j]>9)
        {
            Console.WriteLine($"Entered value must be from -9 to 9...");
            System.Environment.Exit(0);
        }
    }
    if(i!=5)
    {
        Console.WriteLine($"\nEnter 6 values in {i+2} Row ({i+2}/6):");
    }
}

List<int> Sums = hourglassSum(arr);
int max = Sums[0];
for (int z=1; z<16; z++)
{
    if(max < Sums[z])
    {
        max = Sums[z];
    }
}

Console.WriteLine($"The maximum sum amoung all hourglass is: {max}");

List<int> hourglassSum(int[,] arr)
{
    List<int> allRecord = new List<int>();
    int sum = 0;
    for(int l=0; l<4; l++)
    {
        for (int k = 0; k < 4; k++)
        {
            sum = arr[l, k] + arr[l, k + 1] + arr[l, k + 2] + arr[l + 1, k + 1] + arr[l + 2, k] + arr[l + 2, k + 1] + arr[l + 2, k + 2];
            allRecord.Add(sum);
            sum = 0;
        }
    }
    return allRecord;
}

