using System;
namespace HW6_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Graf graf = new Graf(); // Первый способ создания графа
            graf.AddNode(10);
            graf.AddNode(7);
            graf.AddNode(12);
            graf.AddNode(11);
            graf.AddNode(6);
            graf.AddNode(14);
            graf.AddNode(13);
            graf.AddEdge(10, 12, 1);
            graf.AddEdge(10, 7, 1);
            graf.AddEdge(7, 11, 1);
            graf.AddEdge(12, 11, 1);
            graf.AddEdge(7, 6, 1);
            graf.AddEdge(12, 14, 1);
            graf.AddEdge(6, 13, 1);
            graf.AddEdge(14, 13, 1);

            Console.WriteLine("graf: " + graf.ToString() + "\n");

            Console.WriteLine(graf.BFS(10) + "\n");

            Console.WriteLine(graf.DFS(10) + "\n");
        }
    }
}
