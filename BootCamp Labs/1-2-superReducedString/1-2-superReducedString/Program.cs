Console.WriteLine("Enter a String of length between 1 to 100:");
string s = Console.ReadLine();
string result = superReducedString(s);
Console.WriteLine($"Super Reduced String is:\n{result}");

static string superReducedString(string s)
{
    if (s.Length>=1 && s.Length<=100)
    {
        for(int i=0; i<s.Length; i++)
        {
            if(s.Length>i+1)
            {
                if (s[i] == s[i + 1])
                {
                    s = s.Remove(i, 2);
                    i--;
                }
            }
            else
            {
                break;
            }
        }
        if(s.Length>0)
        {
            return s;
        }
        else
        {
            return s = "Empty String";
        }
    }
    else
    {
        return s = "Enter String in Range...";
    }
}
