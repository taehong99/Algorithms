using System.Collections.Generic;

namespace _10.Sorting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            List<int> selectionList = new List<int>();
            List<int> insertionList = new List<int>();
            List<int> bubbleList = new List<int>();
            List<int> mergeList = new List<int>();
            List<int> quickList = new List<int>();
            List<int> heapList = new List<int>();
            List<int> list = new List<int>();

            Console.WriteLine("랜덤 데이터 : ");
            for (int i = 0; i < 20; i++)
            {
                int rand = random.Next() % 100;
                Console.Write(string.Format("{0} ", rand));

                selectionList.Add(rand);
                insertionList.Add(rand);
                bubbleList.Add(rand);
                heapList.Add(rand);
                mergeList.Add(rand);
                quickList.Add(rand);
                list.Add(rand);
            }
            Console.WriteLine();

            Console.WriteLine("선택 정렬 : ");
            SelectionSort.Sort(selectionList);
            PrintList(selectionList);

            Console.WriteLine("삽입 정렬 : ");
            InsertionSort.Sort(insertionList);
            PrintList(insertionList);

            Console.WriteLine("버블 정렬 : ");
            BubbleSort.Sort(bubbleList);
            PrintList(bubbleList);

            Console.WriteLine("병합 정렬 : ");
            MergeSort.Sort(mergeList, 0, mergeList.Count - 1);
            PrintList(mergeList);

            Console.WriteLine("퀵 정렬 : ");
            QuickSort.Sort(quickList, 0, quickList.Count - 1);
            PrintList(quickList);

            Console.WriteLine("힙 정렬 : ");
            HeapSort.Sort(heapList);
            PrintList(heapList);
        }

        public static void PrintList(List<int> list)
        {
            foreach (int i in list)
            {
                Console.Write(string.Format("{0} ", i));
            }
            Console.WriteLine();
        }
    }
}
