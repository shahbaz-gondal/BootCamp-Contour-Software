using System.Net.NetworkInformation;

Console.WriteLine("Enter '1' to push\nEnter '2' to inqueue");
char c = Convert.ToChar(Console.ReadLine());
List<int> list = new List<int>();
int i = 0;

while (c!='e')
{
    if(c=='1')
    {
        push();
        Run();
    }
    if(c=='2')
    {
        inqueue();
        Run();
    }
    if(c=='3')
    {
        pop();
        Run();
    }
    if(c=='4')
    {
        dequeue();
        Run();
    }
    if(c=='p')
    {
        printValues();
        Run();
    }
}
Console.WriteLine("\nProgram Exited");
void Run()
{
    Console.WriteLine("\nEnter '1' to push\nEnter '2' to inqueue\nEnter '3' to pop\nEnter '4' to dequeue\nEnter 'p' to Show\nEnter 'e' to Exit");
    c = Convert.ToChar(Console.ReadLine());
}
void push()
{
    Console.WriteLine("\nEnter a value you want to Push: ");
    list.Add(Convert.ToInt32(Console.ReadLine()));
    i++;
    Console.WriteLine("value Pushed\n");
}
void pop()
{
    if(list.Count > 0)
    {
        i--;
        list.RemoveAt(i);
        Console.WriteLine("Value poped");
    }
    else
    {
        Console.WriteLine("\nThere is no value to pop");
    }
}
void inqueue()
{
    Console.WriteLine("\nEnter a value you want to inqueue: ");
    list.Add(Convert.ToInt32(Console.ReadLine()));
    i++;
    Console.WriteLine("value inqueued\n");
}
void dequeue()
{
    if(list.Count>0)
    {
        list.RemoveAt(0);
        i--;
        Console.WriteLine("\nValue dequeued");
    }
    else
    {
        Console.WriteLine("\nThere is no value to dequeue");
    }
}
void printValues()
{
    if(list.Count > 0)
    {
        Console.WriteLine("\nThese are the stored values\n");
        for (int k = 0; k < list.Count; k++)
        {
            Console.Write(list[k] + " ");
        }
    }
    else
    {
        Console.WriteLine("\nNo Value to Show\n");
    }
}