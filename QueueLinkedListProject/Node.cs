using System;
using System.Collections.Generic;
using System.Text;

namespace QueueLinkedListProject
{
    class Node
    {
        public int info;
        public Node link;
        public Node(int x)
        {
            info = x;
            link = null;
        }
    }
}
