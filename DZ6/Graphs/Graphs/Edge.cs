using System;
using System.Collections.Generic;
using System.Text;

namespace Graphs
{
    class Edge
    {
        public int Weight { get; set; }
        public Vertex Vertex { get; set; }

        public Edge(Vertex vertex , int weight)
        {
            Vertex = vertex;

            Weight = weight;
        }
    }
}
