using System;
using System.Collections.Generic;
using System.Text;

namespace Graphs.Classes
{
    class Graph
    {
        public Vertex Vertex { get; set; }
        public Edge Edge { get; set; }
        public int Size;

        public Graph(Vertex vertex, Edge edge, int size)
        {
            edge = Edge;
            vertex = Vertex;
            size = Size;
        }

        public Vertex AddVertext()
        {
            //return the added node
            return Vertex;
        }

        public Edge AddEdge(Vertex nodeOne, Vertex nodeTwo, int weight)
        {
            //take in two nodes and adds an edge between them
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

        public int Size(Graph graph)
        {
            //returns total nodes in graph
        }
    }
}
