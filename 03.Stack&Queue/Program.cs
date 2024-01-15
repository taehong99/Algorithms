namespace _03.Stack_Queue
{
    /*
        1.<괄호 검사기를 구현하자>
            괄호 : 괄호가 바르게 짝지어졌다는 것은 열렸으면 짝지어서 닫혀야 한다는 뜻

            텍스트를 입력으로 받아서 괄호가 유효한지 판단하는 함수
            bool IsOk(string text) { }

                검사할 괄호 : [], {}, ()

            예시: () 완성, (() 미완성, [) 미완성, [[(){}]] 완성

        2. <작업 프로세스>
            배열로 각 작업이 몇시간이 걸리는지 있다.
            예시 : [4, 4, 12, 10, 2, 10]

            하루에 8시간씩 일할 수 있는 회사가 있음.
            남는시간없이 주어진 일을 계속한다고 했을때.
            각각의 작업이 끝나는 날짜를 결과 배열로 출력

            int[] ProcessJob(int[] jobList) {}

            결과 : [1, 1, 3, 4, 4, 6]
    */
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. <괄호 검사기>
            Console.WriteLine("<괄호 검사기>");
            Console.WriteLine($"() = {Brackets.IsCorrectBracket("()")}");
            Console.WriteLine($"(() = {Brackets.IsCorrectBracket("(()")}");
            Console.WriteLine($"[) = {Brackets.IsCorrectBracket("[)")}");
            Console.WriteLine($"{{[()]}} = {Brackets.IsCorrectBracket("{[()]}")}");
            Console.WriteLine($"()[]{{}} = {Brackets.IsCorrectBracket("()[]{}")}");
            Console.WriteLine($"{{(}})[] = {Brackets.IsCorrectBracket("{(})[]")}");
            Console.WriteLine($"[[(){{}}]] = {Brackets.IsCorrectBracket("[[(){}]]")}");

            // 2. <작업 프로세스>
            Console.WriteLine("\n<작업 프로세스>");
            Console.Write($"작업 : [4, 4, 12, 10, 2, 10], 결과 : ");
            PrintArray(TaskProcess.ProcessJob([4, 4, 12, 10, 2, 10]));

            Console.Write($"작업 : [9, 7, 8, 6, 4, 4], 결과 : ");
            PrintArray(TaskProcess.ProcessJob([9, 7, 8, 6, 4, 4]));
        }

        static void PrintArray(int[] array)
        {
            foreach(int i in array)
            {
                Console.Write($"[{i}]");
            }
            Console.WriteLine();
        }
    }
}
