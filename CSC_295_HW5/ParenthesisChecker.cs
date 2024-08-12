using System;
using System.Collections.Generic;

namespace CSC_295_HW5
{
    public class ParenthesisChecker
    {
        // Method to check if the given expression has balanced parentheses
        public static bool isBalanced(string expression)
        {
            // Create a stack to keep track of opening parentheses
            Stack<char> stack = new Stack<char>();

            // Iterate through each character in the expression
            foreach (char ch in expression)
            {
                // If the character is an opening parenthesis, push it onto the stack
                if (ch == '(' || ch == '{' || ch == '[')
                {
                    stack.Push(ch);
                }
                // If the character is a closing parenthesis
                else if (ch == ')' || ch == '}' || ch == ']')
                {
                    // If the stack is empty, it means there is no matching opening parenthesis
                    if (stack.Count == 0)
                    {
                        return false; // Unbalanced
                    }

                    // Pop the top element from the stack (should be the matching opening parenthesis)
                    char openBracket = stack.Pop();

                    // Check if the popped element matches the current closing parenthesis
                    if ((ch == ')' && openBracket != '(') ||
                        (ch == '}' && openBracket != '{') ||
                        (ch == ']' && openBracket != '['))
                    {
                        return false; // Unbalanced
                    }
                }
            }

            // If the stack is empty, all parentheses were matched correctly; otherwise, unbalanced
            return stack.Count == 0;
        }
    }
}
