namespace _02.LinkedList
{
    internal class Program
    {
        /*<실습>

        1. 사용자의 입력으로 숫자를 입력 받아서(마이너스도 허용)
            - 음수는 앞에 추가하고, 양수는 뒤에 추가하여
            - 음수&양수를 반으로 나누는 연결리스트 구현
            - 입력 받을 때마다 처음부터 끝까지 출력 진행

        ////////////////////////////////////////////////////////////

        2. 요세푸스 순열 문제
        1번부터 N번까지 N명의 사람이 원을 이루면서 앉아있고, 양의 정수 K(≤ N)가 주어진다. 이제 순서대로 K번째 사람을 제거한다. 
        한 사람이 제거되면 남은 사람들로 이루어진 원을 따라 이 과정을 계속해 나간다. 이 과정은 N명의 사람이 모두 제거될 때까지 계속된다. 
        원에서 사람들이 제거되는 순서를 (N, K)-요세푸스 순열이라고 한다. 예를 들어 (7, 3)-요세푸스 순열은 <3, 6, 2, 7, 5, 1, 4>이다.

        N과 K가 주어지면 (N, K)-요세푸스 순열을 구하는 프로그램을 작성하시오.

        */

        static void Main(string[] args)
        {
            // 1.
            LinkedList<int> list = new LinkedList<int>();
            while (true)
            {
                Console.Write("\n숫자를 입력하세요 (종료=0) :");
                int input = int.Parse(Console.ReadLine());
                Console.WriteLine($"{input}을 입력하셨습니다.");
                if (input == 0)
                {
                    Console.WriteLine("종료합니다.");
                    break;
                }

                if (input > 0) // 양수
                {
                    list.AddLast(input);
                }
                else // 음수
                {
                    list.AddFirst(input);
                }

                // 리스트 출력
                Console.Write("리스트 : ");
                for (var listNode = list.First; listNode != null; listNode = listNode.Next)
                {
                    Console.Write($"[ {listNode.Value} ]");
                }
                Console.WriteLine();
            }

            // 2. 
            // (7, 3)
            Console.Write("요세푸스(N = 7, K = 3) : "); // 답: <3, 6, 2, 7, 5, 1, 4>
            foreach (int i in Josephus.JosephusProblem(7, 3))
            {
                Console.Write($"[ {i} ]");
            }
            Console.WriteLine();

            // (5, 2)
            Console.Write("요세푸스(N = 5, K = 2) : "); // 답: <2, 4, 1, 5, 3>
            foreach (int i in Josephus.JosephusProblem(5, 2))
            {
                Console.Write($"[ {i} ]");
            }
            Console.WriteLine();

            // (8, 4)
            Console.Write("요세푸스(N = 8, K = 4) : "); // 답: <4, 8, 5, 2, 1, 3, 7, 6>
            foreach (int i in Josephus.JosephusProblem(8, 4))
            {
                Console.Write($"[ {i} ]");
            }
            Console.WriteLine();
        }
    }
}
