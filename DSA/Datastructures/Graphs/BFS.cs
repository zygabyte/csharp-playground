namespace Datastructures.Graphs;
public class BFS
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

        public List<int> Bfs(int v)
        {
            var queue = new Queue<int>();
            var bfs = new List<int>();
            var visited = new bool[vertices];

            queue.Enqueue(v);

            while (queue.Any())
            {
                var item = queue.Dequeue();
                bfs.Add(item);
                visited[item] = true;

                var adjList = graph[item];

                foreach (var i in adjList)
                {
                    if (!visited[i])
                        queue.Enqueue(i);
                }
            }

            return bfs;
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

            Console.WriteLine("Following is Breadth First Traversal (starting from vertex 2)");

            // Function call
            var dfs = graph.Bfs(2);

            foreach (var item in dfs) Console.Write(item + " -> ");

            Console.ReadKey();
        }
    }
}
