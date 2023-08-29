using System;
using System.Collections.Generic;
using System.Text;

namespace CodingPractice.week1DS
{
    class paranthesisMatching
    {
        static string balancedParanthesis(string input)
        {
            Stack<(char, int)> s = new Stack<(char, int)>();
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '{' || input[i] == '(' || input[i] == '[')
                    s.Push((input[i], i));
                else if (input[i] == '}' || input[i] == ')' || input[i] == ']')
                {
                    if (s.Count <= 0)
                        return (i + 1).ToString();
                    else
                    {
                        char x = ' ';
                        if (s.Peek().Item1 == '[')
                            x = ']';
                        else if (s.Peek().Item1 == '{')
                            x = '}';
                        else if (s.Peek().Item1 == '(')
                            x = ')';
                        if (x == input[i])
                        {
                            s.Pop();
                        }
                        else
                        {
                            return (i + 1).ToString();
                        }
                    }
                }
            }
            if (s.Count > 0)
                return (s.Peek().Item2 + 1).ToString();
            return "Success";
        }

        //static void Main()
        //{
        //    string input = Console.ReadLine();
        //    Console.WriteLine(balancedParanthesis(input));
        //}
    }
}
