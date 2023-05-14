Console.WriteLine("Enter a string in camelCase: ");
string s = Console.ReadLine();
int result = CamelCase(s);
Console.WriteLine($"Number of Words in a string:\n{result}");

static int CamelCase(string s)
{
    int count = 0;
    if (s.Length>=1 && s.Length<=1e10)
    {
        foreach(char c in s)
        {
            if ((int)c >= 65 && (int)c <= 90)
            {
                count++;
            }
        }
        return count+1;
    }
    else
    {
        return count;
    }
}