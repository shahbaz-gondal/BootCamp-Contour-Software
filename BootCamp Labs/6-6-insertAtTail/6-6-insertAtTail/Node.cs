﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_6_insertAtTail
{
    internal class Node
    {
        public Object data;
        public Node next;
        public Node(object data)
        {
            this.data = data;
            this.next = null;
        }
    }
}
