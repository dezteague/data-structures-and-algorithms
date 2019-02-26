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
            VertexGraph graph = new VertexGraph();
            Vertex startVertex = new Vertex();
            Vertex endVertex = new Vertex();
            graph.AddVertex(startVertex);
            graph.AddVertex(endVertex);
            int weight = 5;
            graph.AddEdge(startVertex, endVertex, weight);
            Assert.Equal(startVertex, graph.AddEdge(startVertex,endVertex,weight));
        }

        [Fact]
        public void CanGetAllNodesTest()
        {
            VertexGraph graph = new VertexGraph();
            graph.AddVertex(new Vertex());
            graph.AddVertex(new Vertex());
            Assert.Equal(2, graph.Size());
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
