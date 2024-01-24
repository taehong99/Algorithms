using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.ShortestPath
{
    internal class Dijkstra
    {
        const int INF = int.MaxValue;
        public static void ShortestPath(int start, in int[,] graph, out bool[] visited, out int[] distance, out int[] parent)
        {
            int size = graph.GetLength(0);
            visited = new bool[size];
            distance = new int[size];
            parent = new int[size];
            for(int i = 0; i < size; i++)
            {
                visited[i] = false;
                distance[i] = INF;
                parent[i] = -1;
            }
            distance[start] = 0;

            while (true)
            {
                // 방문하지 않은 노드 중에서 가장 비용이 적은 노드를 선택한다.
                int minDist = INF;
                int curNode = -1;
                for (int i = 0; i < size; i++)
                {
                    if (!visited[i] && (distance[i] < minDist))
                    {
                        minDist = distance[i];
                        curNode = i;
                    }
                }

                if(curNode == -1)
                {
                    break;
                }

                // 해당 노드를 거쳐서 특정한 노드로 가는 경우를 고려하여 최소 비용을 갱신한다.
                for (int i = 0; i < size; i++)
                {
                    if (graph[curNode, i] != INF)
                    {
                        if (graph[curNode, i] + minDist < distance[i])
                        {
                            distance[i] = graph[curNode, i] + minDist;
                            parent[i] = curNode;
                        }
                    }
                }

                visited[curNode] = true;
            }
        }
    }
}
