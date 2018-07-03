using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace leet_code_exercises
{
    class MyLinkedList
    {
        public Node Head;

        public MyLinkedList () { }

        public object Get(int index)
        {
            try
            {
                Node node = Head;
                for (var i = 0; i < index; i++)
                {
                    node = node.Next;
                }
                return node.Data;
            }
            catch
            {
                Console.WriteLine("The index you entered was invalid.");
                return -1;
            }
        }

        public void AddAtHead(int val)
        {
            if (Head == null)
            {
                Head = new Node();
                Head.Data = val;
            }
            else
            {
                Node node = new Node();
                node.Data = Head.Data;
                node.Next = Head.Next;
                Head.Data = val;
                Head.Next = node;
            }
        }

        public void AddAtTail(int val)
        {
            try
            {
                Node node = Head;
                while (node.Next != null)
                {
                    node = node.Next;
                }
                node.Next = new Node();
                node.Next.Data = val;
            }
            catch
            {
                Console.WriteLine("The index you entered was invalid.");
            }
        }

        public void AddAtIndex(int index, int val)
        {
            if (index == 0)
            {
                this.AddAtHead(val);
            }
            else
            {
                Node node = Head;
                try
                {
                    for (var i = 1; i < index; i++)
                    {
                        node = node.Next;
                    }
                    Node newNode = new Node();
                    newNode.Next = node.Next;
                    newNode.Data = val;
                    node.Next = newNode;
                }
                catch
                {
                    Console.WriteLine("The index you entered was invalid.");
                }
            }
        }

        public void DeleteAtIndex(int index)
        {
            try
            {
                if (index == 0)
                    Head = Head.Next;
                else
                {
                    Node node = Head;
                    for (var i = 1; i < index; i++)
                    {
                        node = node.Next;
                    }
                    node.Next = node.Next.Next;
                }

            }
            catch
            {
                Console.WriteLine("The index you entered was invalid.");
            }
        }
    }
}
