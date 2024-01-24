namespace _12.ShortestPath
{
    internal class Program
    {
        const int INF = int.MaxValue;
        static void Main(string[] args)
        {
            int[,] graph = new int[18, 18]
            {   //  0    1    2    3    4    5    6    7    8    9   10   11   12   13   14   15   16   17     
                {   0,   6,   6, INF, INF, INF, INF,   7, INF, INF, INF, INF, INF, INF, INF, INF, INF, INF },  //0
                {   6,   0, INF, INF, INF,   9, INF, INF, INF, INF, INF, INF, INF, INF, INF, INF, INF, INF },  //1
                {   6, INF,   0,   7, INF, INF,   8, INF, INF, INF, INF, INF, INF, INF, INF, INF, INF, INF },  //2
                { INF, INF,   7,   0, INF, INF,   8, INF, INF, INF, INF, INF, INF, INF, INF, INF, INF,   3 },  //3
                { INF, INF, INF, INF,   0,   2, INF,   7,   8, INF, INF, INF, INF, INF, INF, INF, INF, INF },  //4
                { INF,   9, INF, INF,   2,   0,   1, INF, INF,   2, INF, INF, INF, INF, INF, INF, INF, INF },  //5
                { INF, INF,   8,   8, INF,   1,   0, INF, INF,   2,   8, INF, INF, INF, INF, INF, INF, INF },  //6
                {   7, INF, INF, INF,   7, INF, INF,   0,   4, INF, INF,   5, INF, INF,   5, INF, INF, INF },  //7
                { INF, INF, INF, INF,   8, INF, INF,   4,   0,   3, INF, INF,   4, INF, INF, INF, INF, INF },  //8
                { INF, INF, INF, INF, INF,   2,   2, INF,   3,   0,   5, INF,   1, INF, INF, INF, INF, INF },  //9
                { INF, INF, INF, INF, INF, INF,   8, INF, INF,   5,   0, INF, INF, INF, INF, INF, INF,   7 },  //10
                { INF, INF, INF, INF, INF, INF, INF,   5, INF, INF, INF,   0, INF, INF,   3, INF, INF, INF },  //11
                { INF, INF, INF, INF, INF, INF, INF, INF,   4,   1, INF, INF,   0, INF, INF,   4,   7, INF },  //12
                { INF, INF, INF, INF, INF, INF, INF, INF, INF, INF, INF, INF, INF,   0, INF, INF,   1, INF },  //13
                { INF, INF, INF, INF, INF, INF, INF,   5, INF, INF, INF,   3, INF, INF,   0,   2, INF, INF },  //14
                { INF, INF, INF, INF, INF, INF, INF, INF, INF, INF, INF, INF,   4, INF,   2,   0,   3,   6 },  //15
                { INF, INF, INF, INF, INF, INF, INF, INF, INF, INF, INF, INF,   7,   1, INF,   3,   0, INF },  //16
                { INF, INF, INF,   3, INF, INF, INF, INF, INF, INF,   7, INF, INF, INF, INF,   6, INF,   0 }   //17
            };

            Dijkstra.ShortestPath(0, in graph, out bool[] visited, out int[] distance, out int[] parent);
            PrintDijkstra(visited, distance, parent);
        }

        private static void PrintDijkstra(bool[] visited, int[] distance, int[] parent)
        {
            Console.Write("vertex");
            Console.Write("\t");
            Console.Write("visited");
            Console.Write("\t");
            Console.Write(" distance");
            Console.WriteLine(" parent");

            for (int i = 0; i < distance.Length; i++)
            {
                Console.Write("{0,3}", i);
                Console.Write("\t");
                Console.Write(visited[i]);
                Console.Write("\t");
                if (distance[i] >= INF)
                    Console.Write("INF");
                else
                    Console.Write("{0,3}", distance[i]);
                Console.Write("\t");
                if (parent[i] < 0)
                    Console.WriteLine("  X ");
                else
                    Console.WriteLine("{0,3}", parent[i]);
            }
        }
    }
}
