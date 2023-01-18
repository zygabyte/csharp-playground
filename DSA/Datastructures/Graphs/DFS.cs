namespace Datastructures.Graphs;
public class DFS
{
    public class Graph
    {
        private readonly int vertices;
        private readonly List<int>[] graph;

        public Graph(int vertices)
        {
            this.vertices = vertices;
            graph = new List<int>[vertices];

            for (int i = 0; i < vertices; i++)
                graph[i] = new List<int>();
        }

        public void AddEdge(int v, int w) => graph[v].Add(w);

        public List<int> Dfs(int v)
        {
            var dfs = new List<int>();
            var visited = new bool[vertices];

            DfsUtil(v, dfs, visited);

            return dfs;
        }

        private void DfsUtil(int v, List<int> dfs, bool[] visited)
        {
            visited[v] = true;
            dfs.Add(v);

            var adjList = graph[v];

            foreach (var item in adjList)
                if (!visited[item]) DfsUtil(item, dfs, visited);
        }

        public static void Main(string[] args)
        {
            var graph = new Graph(4);

            graph.AddEdge(0, 1);
            graph.AddEdge(0, 2);
            graph.AddEdge(1, 2);
            graph.AddEdge(2, 0);
            graph.AddEdge(2, 3);
            graph.AddEdge(3, 3);

            Console.WriteLine("Following is Depth First Traversal (starting from vertex 2)");

            // Function call
            var dfs = graph.Dfs(2);

            foreach (var item in dfs) Console.Write(item + " -> ");

            Console.ReadKey();
        }
    }
}
