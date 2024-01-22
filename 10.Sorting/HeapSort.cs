using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Sorting
{
    internal class HeapSort
    {
        public static void Sort(IList<int> list)
        {
            PriorityQueue<int, int> pq = new PriorityQueue<int, int>();
            foreach(int i in list)
            {
                pq.Enqueue(i, i);
            }
            for(int i = 0; i < list.Count; i++)
            {
                list[i] = pq.Dequeue();
            }
        }
    }
}
