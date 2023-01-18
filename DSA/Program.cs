// See https://aka.ms/new-console-template for more information
using dfs = Datastructures.Graphs.DFS;
using bfs = Datastructures.Graphs.BFS;

Console.WriteLine("Hello, World!");

// var graph = new dfs.Graph(4);
var graph = new bfs.Graph(4);

graph.AddEdge(0, 1);
graph.AddEdge(0, 2);
graph.AddEdge(1, 2);
graph.AddEdge(2, 0);
graph.AddEdge(2, 3);
graph.AddEdge(3, 3);

Console.WriteLine("Depth First Traversal (starting from vertex 2)");

// Function call
var dfs = graph.Bfs(2);

foreach (var item in dfs) Console.Write(item + " -> ");