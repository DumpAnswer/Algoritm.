using System;
using System.Collections.Generic;
using System.Linq;

namespace Graphs
{
    class Program
    {

        static void Main(string[] args)
        {
            Graf graf = new Graf();
            graf.AddVertex(1);
            graf.AddVertex(2);
            graf.AddVertex(3);
            graf.AddVertex(4);
            graf.AddVertex(5);
            graf.AddVertex(6);
            graf.AddVertex(7);
            graf.AddVertex(8);
            graf.AddVertex(9);

            graf.AddEdge(1, 2, 13);
            graf.AddEdge(1, 3, 5);
            graf.AddEdge(2, 4, 3);
            graf.AddEdge(3, 4, 1);
            graf.AddEdge(2, 5, 11);
            graf.AddEdge(3, 6, 13);
            graf.AddEdge(5, 6, 2);
            graf.AddEdge(5, 7, 32);
            graf.AddEdge(6, 8, 6);
            graf.AddEdge(7, 9, 5);
            graf.AddEdge(8, 9, 22);

            graf.BFS(8);
            graf.DFS(8);

        }
    }
}

