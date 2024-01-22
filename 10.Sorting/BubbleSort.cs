using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Sorting
{
    internal class BubbleSort
    {
        public static void Sort(IList<int> list)
        {
            for (int i = 1; i < list.Count; i++)
            {
                for(int j = 0; j < list.Count - i; j++)
                {
                    if (list[j] > list[j + 1])
                    {
                        Swap(list, j, j + 1);
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
