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
            Vertex vertexA = new Vertex();
            Vertex vertexB = new Vertex();
            Vertex vertexC = new Vertex();
            graph.AddVertex(vertexA);
            graph.AddVertex(vertexB);
            graph.AddVertex(vertexC);
            List<Vertex> list = new List<Vertex>() { vertexA, vertexB, vertexC };
            Assert.Equal(list, graph.GetNodes());
        }

        [Fact]
        public void CanGetAllNeighborsTest()
        {
            VertexGraph graph = new VertexGraph();
            Vertex vertexA = new Vertex();
            Vertex vertexB = new Vertex();
            graph.AddVertex(vertexA);
            graph.AddVertex(vertexB);
            int weight = 5;
            graph.AddEdge(vertexA, vertexB, weight);
            List<Vertex> neighbors = new List<Vertex>() { vertexA, vertexB };
            Assert.Equal(neighbors, graph.GetNeighbors(vertexA));
        }

        [Fact]
        public void NeighborsReturnWeightTest()
        {

        }

        [Fact]
        public void CanGetSizeTest()
        {
            VertexGraph graph = new VertexGraph();
            graph.AddVertex(new Vertex());
            graph.AddVertex(new Vertex());
            Assert.Equal(2, graph.Size());
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
