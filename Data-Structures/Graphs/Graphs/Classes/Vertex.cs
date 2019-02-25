using System;
using System.Collections.Generic;
using System.Text;

namespace Graphs.Classes
{
    public class Vertex
    {
        public object Value { get; set; }
        public bool isVisited;
        public int Neighbors { get; set; }

    }

}
