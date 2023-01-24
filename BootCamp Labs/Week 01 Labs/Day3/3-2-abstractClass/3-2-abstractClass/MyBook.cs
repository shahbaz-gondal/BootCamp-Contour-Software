using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_2_abstractClass
{
    internal class MyBook: Book
    {
        public override void setTitle()
        {
            Console.WriteLine("Enter the title of book:");
            title = Console.ReadLine();
        }
    }
}
