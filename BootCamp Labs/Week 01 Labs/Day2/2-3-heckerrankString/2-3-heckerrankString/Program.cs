Console.WriteLine("How many Lines You want to enter?");
string h = Console.ReadLine();
int q = Convert.ToInt32(h);

for (int k = 1; k <= q; k++)
{
    Console.WriteLine($"\nEnter {k} String in lower Alphabets:");
    string s = Console.ReadLine();
    string result = heckerRank(s);
    Console.WriteLine(result);
}




string heckerRank(string s)
{
    string str = "heckerrank";
    int count = 0, next = 0;
    if (s.Length >= 10 && s.Length <= 10e4)
    {
        for (int i = 0; i < str.Length; i++)
        {
            if (next <= s.Length)
            {
                for (int j = next; j < s.Length; j++)
                {
                    if (str[i] == s[j])
                    {
                        count++;
                        next = j + 1;
                        break;
                    }
                }
            }
            else
            {
                return "NO";
            }
        }
        if (count == 10)
        {
            return "YES";
        }
        else
        {
            return "NO";
        }
    }
    else
    {
        return "NO";
    }
}