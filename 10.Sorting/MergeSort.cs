using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Sorting
{
    internal class MergeSort
    {
        public static void Sort(IList<int> list, int left, int right)
        {
            if(left == right)
            {
                return;
            }
            int mid = (left + right) / 2;
            Sort(list, left, mid);
            Sort(list, mid + 1, right);
            Merge(list, left, mid, right);
        }
        private static void Merge(IList<int> list, int left, int mid, int right)
        {
            int l = left;
            int r = mid + 1;
            List<int> merged = new List<int>();
            while(l <= mid && r <= right)
            {
                if (list[l] < list[r])
                {
                    merged.Add(list[l++]);
                }
                else
                {
                    merged.Add(list[r++]);
                }
            }
            while(l <= mid)
            {
                merged.Add(list[l++]);
            }
            while(r <= right)
            {
                merged.Add(list[r++]);
            }
            for(int i = 0; i < merged.Count; i++)
            {
                list[left + i] = merged[i];
            }
        }
    }
}
