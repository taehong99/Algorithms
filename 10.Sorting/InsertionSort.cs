using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Sorting
{
    internal class InsertionSort
    {
        public static void Sort(IList<int> list)
        {
            for (int i = 1; i < list.Count; i++)
            {
                for(int j = i; j > 0; j--)
                {
                    if (list[j - 1] > list[j])
                    {
                        Swap(list, j, j - 1);
                    }
                }
            }
        }
        private static void Swap(IList<int> list, int left, int right)
        {
            int temp = list[left];
            list[left] = list[right];
            list[right] = temp;
        }
    }
}
