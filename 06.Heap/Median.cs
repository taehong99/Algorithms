using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Heap
{
    /* 백준 2696번 : https://www.acmicpc.net/problem/2696

        3
        9
        1 2 3 4 5 6 7 8 9
        9
        9 8 7 6 5 4 3 2 1
        23
        23 41 13 22 -3 24 -31 -11 -8 -7
        3 5 103 211 -311 -45 -67 -73 -81 -99
        -33 24 56

    */
    internal class Median
    {
        static void Main()
        {
            int P = int.Parse(Console.ReadLine());
            for (int i = 0; i < P; i++)
            {
                double M = int.Parse(Console.ReadLine());
                List<int> medians = new List<int>();
                PriorityQueue<int, int> asc = new PriorityQueue<int, int>();
                for (int j = 0; j < Math.Ceiling(M / 10); j++)
                {
                    string[] line = Console.ReadLine().Split();
                    foreach (string s in line)
                    {
                        int n = int.Parse(s);
                        asc.Enqueue(n, n);
                        if (asc.Count % 2 == 1)
                        {
                            PriorityQueue<int, int> desc = new PriorityQueue<int, int>();
                            while (desc.Count < asc.Count)
                            {
                                int k = asc.Dequeue();
                                desc.Enqueue(k, -k);
                            }
                            medians.Add(desc.Peek());
                            while (desc.Count > 0)
                            {
                                int k = desc.Dequeue();
                                asc.Enqueue(k, k);
                            }
                        }
                    }
                }
                Console.WriteLine(medians.Count);
                foreach (int m in medians)
                {
                    Console.Write($"{m} ");
                }
                Console.WriteLine();
            }
        }
    }
}
