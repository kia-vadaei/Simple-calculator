using DevComponents.DotNetBar;
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
            public static bool Parentheses_check(string val)
            {
                string openning = "([{<";
                string closing = ")]}>";
                    bool check = false;
                    Stack<char> stack = new Stack<char>();
                    for (int i = 0; i < val.Length; i++)
                    {
                        if (openning.IndexOf(val[i]) != -1)
                            stack.Push(val[i]);
                        else if (closing.IndexOf(val[i]) != -1)
                        {
                            if (stack.Count == 0)
                            {
                                return false;
                            }
                            if (closing.IndexOf(val[i]) != openning.IndexOf(stack.Pop()))
                            {
                                return false;
                            }
                        }
                    }
                    if (stack.Count == 0)
                        return true;
                    else
                        return false;
                
            }
            internal static int Op(char c)
            {
                if (c == '+' || c == '-')
                    return 1;
                if (c == '*' || c == '✕' || c == '/' || c == '%')
                    return 2;
                if (c == '^' || c == '√' || c == '$' || c == '#')
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

                    if (char.IsLetterOrDigit(c) || c == '.')
                        result += c;

                    else if (c == '(')
                    {
                        if (c == ' ')
                            continue;
                        stack.Push(c);
                    }

                    else if (c == ')')
                    {
                        if (c == ' ')
                            continue;
                        while (stack.getSize() > 0 && stack.Peek() != '(')
                            result += stack.Pop();

                        if (stack.getSize() > 0 && stack.Peek() != '(')
                            return "ERROR";
                        else
                            stack.Pop();
                    }
                    else
                    {
                        if (c == ' ')
                            continue;
                        
                        while (stack.getSize() > 0 && Op(c) <= Op(stack.Peek()))
                            result += stack.Pop();
                        result += ' ';
                        stack.Push(c);
                    }
                }

                // pop all the operators from the 
                while (stack.getSize() > 0)
                    result += stack.Pop();
                return result;

            }

            public static double calcute(string phrase)
            {
                MyStack<string> stack = new MyStack<string>();
                string tmp = "";
                int i = 0;
                try
                {
                    while (i < phrase.Length)
                    {
                        char c = phrase[i];
                        if (char.IsLetterOrDigit(c))
                        {
                            while (c != ' ' && (char.IsLetterOrDigit(c) || c == '.'))
                            {
                                try
                                {
                                    tmp += c;
                                    c = phrase[i + 1];
                                    i++;
                                }
                                catch (Exception)
                                {
                                    i++;
                                    break;
                                }

                            }
                            stack.Push(tmp);
                            Console.WriteLine("item is >> " + tmp);
                            tmp = "";
                        }
                        else if (c != ' ')
                        {
                            if (c == '+')
                            {
                                double sec = double.Parse(stack.Pop());
                                double frt = double.Parse(stack.Pop());
                                stack.Push((frt + sec).ToString());
                                Console.WriteLine(">>> " + frt + " " + sec + " " + c);
                            }
                            if (c == '✕' || c == '*')
                            {
                                double sec = double.Parse(stack.Pop());
                                double frt = double.Parse(stack.Pop());
                                stack.Push((frt * sec).ToString());
                                Console.WriteLine(">>> " + frt + " " + sec + " " + c);

                            }
                            if (c == '-')
                            {
                                double sec = double.Parse(stack.Pop());
                                double frt = double.Parse(stack.Pop());
                                stack.Push((frt - sec).ToString());
                                Console.WriteLine(">>> " + frt + " " + sec + " " + c);

                            }
                            if (c == '/' || c == '÷')
                            {
                                double sec = double.Parse(stack.Pop());
                                double frt = double.Parse(stack.Pop());
                                if(sec != 0)
                                    stack.Push((frt / sec).ToString());
                                else
                                {
                                    try { throw new Exception("/0"); }
                                    catch (Exception) { Console.WriteLine("ERROR_/0"); return -123456.123456; }
                                }
                                Console.WriteLine(">>> " + frt + " " + sec + " " + c);

                            }
                            if (c == '^')
                            {
                                double sec = double.Parse(stack.Pop());
                                double frt = double.Parse(stack.Pop());
                                stack.Push(Math.Pow(frt, sec).ToString());
                                Console.WriteLine(">>> " + frt + " " + sec + " " + c);
                            }
                            if (c == '√')
                            {
                                double frt = double.Parse(stack.Pop());
                                stack.Push(Math.Sqrt(frt).ToString());
                                Console.WriteLine(">>> " + frt + " " + c);
                            }
                            if (c == '$')
                            {
                                double frt = double.Parse(stack.Pop());
                                stack.Push(Math.Sin(frt).ToString());
                                Console.WriteLine(">>> " + frt + " " + c);
                            }
                            if (c == '#')
                            {
                                double frt = double.Parse(stack.Pop());
                                stack.Push(Math.Cos(frt).ToString());
                                Console.WriteLine(">>> " + frt + " " + c);
                            }
                            if (c == '%')
                            {
                                double sec = double.Parse(stack.Pop());
                                double frt = double.Parse(stack.Pop());
                                stack.Push(((frt / 100) * sec).ToString());
                                Console.WriteLine(">>> " + frt + " " + sec + " " + c);
                            }

                            i++;
                        }
                        else if (c == ' ')
                            i++;
                    }

                    Console.WriteLine("The result is >> " + double.Parse(stack.Peek())  + "\n########################################");
                    return double.Parse(stack.Pop());
                }
                catch (Exception)
                {
                    Console.WriteLine("Stack is Empty");
                    return -123456.123456;
                }
            }
        }
    }
}
