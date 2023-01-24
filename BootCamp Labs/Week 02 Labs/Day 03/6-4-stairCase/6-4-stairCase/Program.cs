Console.WriteLine("Enetr an Integer:");
int n = Convert.ToInt32(Console.ReadLine());

stairCase(n);

void stairCase(int n)
{
    for (int i = 0; i < n; i++)
    {
        for (int j = n - 1; j >= 0; j--)
        {
            if (j > i)
            {
                Console.Write(" ");
            }
            else
            {
                Console.Write("#");
            }
        }
        Console.Write('\n');
    }
}
