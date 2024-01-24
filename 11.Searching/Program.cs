namespace _11.Searching
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool[,] graph = new bool[8, 8]
            {
                { false, false, false,  true,  true, false, false, false },
                { false, false, false,  true, false,  true,  true, false },
                { false, false, false, false, false, false,  true, false },
                {  true,  true, false, false, false,  true, false,  true },
                {  true, false, false, false, false, false,  true, false },
                { false,  true, false,  true, false, false,  true,  true },
                { false,  true,  true, false,  true,  true, false,  true },
                { false, false, false,  true, false,  true, false,  true },
            };

            // BFS
            int[] bfsPath;
            BFS.FindPath(in graph, out bfsPath);
            Console.Write("BFS : ");
            foreach(int i in bfsPath)
            {
                Console.Write($"[{i}]");
            }
            Console.WriteLine();

            //DFS
            int[] dfsPath;
            DFS.FindPath(in graph, out dfsPath);
            Console.Write("DFS : ");
            foreach (int i in dfsPath)
            {
                Console.Write($"[{i}]");
            }
            Console.WriteLine();
        }
    }
}
