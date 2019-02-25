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
    }
}
