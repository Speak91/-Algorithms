using System.Collections.Generic;

namespace HW6_1
{
    class Node
    {
        public int Value { get; set; }
        public List<Edge> Edges { get; set; }
        public bool IsVisited { get; set; }

        public Node(int value) // Создать узел(вершину)
        {
            Value = value;
            Edges = new List<Edge>();
        }

        public void AddEdge(Edge newEdge) // Добавить ребро
        {
            Edges.Add(newEdge);
        }

        public void AddEdge(Node node, int weight) // Добавить ребро
        {
            AddEdge(new Edge(node, weight));
        }

        public override string ToString() => Value.ToString();
    }
}
