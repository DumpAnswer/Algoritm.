using System;
using System.Collections.Generic;
using System.Text;

namespace Graphs
{
   
    class Graf
    {
        public List<Vertex> Vertexes { get; set; }

        public Graf()
        {
            Vertexes = new List<Vertex>();
        }
        public Graf(IEnumerable<int> collection)
        {
            Vertexes = new List<Vertex>();
            AddVertexRange(collection);
        }
        public void AddVertex(int vertexValue)
        {
            Vertexes.Add(new Vertex(vertexValue));
        }
        public void AddVertexRange(IEnumerable<int> collection)
        {
            foreach (var value in collection)
            {
                AddVertex(value);
            }
        }
        public Vertex GetVertexByValue(int vertexValue)
        {
            foreach (var vertex in Vertexes)
            {
                if(vertex.Number == vertexValue)
                {
                    return vertex;
                }
            }
            return null;
           
        }
        public void AddEdge (int firstVertexValue, int secondVertexValue, int weight)
        {
            var firstVertex = GetVertexByValue(firstVertexValue);
            var secondVertex = GetVertexByValue(secondVertexValue);
            if (firstVertex != null && secondVertex != null)
            {
                firstVertex.AddEdge(secondVertex, weight);

            }
        }
        public void BFS(int value)
        {
            
            Queue<Vertex> queue = new Queue<Vertex>();

            foreach (var vertex in Vertexes)
            {
                vertex.Visited = false;
            }

            Vertex startVertex = GetVertexByValue(value);
            startVertex.Visited = true;
            queue.Enqueue(startVertex);
            while(queue.Count != 0)
            {
                
                Vertex vertex = queue.Dequeue();
                for(int i = 0; i < vertex.Edges.Count; i++)
                {
                    Vertex tmp = vertex.Edges[i].Vertex;
                    if (!tmp.Visited)
                    {
                        
                        queue.Enqueue(tmp);
                        tmp.Visited = true;
                    }
                }
            }
            
        }
        public void DFS(int value)
        {
            Stack<Vertex> stack = new Stack<Vertex>();

            foreach (var vertex in Vertexes)
            {
                vertex.Visited = false;
            }

            Vertex startVertex = GetVertexByValue(value);
            startVertex.Visited = true;
            stack.Push(startVertex);
            while (stack.Count != 0)
            {
                
                Vertex vertex = stack.Pop();
                for (int i = 0; i < vertex.Edges.Count; i++)
                {
                    Vertex tmp = vertex.Edges[i].Vertex;
                    if (!tmp.Visited)
                    {
                        
                        stack.Push(tmp);
                        tmp.Visited = true;
                    }
                }
            }
        }
       
    }
}
