using System;
using HW4_2;
using System.Collections.Generic;
namespace HW5_1
{
    class Program
    {
       static BinaryTree binaryTree;
        static void Main(string[] args)
        {
            binaryTree = new BinaryTree(6);
            binaryTree.AddNode(1);
            binaryTree.AddNode(2);
            binaryTree.AddNode(7);
            binaryTree.AddNode(8);
            binaryTree.AddNode(5);
            binaryTree.AddNode(9);
            binaryTree.AddNode(3);

            BFS(3);
           
            Console.WriteLine("\n");
            
            DFS(5);
            
            Console.ReadLine();
        }
        public static TreeNode BFS(int value)
        {
            var queue = new Queue<TreeNode>();
            queue.Enqueue(binaryTree.Root);
            while (queue.Count != 0)
            {
                TreeNode treeNode = queue.Dequeue();
                Console.Write(treeNode.Data + " ");
                if (treeNode.Data == value)
                {
                    return treeNode;
                }
                if (treeNode.Left != null) queue.Enqueue(treeNode.Left);
                if (treeNode.Right != null) queue.Enqueue(treeNode.Right);
            }
            return null;
        }
        public static TreeNode DFS(int value)
        {
            var stack = new Stack<TreeNode>();
            stack.Push(binaryTree.Root);
            while (stack.Count != 0)
            {
                TreeNode node = stack.Pop();

                Console.Write(node.Data + " ");

                if (node.Data == value)
                {
                    return node;
                }
                if (node.Right != null) stack.Push(node.Right);
                if (node.Left != null) stack.Push(node.Left);
            }
            return null;
        }
    }
}
