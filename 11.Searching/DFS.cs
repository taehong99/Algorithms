using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Searching
{
    internal class DFS
    {
        public static void FindPath(in bool[,] graph, out int[] path)
        {
            List<int> list = new List<int>();
            dfs(0, graph, list, new bool[graph.GetLength(0)]);
            path = list.ToArray();
        }

        private static void dfs(int cur, bool[,] graph, List<int> path, bool[] visited)
        {
            if (visited[cur])
            {
                return;
            }
            path.Add(cur);
            visited[cur] = true;

            for(int i = 0; i < graph.GetLength(0); i++)
            {
                if (graph[cur, i] == true)
                {
                    dfs(i, graph, path, visited);
                }
            }
        }
    }
}
