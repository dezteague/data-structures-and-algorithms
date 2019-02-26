using System;
using System.Collections.Generic;
using System.Text;

namespace Graphs.Classes
{
    public class Edge
    {
        public Vertex StartVertex { get; set; }
        public Vertex EndVertext { get; set; }
        public int Weight { get; set; }

        public Edge(Vertex startVertex, Vertex endVertex, int weight)
        {

        }
    }
}
