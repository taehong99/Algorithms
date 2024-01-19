using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.AlgorithmTechniques
{
    internal class Pyramid
    {
        /* 백준 1932 : https://www.acmicpc.net/problem/1932

        입력: 
        5
        7
        3 8
        8 1 0
        2 7 4 4
        4 5 2 6 5

        출력:
        30

        */

        static void Main1()
        {
            int N = int.Parse(Console.ReadLine());

            Stack<List<int>> pyramid = new Stack<List<int>>();
            for (int i = 0; i < N; i++)
            {
                string[] line = Console.ReadLine().Split();
                List<int> lineList = new List<int>();
                foreach (string s in line)
                {
                    lineList.Add(int.Parse(s));
                }
                pyramid.Push(lineList);
            }

            while (pyramid.Count > 1)
            {
                List<int> maxes = new List<int>();
                List<int> curLine = pyramid.Pop();
                for (int i = 0; i < curLine.Count - 1; i++)
                {
                    int max = Math.Max(curLine[i], curLine[i + 1]);
                    maxes.Add(max);
                }
                List<int> nextLine = pyramid.Pop();
                for (int i = 0; i < nextLine.Count; i++)
                {
                    nextLine[i] += maxes[i];
                }
                pyramid.Push(nextLine);
            }
            Console.WriteLine(pyramid.Peek()[0]);
        }
    }
}
