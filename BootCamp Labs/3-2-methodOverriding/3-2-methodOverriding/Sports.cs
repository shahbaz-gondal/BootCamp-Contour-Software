using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_2_methodOverriding
{
    internal class Sports
    {
        public virtual string getName()
        {
            return ("Generic Sports");
        }
        public virtual void getNumberOfTeamMembers()
        {
            Console.WriteLine("Each team has n players in " + getName());
        }
    }
}
