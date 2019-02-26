using System;
using System.Collections.Generic;
using System.Text;

namespace Graphs.Classes
{
    public class VertexGraph
    {
        public Dictionary <Vertex, List<Vertex>> AdjacencyList {get; set;}
        public Vertex Vertex { get; set; }
        public List<Edge> Edges { get; set; }


        public VertexGraph()
        {
            AdjacencyList = new Dictionary<Vertex, List<Vertex>>();
            Edges = new List<Edge>();
        }

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

        public object GetNodes()
        {
            //returns all nodes in the graph.  Adjacency list is similar to hashmap, it can return keys
            return AdjacencyList.Keys;
        }

        public object GetNeighbors(Vertex vertex)
        {
            //returns a collection of nodes related to a given node
            return AdjacencyList[vertex];
        }

        public int Size()
        {
            //returns total nodes in graph
            return AdjacencyList.Count;
        }
    }
}
