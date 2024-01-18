using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Heap
{
    internal class Meetings
    {
        /* 백준 19598번 : https://www.acmicpc.net/problem/19598

        3
        0 40
        15 30
        5 10

        */
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            PriorityQueue<int[], int> schedule = new PriorityQueue<int[], int>();

            for (int i = 0; i < N; i++)
            {
                string[] input = Console.ReadLine().Split();
                int s = int.Parse(input[0]);
                int e = int.Parse(input[1]);
                schedule.Enqueue(new int[] { s, e }, s);
            }

            PriorityQueue<int[], int> ongoing = new PriorityQueue<int[], int>();

            while (schedule.Count > 0)
            {
                int[] cur = schedule.Dequeue();

                if (ongoing.Count == 0 || ongoing.Peek()[1] > cur[0])
                {
                    ongoing.Enqueue(cur, cur[1]);
                }
                else
                {
                    int[] original = ongoing.Dequeue();
                    ongoing.Enqueue(new int[] { original[0], cur[1] }, cur[1]);
                }
            }
            int rooms = ongoing.Count;
            Console.WriteLine(rooms);
        }
    }
}
