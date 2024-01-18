using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Heap
{
    internal class Tasks
    {
        /* 백준 13904번: https://www.acmicpc.net/problem/13904
         * input: 
            7
            4 60
            4 40
            1 20
            2 50
            3 30
            4 10
            6 5
        */
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            Dictionary<int, PriorityQueue<int[], int>> hash = new Dictionary<int, PriorityQueue<int[], int>>();
            int max = 0;
            for (int i = 0; i < N; i++)
            {
                string[] input = Console.ReadLine().Split();
                int d = int.Parse(input[0]);
                int w = int.Parse(input[1]);
                max = Math.Max(max, d);
                if (hash.ContainsKey(d))
                {
                    hash[d].Enqueue(new int[] { d, w }, -w);
                }
                else
                {
                    var pq = new PriorityQueue<int[], int>();
                    hash.Add(d, pq);
                    hash[d].Enqueue(new int[] { d, w }, -w);
                }
            }

            int total = 0;
            int daysLeft = max;
            while (daysLeft > 0)
            {
                PriorityQueue<int[], int> possibles = new PriorityQueue<int[], int>();
                for (int i = daysLeft; i <= max; i++)
                {
                    if (hash.ContainsKey(i))
                    {
                        int[] highest = hash[i].Peek();
                        possibles.Enqueue(highest, -highest[1]);
                    }
                }
                if (possibles.Count == 0)
                {
                    daysLeft--;
                    continue;
                }
                int[] candidate = possibles.Peek();
                total += candidate[1];
                hash[candidate[0]].Dequeue();
                if (hash[candidate[0]].Count == 0)
                {
                    hash.Remove(candidate[0]);
                }
                daysLeft--;
            }
            Console.WriteLine(total);
        }
    }
}
