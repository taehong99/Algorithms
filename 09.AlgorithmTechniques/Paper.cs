using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.AlgorithmTechniques
{
    internal class Paper
    {
        /* 백준 2630 : https://www.acmicpc.net/problem/2630

        입력: 
        8
        1 1 0 0 0 0 1 1
        1 1 0 0 0 0 1 1
        0 0 0 0 1 1 0 0
        0 0 0 0 1 1 0 0
        1 0 0 0 1 1 1 1
        0 1 0 0 1 1 1 1
        0 0 1 1 1 1 1 1
        0 0 1 1 1 1 1 1

        출력:
        9
        7

        */

        static void Main1()
        {
            int N = int.Parse(Console.ReadLine());

            int[,] paper = new int[N, N];
            for (int r = 0; r < N; r++)
            {
                string[] line = Console.ReadLine().Split();
                for (int c = 0; c < N; c++)
                {
                    paper[r, c] = int.Parse(line[c]);
                }
            }

            int blues = 0;
            int whites = 0;
            dfs(paper, ref blues, ref whites);
            Console.WriteLine(whites);
            Console.WriteLine(blues);
        }

        static int IsFilled(int[,] paper)
        {
            if (paper.Length == 0)
            {
                return -1;
            }
            int color = paper[0, 0];
            for (int r = 0; r < paper.GetLength(0); r++)
            {
                for (int c = 0; c < paper.GetLength(1); c++)
                {
                    if (paper[r, c] != color)
                    {
                        return -1;
                    }
                }
            }
            return color;
        }
        static int[,] GetSubArray(int[,] original, int startRow, int startCol, int subRows, int subCols)
        {
            int[,] subArray = new int[subRows, subCols];

            for (int i = 0; i < subRows; i++)
            {
                for (int j = 0; j < subCols; j++)
                {
                    subArray[i, j] = original[startRow + i, startCol + j];
                }
            }

            return subArray;
        }

        static void dfs(int[,] paper, ref int blues, ref int whites)
        {
            if (IsFilled(paper) == 1)
            {
                blues++;
                return;
            }
            else if (IsFilled(paper) == 0)
            {
                whites++;
                return;
            }

            int subRows = paper.GetLength(0) / 2;
            int subCols = paper.GetLength(1) / 2;
            int[,] subArray1 = GetSubArray(paper, 0, 0, subRows, subCols);
            int[,] subArray2 = GetSubArray(paper, 0, subCols, subRows, subCols);
            int[,] subArray3 = GetSubArray(paper, subRows, 0, subRows, subCols);
            int[,] subArray4 = GetSubArray(paper, subRows, subCols, subRows, subCols);
            dfs(subArray1, ref blues, ref whites);
            dfs(subArray2, ref blues, ref whites);
            dfs(subArray3, ref blues, ref whites);
            dfs(subArray4, ref blues, ref whites);
        }
    }
}
