using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_2_methodOverriding
{
    internal class Soccer: Sports
    {
        public override string getName()
        {
            return ("Soccer Class");
        }
        public override void getNumberOfTeamMembers()
        {
            Console.WriteLine("Each team has 11 players in " + getName());
        }
    }
}
