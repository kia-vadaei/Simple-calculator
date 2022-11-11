using DS_Proj3_Calculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_Proj3_Calulator
{
    internal class MySetting
    {
        public class MySettings
        {
            internal static int Op(char c)
            {
                if (c == '+' || c == '-')
                    return 1;
                if (c == '*' || c == '/')
                    return 2;
                if (c == '^')
                    return 3;
                return -1;
            }
            public static string infToPos(string str)
            {
                // initializing empty String for result
                string result = "";

                // initializing empty stack
                //Stack<char> stack = new Stack<char>();
                MyStack<char> stack = new MyStack<char>();

                for (int i = 0; i < str.Length; ++i)
                {
                    char c = str[i];

                    if (char.IsLetterOrDigit(c))
                        result += c;

                    else if (c == '(')
                        stack.Push(c);

                    else if (c == ')')
                    {
                        while (stack.getSize() > 0 && stack.Peek() != '(')
                            result += stack.Pop();

                        if (stack.getSize() > 0 && stack.Peek() != '(')
                            return "ERROR";
                        else
                            stack.Pop();
                    }
                    else
                    {
                        while (stack.getSize() > 0 && Op(c) <= Op(stack.Peek()))
                            result += stack.Pop();
                        stack.Push(c);
                    }
                }

                // pop all the operators from the stack
                while (stack.getSize() > 0)
                    result += stack.Pop();

                return result;
            }

            //public static double calcute(string phrase)
            //{
            //    MyStack<string> stack = new MyStack<string>();
            //    for (int i = 0; i < phrase.Length; i++)
            //    {
            //        char c = phrase[i];
            //        if (char.IsLetterOrDigit(c))
            //            stack.Push(c);
            //        else
            //        {
            //            if(c == '+')
            //            {
            //                double frt = double.Parse(stack.)
            //            }
            //        }
            //    }
            //}
        }
    }
}
