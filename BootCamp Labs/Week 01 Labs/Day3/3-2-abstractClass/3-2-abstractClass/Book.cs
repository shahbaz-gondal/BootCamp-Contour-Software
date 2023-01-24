using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_2_abstractClass
{
    abstract class Book
    {
        public string title;
        public abstract void setTitle();
        public string getTitle()
        {
            return title;
        }
    }
}
