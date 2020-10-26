using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListDSProblem
{
    public class Node
    {
        public int data;
        public Node next;
        public Node(int data)
        {
            this.data = data;
        }

        public static implicit operator Node(LinkedListNode<int> v)
        {
            throw new NotImplementedException();
        }
    }
}
