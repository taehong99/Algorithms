using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Searching
{
    internal class BFS
    {
        public static void FindPath(in bool[,] graph, out int[] path)
        {
            path = new int[graph.GetLength(0)];
            bool[] visited = new bool[graph.GetLength(0)];
            visited[0] = true;
            
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(0);
            int curIndex = 0;
            while (queue.Count > 0)
            {
                int cur = queue.Dequeue();
                path[curIndex++] = cur;

                for (int i = 0; i < graph.GetLength(1); i++)
                {
                    if (graph[cur, i] == true && visited[i] == false)
                    {
                        queue.Enqueue(i);
                        visited[i] = true;
                    }
                }
            }
        }
    }
}
