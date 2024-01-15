using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Stack_Queue
{
    /*<괄호 검사기를 구현하자>
    괄호 : 괄호가 바르게 짝지어졌다는 것은 열렸으면 짝지어서 닫혀야 한다는 뜻

    텍스트를 입력으로 받아서 괄호가 유효한지 판단하는 함수
    bool IsOk(string text) { }

        검사할 괄호 : [], {}, ()

    예시: () 완성, (() 미완성, [) 미완성, [[(){}]] 완성*/

    internal class Brackets
    {
        public static bool IsCorrectBracket(string s)
        {
            Stack<char> opens = new Stack<char>();
            foreach(char c in s)
            {
                if (c == '(' || c == '[' || c == '{') {
                    opens.Push(c);
                }
                else if(c == ')')
                {
                    if(opens.Count > 0 && opens.Peek() == '(')
                    {
                        opens.Pop();
                    }
                    else
                    {
                        return false;
                    }
                }
                else if (c == ']')
                {
                    if (opens.Count > 0 && opens.Peek() == '[')
                    {
                        opens.Pop();
                    }
                    else
                    {
                        return false;
                    }
                }
                else if (c == '}')
                {
                    if (opens.Count > 0 && opens.Peek() == '{')
                    {
                        opens.Pop();
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            return opens.Count > 0 ? false : true;
        }
    }
}
