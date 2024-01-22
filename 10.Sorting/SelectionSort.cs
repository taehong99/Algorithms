using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Sorting
{
    internal class SelectionSort
    {
        public static void Sort(IList<int> list)
        {
            for(int i = 0; i < list.Count; i++)
            {
                int lowestIndex = i;
                for (int j = i + 1; j < list.Count; j++)
                {
                    if (list[j] < list[lowestIndex])
                    {
                        lowestIndex = j;
                    }
                }
                Swap(list, i, lowestIndex);
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
