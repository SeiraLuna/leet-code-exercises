


//Linked List Implementation -- Second implementation confirming to leetcode's naming conventions.
using System;
using System.Runtime.Remoting.Contexts;

namespace leet_code_exercises
{
    class leetcode
    {
        static void Main()
        {
            MyLinkedList myLinkedList = new MyLinkedList() { };
           
            for (var i = 0; i < 10; i++)
            {
                myLinkedList.AddAtHead(i + 1);
            }

            myLinkedList.AddAtHead(1);
            myLinkedList.AddAtTail(3);
            myLinkedList.AddAtIndex(1,2);
            Console.WriteLine(  myLinkedList.Get(1));
            myLinkedList.DeleteAtIndex(1);
            Console.WriteLine(  myLinkedList.Get(1));
    
            for ( var i = 0; i < 12; i++)
            {
                Console.WriteLine(myLinkedList.Get(i));
            }


            Console.ReadKey();
        }
    }
}


/*
//Linked List Implementation
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet_code_exercises
{
    class leetcode
    {
        static void Main(string[] args)
        {
            LCLinkedList testLL = new LCLinkedList();

            for (var v = 1; v < 11; v++)
            {
                testLL.InsertHead(v);
            }
            
            testLL.InsertTail(27);
            testLL.Insert(5, 14);
            testLL.Delete(0);

            testLL.printList();

            int nodeNum = 5;

            Console.WriteLine($"\n Node {nodeNum} : {testLL.Get(nodeNum)}");


            Console.ReadKey();
        }
    }
}
*/