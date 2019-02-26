using System;
using System.Collections.Generic;
using System.Text;

namespace Graphs.Classes
{
    class Graph
    {
        public Dictionary <Vertex, List<Vertex>> AdjacencyList {get; set;}
        public Vertex Vertex { get; set; }
        public List<Edge> Edges { get; set; }
   

        //public Graph(Vertex vertex, Edge edge, int size)
        //{
        //    edge = Edge;
        //    vertex = Vertex;
        //    size = Size;
        //}

        public Vertex AddVertex(Vertex vertex)
        {
            AdjacencyList.Add(vertex, new List<Vertex>());
            //return the added node
            return Vertex;
        }

        //take in two nodes and adds an edge between them
        public Vertex AddEdge(Vertex startVertex, Vertex endVertex, int weight)
        {
            //create the edge
            Edges.Add(new Edge(startVertex, endVertex, weight));
            //join nodes together
            AdjacencyList[startVertex].Add(endVertex);
            //return the start node
            return startVertex;
        }

        public Vertex GetNodes()
        {
            //returns all nodes in the graph
            return List;
        }

        public Vertex GetNeighbors(Vertex node)
        {
            //returns a collection of nodes related to a given node
            return List;
        }

        public int Size()
        {
            //returns total nodes in graph
            return AdjacencyList.Count;
        }
    }
}
