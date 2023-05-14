using System.Diagnostics.CodeAnalysis;

Console.WriteLine("Enter the number of rows and columns you want:");
int n = Convert.ToInt32(Console.ReadLine());
int var = 0;
int[,] arr = new int[n, n];
Console.WriteLine($"Enter {n*n} number in a 2d array:");
for(int i=0; i<n; i++)
{
    for(int j=0; j<n; j++)
    {
        arr[i, j] = Convert.ToInt32(Console.ReadLine());
    }
}

int result = diagonalDifference(arr);


Console.WriteLine($"Difference of Diagonals is: {result}");

int diagonalDifference(int[,] arr)
{
    int suml = 0, sumr = 0;
    for (int i = 0; i < n; i++)
    {
        for (int j = i; j < n; j++)
        {
            suml = suml + arr[i, j];
            break;
        }
    }

    for (int i = 0; i < n; i++)
    {
        for (int j = n - 1 - i; j >= 0; j++)
        {
            sumr = sumr + arr[i, j];
            break;
        }
    }
    return suml - sumr;
}

