using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace leet_code_exercises
{
    class Node
    {
        public object Data;
        public Node Next;

        public Node()
        {
            this.Data = null;
            this.Next = null;
        }

        public Node(object data)
        {
            this.Data = data;
            this.Next = new Node();
        }

        public void printNode(Node node)
        {
            if (node.Data == null)
                return;
            Console.WriteLine(node.Data);
            printNode(node.Next);
        }

        public void NodeInsertTail(Node node, object value)
        {
            if (node.Data == null)
            {
                node.Data = value;
                node.Next = new Node();
            }
            else NodeInsertTail(node.Next, value);
        }

        public void Insert(Node node, int index, object value)
        {
            if (index == 1)
            {
                Node newNode = new Node();
                newNode.Data = value;
                newNode.Next = node.Next;
                node.Next = newNode;
                return;
            }
            if (node == null)
                return;
            Insert(node.Next, index - 1, value);
        }
    }
}
