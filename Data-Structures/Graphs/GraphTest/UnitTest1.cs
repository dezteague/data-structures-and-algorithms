using Graphs.Classes;
using System;
using System.Collections.Generic;
using Xunit;

namespace GraphTest
{
    public class UnitTest1
    {
        [Fact]
        public void CanAddNodeTest()
        {
            VertexGraph graph = new VertexGraph();
            graph.AddVertex(new Vertex());
            Assert.Equal(1, graph.Size());
        }

        [Fact]
        public void CanAddEdgeTest()
        {

        }

        [Fact]
        public void CanGetAllNodesTest()
        {

        }

        [Fact]
        public void CanGetAllNeighborsTest()
        {

        }

        [Fact]
        public void NeighborsReturnWeightTest()
        {

        }

        [Fact]
        public void CanGetSizeTest()
        {

        }

        [Fact]
        public void CanReturnGraphWithOneNodeandEdgeTest()
        {

        }

        [Fact]
        public void EmptyGraphReturnsNullTest()
        {

        }
    }
}
