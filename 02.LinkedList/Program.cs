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

        A+. 1번부터 N번까지 N개의 풍선이 원형으로 놓여 있고. i번 풍선의 오른쪽에는 i+1번 풍선이 있고, 왼쪽에는 i-1번 풍선이 있다. 
        단, 1번 풍선의 왼쪽에 N번 풍선이 있고, N번 풍선의 오른쪽에 1번 풍선이 있다. 
        각 풍선 안에는 종이가 하나 들어있고, 종이에는 -N보다 크거나 같고, N보다 작거나 같은 정수가 하나 적혀있다. 
        이 풍선들을 다음과 같은 규칙으로 터뜨린다. 우선, 제일 처음에는 1번 풍선을 터뜨린다. 다음에는 풍선 안에 있는 종이를 꺼내어 그 종이에 적혀있는 값만큼 이동하여 다음 풍선을 터뜨린다. 
        양수가 적혀 있을 경우에는 오른쪽으로, 음수가 적혀 있을 때는 왼쪽으로 이동한다. 이동할 때에는 이미 터진 풍선은 빼고 이동한다.
        예를 들어 다섯 개의 풍선 안에 차례로 3, 2, 1, -3, -1이 적혀 있었다고 하자. 
        이 경우 3이 적혀 있는 1번 풍선, -3이 적혀 있는 4번 풍선, -1이 적혀 있는 5번 풍선, 1이 적혀 있는 3번 풍선, 2가 적혀 있는 2번 풍선의 순서대로 터지게 된다.


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

            // A+
            Console.Write("풍선터트리기([3, 2, 1, -3, -1] : "); // 답 : <1, 4, 5, 3, 2>
            foreach (int i in Balloons.PopBalloons([3, 2, 1, -3, -1]))
            {
                Console.Write($"[ {i} ]");
            }
            Console.WriteLine();

            Console.Write("풍선터트리기([3, 1, -2, -2, 1, 3] : "); // 답 : <1, 4, 2, 3, 5, 6>
            foreach (int i in Balloons.PopBalloons([3, 1, -2, -2, 1, 3]))
            {
                Console.Write($"[ {i} ]");
            }
            Console.WriteLine();
        }
    }
}
