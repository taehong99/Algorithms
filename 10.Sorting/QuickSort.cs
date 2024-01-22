using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Sorting
{
    internal class QuickSort
    {
        public static void Sort(IList<int> list, int left, int right)
        {
            if(left >= right)
            {
                return;
            }
            int pivot = left;
            int l = left;
            int r = right;
            l++;
            while (l <= r)
            {
                while (l <=r && list[l] <= list[pivot])
                {
                    l++;
                }
                while (l <= r && list[r] > list[pivot])
                {
                    r--;
                }
                if(l <= r)
                {
                    Swap(list, l, r);
                }
            }
            Swap(list, pivot, r);
            Sort(list, left, r - 1);
            Sort(list, l, right);
        }
        private static void Swap(IList<int> list, int left, int right)
        {
            int temp = list[left];
            list[left] = list[right];
            list[right] = temp;
        }
    }
}
