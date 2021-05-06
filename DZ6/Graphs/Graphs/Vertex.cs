using System;
using System.Collections.Generic;
using System.Text;

namespace Graphs
{
    class Vertex
    {
        public int Number { get; set; }
        public List<Edge> Edges{ get; set; }
        public bool Visited { get; set; }
        
        public Vertex(int value)
        {
            Number = value;
            Edges = new List<Edge>();
        }
        public void AddEdge(Edge newEdge)
        {
            Edges.Add(newEdge);
        }
        public void AddEdge(Vertex vertex ,int weignt)
        {
            AddEdge(new Edge(vertex, weignt));
        }
       



    }

}
