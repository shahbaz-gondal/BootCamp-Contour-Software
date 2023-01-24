using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_2_Inheritance1
{
    internal class Bird: Animal
    {
        public void Fly()
        {
            Console.WriteLine("I am Flying");
        }
        public void Sing()
        {
            Console.WriteLine("I am Singing");
        }
    }
}
