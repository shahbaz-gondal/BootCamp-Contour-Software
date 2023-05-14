using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_6_insertAtSpecificPosition
{
    internal class Node
    {
        public Object data;
        public Node next;
        public Node(Object data)
        {
            this.data = data;
            this.next = null;
        }
    }
}
