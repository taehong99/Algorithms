using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.LinkedList
{
    /*
    
    A+. 1번부터 N번까지 N개의 풍선이 원형으로 놓여 있고. i번 풍선의 오른쪽에는 i+1번 풍선이 있고, 왼쪽에는 i-1번 풍선이 있다. 
    단, 1번 풍선의 왼쪽에 N번 풍선이 있고, N번 풍선의 오른쪽에 1번 풍선이 있다. 
    각 풍선 안에는 종이가 하나 들어있고, 종이에는 -N보다 크거나 같고, N보다 작거나 같은 정수가 하나 적혀있다. 
    이 풍선들을 다음과 같은 규칙으로 터뜨린다. 우선, 제일 처음에는 1번 풍선을 터뜨린다. 다음에는 풍선 안에 있는 종이를 꺼내어 그 종이에 적혀있는 값만큼 이동하여 다음 풍선을 터뜨린다. 
    양수가 적혀 있을 경우에는 오른쪽으로, 음수가 적혀 있을 때는 왼쪽으로 이동한다. 이동할 때에는 이미 터진 풍선은 빼고 이동한다.
    예를 들어 다섯 개의 풍선 안에 차례로 3, 2, 1, -3, -1이 적혀 있었다고 하자. 
    이 경우 3이 적혀 있는 1번 풍선, -3이 적혀 있는 4번 풍선, -1이 적혀 있는 5번 풍선, 1이 적혀 있는 3번 풍선, 2가 적혀 있는 2번 풍선의 순서대로 터지게 된다.

     */
    internal class Balloons
    {
        struct Balloon
        {
            public int paper;
            public int number;
            public Balloon(int number, int paper)
            {
                this.paper = paper;
                this.number = number;
            }
        }
        
        public static int[] PopBalloons(int[] papers)
        {
            // 터트린 순서
            List<int> order = new List<int>();

            // 풍선 원형
            LinkedList<Balloon> circle = new LinkedList<Balloon>();
            for (int i = 0; i < papers.Length; i++)
            {
                circle.AddLast(new Balloon(i + 1, papers[i]));
            }

            // 풍선 터트리기
            LinkedListNode<Balloon> node = circle.First;
            int delta = 1;
            while (circle.Count > 1)
            {
                // 앞으로 갈지 뒤로 갈지
                if (delta >= 0)
                {
                    for (int i = 0; i < delta - 1; i++)
                    {
                        if (node == circle.Last)
                        {
                            node = circle.First;
                        }
                        else
                        {
                            node = node.Next;
                        }
                    }
                }
                else
                {
                    for (int i = delta + 1; i < 0; i++)
                    {
                        if (node == circle.First)
                        {
                            node = circle.Last;
                        }
                        else
                        {
                            node = node.Previous;
                        }
                    }
                }
                
                // 도착한 풍선 추가
                order.Add(node.Value.number);
                delta = node.Value.paper;

                // 음수면 뒤로, 양수면 앞으로
                LinkedListNode<Balloon> temp = null;
                if (delta < 0)
                {
                    if (node == circle.First)
                    {
                        temp = circle.Last;
                    }
                    else
                    {
                        temp = node.Previous;
                    }
                }
                else
                {
                    if (node == circle.Last)
                    {
                        temp = circle.First;
                    }
                    else
                    {
                        temp = node.Next;
                    }
                }

                circle.Remove(node);
                node = temp;
            }

            // 남은 풍선 터트리기
            order.Add(node.Value.number);

            return order.ToArray();
        }
    }
}
