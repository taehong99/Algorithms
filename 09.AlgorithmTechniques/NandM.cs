using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.AlgorithmTechniques
{
    internal class NandM
    {
        /* 백준 15651 : https://www.acmicpc.net/problem/15651

        입력: 
        3 1

        출력:
        1
        2
        3

        입력: 
        4 2

        출력: 
        1 1
        1 2
        1 3
        1 4
        2 1
        2 2
        2 3
        2 4
        3 1
        3 2
        3 3
        3 4
        4 1
        4 2
        4 3
        4 4

        */

        static void Main1()
        {
            string[] args = Console.ReadLine().Split();
            int N = int.Parse(args[0]);
            int M = int.Parse(args[1]);

            StringBuilder sb = new StringBuilder();
            for (int i = 1; i <= N; i++)
            {
                sb.Append(i);
            }
            string nums = sb.ToString();
            sb.Clear();
            dfs("", 0, nums, M, sb);
            Console.WriteLine(sb.ToString());
        }

        static void dfs(string cur, int count, string nums, int len, StringBuilder sb)
        {
            if (count == len)
            {
                sb.Append(cur);
                sb.Append("\n");
                return;
            }
            foreach (char n in nums)
            {
                StringBuilder temp = new StringBuilder(cur);
                temp.Append(n);
                temp.Append(" ");
                dfs(temp.ToString(), count + 1, nums, len, sb);
            }
        }
    }
}
