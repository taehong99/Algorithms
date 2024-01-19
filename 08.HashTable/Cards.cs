using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.HashTable
{
    internal class Cards
    {
        /* 백준 5568 : https://www.acmicpc.net/problem/5568

        입력: 
        4         
        2
        1
        2
        12
        1

        출력:
        7

        입력: 
        6
        3
        72
        2
        12
        7
        2
        1

        출력: 
        68

        */

        static void Main1()
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            List<string> starting_cards = new List<string>();
            for (int i = 0; i < n; i++)
            {
                starting_cards.Add(Console.ReadLine());
            }

            HashSet<string> set = new HashSet<string>();
            dfs("", 0, k, starting_cards.ToArray(), new bool[n], set);

            Console.WriteLine(set.Count);
        }

        public static void dfs(string cur, int len, int k, string[] nums, bool[] visited, HashSet<string> set)
        {
            if (len == k)
            {
                set.Add(cur);
            }
            for (int i = 0; i < nums.Length; i++)
            {
                if (!visited[i])
                {
                    bool[] newVisited = new bool[visited.Length];
                    Array.Copy(visited, newVisited, visited.Length);
                    newVisited[i] = true;
                    dfs(cur + nums[i], len + 1, k, nums, newVisited, set);
                }
            }
        }
    }
}
