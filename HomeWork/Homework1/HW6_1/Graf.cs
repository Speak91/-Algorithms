﻿using System.Collections.Generic;

namespace HW6_1
{
    public class Graf
    {

        List<Node> Nodes { get; set; }
        public Graf()
        {
            Nodes = new List<Node>();
        }

        public Graf(IEnumerable<int> collection)
        {
            Nodes = new List<Node>();
            AddNodeRange(collection);
        }

        public void AddNode(int nodeValue)
        {
            Nodes.Add(new Node(nodeValue));
        }

        public void AddNodeRange(IEnumerable<int> collection)
        {
            foreach (var value in collection)
            {
                AddNode(value);
            }
        }

         Node GetNodeByValue(int nodeValue)
        {
            foreach (var node in Nodes)
            {
                if (node.Value == nodeValue)
                {
                    return node;
                }
            }
            return null;
        }

        public void AddEdge(int firstNodeValue, int secondNodeValue, int weight)
        {
            var firstNode = GetNodeByValue(firstNodeValue);
            var secondNode = GetNodeByValue(secondNodeValue);
            if (firstNode != null && secondNode != null)
            {
                firstNode.AddEdge(secondNode, weight);
                secondNode.AddEdge(firstNode, weight);
            }
        }

        public string BFS(int value)
        {
            string s = string.Empty;
            Queue<Node> queue = new Queue<Node>();

            foreach (var node in Nodes)
            {
                node.IsVisited = false;
            }

            Node startNode = GetNodeByValue(value);
            startNode.IsVisited = true;
            queue.Enqueue(startNode);
            while (queue.Count != 0)
            {
                Node node = queue.Dequeue();
                s += node.ToString() + " ";
                for (int i = 0; i < node.Edges.Count; i++)
                {
                    Node tmp = node.Edges[i].Node;
                    if (!tmp.IsVisited)
                    {
                        queue.Enqueue(tmp);
                        tmp.IsVisited = true;
                    }
                }
            }
            return s;
        }

        public string DFS(int value)
        {
            string s = string.Empty;
            var stack = new Stack<Node>();

            foreach (var node in Nodes)
            {
                node.IsVisited = false;
            }

            Node startNode = GetNodeByValue(value);
            startNode.IsVisited = true;
            stack.Push(startNode);
            while (stack.Count != 0)
            {
                Node node = stack.Pop();
                s += node.ToString() + " ";
                for (int i = 0; i < node.Edges.Count; i++)
                {
                    Node tmp = node.Edges[i].Node;
                    if (!tmp.IsVisited)
                    {
                        stack.Push(tmp);
                        tmp.IsVisited = true;
                    }
                }
            }
            return s;
        }

        public override string ToString()
        {
            string s = string.Empty;
            foreach (var node in Nodes)
            {
                s += node.ToString() + "\t";
            }
            return s;
        }
    }
}
