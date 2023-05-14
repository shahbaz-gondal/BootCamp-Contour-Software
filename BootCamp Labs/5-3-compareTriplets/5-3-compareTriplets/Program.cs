Console.WriteLine("Enter Alice's score, 3 space-separated numbers:");
int[] alice = Console.ReadLine()
        .Split(' ')
        .Select(item => int.Parse(item))
        .ToArray();

Console.WriteLine("\nEnter Bob's score 3 space-separated numbers:");
int[] bob = Console.ReadLine()
    .Split(' ')
    .Select(item => int.Parse(item))
    .ToArray();

for (int i = 0; i < alice.Length; i++)
{
    if (alice[i] >= 1 && alice[i] <= 100 && alice.Length == 3)
    {
    }
    else
    {
        Console.WriteLine("\nError: Enter only 3 scores and in range of 1 to 100...");
        System.Environment.Exit(0);
    }
}
for (int i = 0; i < bob.Length; i++)
{
    if (bob[i] >= 1 && bob[i] <= 100 && bob.Length == 3)
    {
    }
    else
    {
        Console.WriteLine("\nError: Enter only 3 scores and in range of 1 to 100...");
        System.Environment.Exit(0);
    }
}

int[] result = compareTriplets(alice, bob);

Console.WriteLine($"\nAlice's and Bob's points:\n{result[0]} {result[1]}");

int[] compareTriplets(int[] alice, int[] bob)
{
    int a = 0, b = 0;
    for (int i = 0; i < 3; i++)
    {
        if (alice[i] > bob[i])
        {
            a++;
        }
        else if (alice[i] < bob[i])
        {
            b++;
        }
    }
    int[] result = { a, b };
    return result;
}