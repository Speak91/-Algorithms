﻿namespace HW6_1
{
    class Edge
    {
            public int Weight { get; set; }
            public Node Node { get; set; }

            public Edge(Node node, int weight)
            {
                Node = node;
                Weight = weight;
            }
    }
}
