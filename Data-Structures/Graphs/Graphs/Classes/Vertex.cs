using System;
using System.Collections.Generic;
using System.Text;

namespace Graphs.Classes
{
    public class Vertex
    {
        public int Value { get; set; }
        public bool isVisited;
        public List<Vertex> Neighbors { get; set; }
    }
}
