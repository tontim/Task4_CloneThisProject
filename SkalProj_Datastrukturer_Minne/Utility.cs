using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkalProj_Datastrukturer_Minne
{
    internal class Utility
    {
        internal static void AddToList(List<string> list)
        {
            Console.Write("Enter something to add: ");
            var input = Console.ReadLine();
            list.Add(input);
        }
        internal static void RemoveFromList(List<string> list)
        {
            Console.Write("Enter something to remove: ");
            var input = Console.ReadLine();
            list.Remove(input);
        }
        internal static void EnqueueItem(Queue<string> queue)
        {
            Console.Write("Enter the item to enqueue: ");
            var input = Console.ReadLine();
            queue.Enqueue(input);
            Console.WriteLine($"Enqueued: {input}\n");
        }
        internal static void DequeueItem(Queue<string> queue)
        {
            if (queue.Count > 0)
            {
                string dequedItem = queue.Dequeue();
                Console.WriteLine($"Dequeued: {dequedItem}\n");
            }
            else
            {
                Console.WriteLine("Queue is empty.");
            }
        }
        internal static void PushItem(Stack<string> stack)
        {
            Console.Write("Enter the item to push: ");
            var input = Console.ReadLine();
            stack.Push(input);
            Console.WriteLine($"Inserted: {input} \n");
        }
        internal static void PopItem(Stack<string> stack)
        {
            if (stack.Count > 0)
            {
                //Display top of the stack and remove
                string removed = stack.Peek().ToString();
                Console.WriteLine(removed + " removed.\n");
                stack.Pop();
            }
            else
            {
                Console.WriteLine("Nothing to pop.");
            }

        }
        internal static bool PCheck(string input)
        {
            Stack<Char> stack = new Stack<char>();

            //for each (, { or [ in input, run the loop
            foreach (char c in input)
            {
                if (c == '(' || c == '{' || c == '[')
                {
                    //save starting parenthesis
                    stack.Push(c);
                }
                else if (c == ')' || c == '}' || c == ']')
                {
                    if (stack.Count == 0)
                    {
                        return false; // nothing to match
                    }

                    //if stack is not empty, pop the top item
                    char openParenthesis = stack.Pop();

                    // check popped item and compare it to c
                    if ((openParenthesis == '(' && c != ')') ||
                        (openParenthesis == '{' && c != '}') ||
                        (openParenthesis == '[' && c != ']'))
                    {
                        return false;
                    }
                }
            }
            //if all symbols had matching closing symbols, return true
            return stack.Count == 0;
        }

    }
}

