using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.AlgorithmTechniques
{
    /* 백준 11399 : https://www.acmicpc.net/problem/11399

        입력: 
        5
        3 1 4 3 2

        출력:
        32

    */
    internal class ATM
    {
        static void Main1()
        {
            int N = int.Parse(Console.ReadLine());
            string[] s = Console.ReadLine().Split();
            List<int> nums = new List<int>();
            foreach (string str in s)
            {
                nums.Add(int.Parse(str));
            }

            nums.Sort();
            int timePassed = 0;
            List<int> waitTimes = new List<int>();
            foreach (int n in nums)
            {
                int waited = timePassed;
                waited += n;
                timePassed = waited;
                waitTimes.Add(timePassed);
            }
            int total = 0;
            foreach (int n in waitTimes)
            {
                total += n;
            }
            Console.WriteLine(total);
        }
    }
}
