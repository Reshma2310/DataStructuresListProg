using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresListProg
{
    internal class BalancedParanthesesClass
    {
        public void BalancedParentheses()
        {
            bool valid = false;
            Console.WriteLine("Enter Arithmetic Expression:");
            string expression = Console.ReadLine();
            char[] charArray = expression.ToCharArray();
            int size = charArray.Length;
            for (int j = 0; j < size; j++)
            {
                if (charArray[j] == '(' || charArray[j] == '{' || charArray[j] == '[' || charArray[j] == ')' || charArray[j] == '}' || charArray[j] == ']')
                {
                    valid = true;
                    break;
                }
            }
            if (valid)
            {
                StackArray stack = new StackArray(size);
                int i = 0;
                while (i < size)
                {
                    if (charArray[i] == '(' || charArray[i] == '{' || charArray[i] == '[')
                    {
                        stack.Push(charArray[i]);
                    }
                    else if (charArray[i] == ')' || charArray[i] == '}' || charArray[i] == ']')
                    {
                        stack.Pop();
                    }
                    i++;
                }
                if (stack.IsEmpty())
                {
                    Console.WriteLine("Parentheses appeared in a Balanced fashion");
                }
                else
                {
                    Console.WriteLine("Parentheses are not appeared in a Balanced fashion");
                }
            }
            else
            {
                Console.WriteLine("There are no parentheses in given Input");
            }
        }
    }
}
