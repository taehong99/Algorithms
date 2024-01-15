using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Stack_Queue
{
    /*<작업 프로세스>
        배열로 각 작업이 몇시간이 걸리는지 있다.
        예시 : [4, 4, 12, 10, 2, 10]

        하루에 8시간씩 일할 수 있는 회사가 있음.
        남는시간없이 주어진 일을 계속한다고 했을때.
        각각의 작업이 끝나는 날짜를 결과 배열로 출력

        int[] ProcessJob(int[] jobList) {}

        결과 : [1, 1, 3, 4, 4, 6]
    */
    internal class TaskProcess
    {
        const int workingHours = 8;
        public static int[] ProcessJob(int[] jobList) {
            List<int> days = new List<int>();
            Array.Reverse(jobList);
            Stack<int> jobs = new Stack<int>(jobList);

            int day = 1;
            int remainingHours = workingHours;
            while(jobs.Count > 0)
            {
                int job = jobs.Peek();
                jobs.Pop();

                if(job > remainingHours) // 오늘 안에 못끝낸다
                {
                    // 할만큼 하고 퇴근
                    job -= remainingHours;
                    jobs.Push(job);
                    // 내일 보자
                    day++;
                    remainingHours = workingHours;
                }
                else if(job < remainingHours) // 끝내도 시간이 남는다
                {
                    days.Add(day);
                    remainingHours -= job;
                }
                else // 시간이 딱 맞다
                {
                    days.Add(day);
                    // 내일 보자
                    day++;
                    remainingHours = workingHours;
                }
            }

            return days.ToArray();
        }

    }
}
