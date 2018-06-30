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

            testLL.printList();

            int nodeNum = 5;

            Console.WriteLine($"\n Node {nodeNum} : {testLL.Get(nodeNum)}");


            Console.ReadKey();
        }
    }
}
