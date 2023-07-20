using System;
using System.Collections.Generic;

namespace main
{
    class Soal3
    {
        public static string BalancedBracket(string bracket)
        {
            // stack for opening bracket
            Stack<char> bracketStack = new Stack<char>();
            
            // bracket pair
            Dictionary<char, char> bracketDict = new Dictionary<char, char>
            {
                {'}', '{' },
                {')', '(' },
                {']', '[' },
            };

            foreach(char c in bracket)
            {
                if(c == '(' || c == '{' || c == '[')
                {
                    // push the opening bracket to the stack
                    bracketStack.Push(c);
                }else if(c == ')' || c == '}' || c == ']')
                {
                    if(bracketStack.Count == 0)
                    {
                        // the opening bracket and closing bracket is not in the same size
                        return "NO";
                    }

                    if(bracketDict[c] != bracketStack.Pop())
                    {
                        // the closing bracket is not the same with the opening
                        return "NO";
                    }
                }
            }

            return bracketStack.Count == 0 ? "YES" : "NO";
        }
    }
}