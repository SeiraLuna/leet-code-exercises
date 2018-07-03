using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace leet_code_exercises
{
    class LCLinkedList
    {

        public Node Head = new Node();

        public LCLinkedList () { }

        public LCLinkedList(object value)
        {
            this.Head.Data = value;
            this.Head.Next = new Node();
        }

        public void printList()
        {
            Head.printNode(Head);
        }
        
        public object Get(int index)
        {
            Node temp = Head;
            for(var i = 0; i < index; i++)
            {
                temp = temp.Next;
            }
            return temp.Data;
        }


        public void InsertHead(object value)
        {
            Node node = new Node { };
            node.Data = Head.Data;
            node.Next = Head.Next;
            Head.Data = value;
            Head.Next = node;
        }
        /*
        public void InsertTail(object value)
        {
            Head.NodeInsertTail(Head, value);
        }*/

        public  void InsertTail(object value)
        {
            Node node = Head;
            while (true)
            {
                if (node.Data == null)
                {
                    node.Data = value;
                    node.Next = new Node();
                    break;
                }
                node = node.Next;
            }
        }
        /*
        public void Insert(int index, object value)
        {
            Head.Insert(Head, index, value);
        }*/
        
        public void Insert(int fromIndex, object value)
        {
            Node node = Head;
            while(fromIndex > -1)
            {
                fromIndex--;
                if (fromIndex == 0)
                {
                    Node newNode = new Node();
                    newNode.Next = node.Next;
                    newNode.Data = value;
                    node.Next = newNode;
                    break;
                }
                node = node.Next;
            }
        }

        public void Delete(int fromIndex)
        {
            Node node = Head;
            if(fromIndex == 0)
            {
                Head = node.Next;
                return;
            }
            while(fromIndex > -1)
            {
                fromIndex--;
                if(fromIndex == 0)
                {
                    node.Next = node.Next.Next;
                    break;
                }
                node = node.Next;
            }
        }
    }
}
