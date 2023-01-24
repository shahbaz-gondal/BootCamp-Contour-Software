Console.WriteLine("Enter Password of at least 6 characters:");
string pass = Console.ReadLine();
int result = strongPassword(pass);
Console.WriteLine($"\nTotal ==> {result} more characters needed...");

static int strongPassword(string pass)
{
    bool digit = false;
    bool lower = false;
    bool upper = false;
    bool special = false;
    int result = 0;
    int count = 0;
    if(pass.Length>=1 && pass.Length<=100)
    {
        foreach (char c in pass)
        {
            if (c >= '0' && c <= '9')
            {
                if(digit == false)
                {
                    count = count + 1;
                }
                digit = true;
            }
            else if ((int)c >= 65 && (int)c <= 90)
            {
                if (upper == false)
                {
                    count = count + 1;
                }
                upper = true;
            }
            else if ((int)c >= 97 && (int)c <= 122)
            {
                if (lower == false)
                {
                    count = count + 1;
                }
                lower = true;
            }
            else if ((int)c == 33 || (int)c >= 35 && (int)c <= 38 || (int)c >= 40 && (int)c <= 43 || (int)c >= 45 || (int)c >= 64 || (int)c >= 94)
            {
                if (special == false)
                {
                    count = count + 1;
                }
                special = true;
            }
        }
        if(pass.Length<6)
        {
            result = 6 - pass.Length;
        }
        if(count<4)
        {
            result = 4 - count;
        }
        if (digit == false)
        {
            Console.WriteLine("At Least 1 numeric value needed");
        }
        if (lower == false)
        {
            Console.WriteLine("At Least 1 lower alphabet needed");
        }
        if (upper == false)
        {
            Console.WriteLine("At Least 1 upper alphabet needed");
        }
        if (special == false)
        {
            Console.WriteLine("At Least 1 special key needed");
        }
    }
    return result;
}