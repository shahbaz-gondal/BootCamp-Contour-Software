using System.Runtime.CompilerServices;

Console.WriteLine("How many grades you want to Round:");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Enter {n} Grades between 1 to 100:");
int n1 = 0;
int[] arr = new int[n];

for(int i=0; i < n; i++)
{
    n1 = Convert.ToInt32(Console.ReadLine());
    if(n1>=1 && n1<= 100)
    {
        arr[i] = n1;
    }
    else
    {
        Console.WriteLine("ERROR: Grade must be between 1 to 100...");
        System.Environment.Exit(0);
    }
}

greatingStudents(arr);

void greatingStudents(int[] arr)
{
    for(int i=0; i<n; i++)
    {
        if (arr[i]>=38)
        {
            if (arr[i]%5 != 0)
            {
                int afterdividing = arr[i] / 5;
                afterdividing++;
                int aftermultiply = afterdividing * 5;
                int difference = aftermultiply - arr[i];
                if(difference < 3)
                {
                    arr[i] = aftermultiply;
                }
                afterdividing = 0;
                aftermultiply = 0;
                difference = 0;
            }
        }
    }
    Console.WriteLine("\nAfter Rounding:\n");
    for(int i=0; i<n; i++)
    {
        Console.WriteLine(arr[i]);
    }

}
