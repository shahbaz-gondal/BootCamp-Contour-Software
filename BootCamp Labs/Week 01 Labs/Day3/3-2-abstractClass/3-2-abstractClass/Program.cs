using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_2_abstractClass
{
    internal class Program
    {
        static void Main()
        {
            MyBook b = new MyBook();
            b.setTitle();
            string title = b.getTitle();
            Console.WriteLine($"The Title is: {title}");
        }
    }
}
