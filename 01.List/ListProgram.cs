namespace _01.List
{
    internal class ListProgram
    {
        public class SpecialList
        {
            List<int> list;

            public SpecialList(int n)
            {
                list = new List<int>();
                for(int i = 0; i <= n; i++)
                {
                    list.Add(i);
                }
                list.Remove(0);
            }

            public void AddOrDelete(int n)
            {
                if (list.Contains(n))
                {
                    list.Remove(n);
                }
                else 
                { 
                    list.Add(n);
                }
            }

            public void PrintList()
            {
                Console.Write("나의 리스트: ");
                foreach(int i in list)
                {
                    Console.Write($"[{i}]");
                }
                Console.WriteLine();
            }
        }
    }
}
