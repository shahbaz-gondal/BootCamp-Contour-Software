using Microsoft.VisualBasic.FileIO;
using System;
using System.Globalization;

Console.WriteLine("How many birds you want to add:");
int n = Convert.ToInt32(Console.ReadLine());
int nn = 0;
Console.WriteLine($"Add {n} types of birds:");
int[] arr = new int[n];
if (n>=5 && n<=2*10e5)
{
    for (int i = 0; i < n; i++)
    {
        nn = Convert.ToInt32(Console.ReadLine());
        if(nn>=1 && nn<=5)
        {
            arr[i] = nn;
        }
        else
        {
            Console.WriteLine("Type of bird should be between 1 to 5...");
            System.Environment.Exit(0);
        }
    }
    Console.WriteLine("\n");
}
else
{
    Console.WriteLine("Total Type of birds should be between 5 to 2*10E5:");
    System.Environment.Exit(0);
}

migratoryBirds(arr);

void migratoryBirds(int[] arr)
{
    int t1=0,t2=0,t3=0,t4=0,t5=0, temp = 0;
    int n1=0, n2=0, n3=0, n4=0, n5=0;


    for(int i=0; i<arr.Length; i++)
    {
        for (int j=0; j<arr.Length-1; j++)
        {
            if (arr[j] > arr[j+1])
            {
                temp = arr[j];
                arr[j] = arr[j + 1];
                arr[j + 1] = temp;
            }
        }
    }
    for(int i=0; i<n; i++)
    {
        if (arr[i] == 1)
        {
            if(i == n-1)
            {
                n1++;
                t1 = arr[i];
            }
            else
            {
                if (arr[i] == arr[i + 1])
                {
                    n1++;
                }
                else
                {
                    n1++;
                    t1 = arr[i];
                }
            }
        }
        if (arr[i] == 2)
        {
            if (i == n - 1)
            {
                n2++;
                t2 = arr[i];
            }
            else
            {
                if (arr[i] == arr[i + 1])
                {
                    n2++;
                }
                else
                {
                    n2++;
                    t2 = arr[i];
                }
            }
        }
        if (arr[i] == 3)
        {
            if (i == n - 1)
            {
                n3++;
                t3 = arr[i];
            }
            else
            {
                if (arr[i] == arr[i + 1])
                {
                    n3++;
                }
                else
                {
                    n3++;
                    t3 = arr[i];
                }
            }
        }
        if (arr[i] == 4)
        {
            if (i == n - 1)
            {
                n4++;
                t4 = arr[i];
            }
            else
            {
                if (arr[i] == arr[i + 1])
                {
                    n4++;
                }
                else
                {
                    n4++;
                    t4 = arr[i];
                }
            }
        }
        if (arr[i] == 5)
        {
            if (i == n - 1)
            {
                n5++;
                t5 = arr[i];
            }
            else
            {
                if (arr[i] == arr[i + 1])
                {
                    n5++;
                }
                else
                {
                    n5++;
                    t5 = arr[i];
                }
            }
        }
    }
    var numbers = new Dictionary<int, int>()
    {
        {t1,n1 },
        {t2,n2 },
        {t3,n3 },
        {t4,n4 },
        {t5,n5 }
    };
    foreach(var item in numbers)
    {
        if(item.Key == 0)
        {
            numbers.Remove(item.Key);
        }
        else if(item.Key != 0)
        {
            Console.WriteLine($"Type {item.Key} : {item.Value}");
        }
    }
    int high = numbers.ElementAt(1).Value;
    for (int i=0; i<numbers.Count; i++)
    {
        if(high < numbers.ElementAt(i).Value)
        {
            high = numbers.ElementAt(i).Value;
        }
    }
    int count = 0, k=0;
    for (int i=0; i < numbers.Count; i++)
    {
        if (high == numbers.ElementAt(i).Value)
        {
            count++;
        }
    }
    int[] arr1 = new int[count];
    for (int i = 0; i < numbers.Count; i++)
    {
        if (high == numbers.ElementAt(i).Value)
        {
            arr1[k] = numbers.ElementAt(i).Key;
            k++;
        }
    }
    int low = arr1[0];
    for(int i=0; i<arr1.Length; i++)
    {
        if (low > arr1[i])
        {
            low = arr1[i];
        }
    }
    Console.WriteLine($"\nThe lower type which has highest frequency amoung all is:\n{low}");
}
