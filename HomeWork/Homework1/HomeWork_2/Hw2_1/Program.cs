using System;

namespace Hw2_1
{

    class Program
    {
        static void Main(string[] args)
        {
            LinkedList linkedList = new LinkedList();
            linkedList.AddNode(1);
            linkedList.AddNode(2);
            linkedList.AddNode(3);
            linkedList.AddNode(4);
            linkedList.AddNode(5);

            PrintList(linkedList);
            linkedList.RemoveNode(2);
            PrintList(linkedList);
        }
        static void PrintList(LinkedList list)
        {
            var node = list.Head;
            while (node != null)
            {
                Console.WriteLine(node.Value + "");
                node = node.NextNode;
            }
            Console.WriteLine();
        }
    }
}
