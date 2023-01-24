Console.WriteLine("Enter the size of an array:");
int size = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[size];
Console.WriteLine($"Enter {size} values in an array:");
for(int i=0; i<size; i++)
{
    arr[i] = Convert.ToInt32(Console.ReadLine());
}
int[] sortedArray = selectionSort(arr);
printArray(sortedArray);
int[] selectionSort(int[] arr)
{
    int min = 0, temp = 0;
    bool flag = false;
    for(int i=0; i<size-1; i++)
    {
        for(int j=i+1; j<size; j++)
        {
            if (arr[i] > arr[j])
            {
                min = j;
                flag = true;
            }
        }
       if(flag == true)
        {
            temp = arr[i];
            arr[i] = arr[min];
            arr[min] = temp;
        }
        flag = false;
    }
    return arr;
}
void printArray(int[] sortedArray)
{
    for(int i=0; i<size; i++)
    {
        Console.Write(sortedArray[i]+" ");
    }
}