

Console.WriteLine("Enter a String in Capital Alphabets of length 6: ");
string s = Console.ReadLine();
string se = "SOSSTR";
(int result, int invalid) = marsExploration(s, se);
if (invalid == 0)
{
    Console.WriteLine($"\nExpected String:\n{se}");
    Console.WriteLine($"Entered String:\n{s}\n");
    Console.WriteLine($"Alphabets that are changed:\n{result}");
}



static Tuple<int, int> marsExploration(string s, string se)
{
    int count = 0;
    int count1 = 0;
    if (s.Length >= 1 && s.Length <= 99 && s.Length % 3 == 0)
    {
        foreach (char c in s)
        {
            if ((int)c >= 65 && (int)c <= 90)
            {
                count1 = count1 + 1;
            }
            else
            {
                Console.WriteLine("entered string is not valid");
                int invalid = 1;
                return Tuple.Create(0, invalid);
            }
        }
        
        if (count1 == s.Length && s.Length == se.Length)
        {

            for (int c2 = 0; c2 < se.Length; c2++)
            {
                for (int c3 = 0; c3 < s.Length; c3++)
                {
                    if (c2 == c3)
                    {
                        if (s[c3] != se[c2])
                        {

                            count = count + 1;
                            break;
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }
            int invalid = 0;
            return Tuple.Create(count, invalid);
        }
        else
        {
            Console.WriteLine("entered string is not valid...");
            int invalid = 1;
            return Tuple.Create(0, invalid);
        }
    }
    else
    {
        Console.WriteLine("entered string is not valid");
        int invalid = 1;
        return Tuple.Create(0, invalid);
    }
}



