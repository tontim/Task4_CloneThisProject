using System;
using System.Collections.Generic;

namespace SkalProj_Datastrukturer_Minne
{
    class Program
    {
        /// <summary>
        /// The main method, vill handle the menues for the program
        /// </summary>
        /// <param name="args"></param>

        
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("Please navigate through the menu by inputting the number \n(1, 2, 3 ,4, 0) of your choice"
                    + "\n1. Examine a List"
                    + "\n2. Examine a Queue"
                    + "\n3. Examine a Stack"
                    + "\n4. CheckParenthesis"
                    + "\n0. Exit the application");
                char input = ' '; //Creates the character input to be used with the switch-case below.
                try
                {
                    input = Char.ToUpper(Console.ReadLine()![0]); //Tries to set input to the first char in an input line
                }
                catch (IndexOutOfRangeException) //If the input line is empty, we ask the users for some input.
                {
                    Console.Clear();
                    Console.WriteLine("Please enter some input!");
                }
                switch (input)
                {
                    case '1':
                        ExamineList();
                        break;
                    case '2':
                        ExamineQueue();
                        break;
                    case '3':
                        ExamineStack();
                        break;
                    case '4':
                        CheckParenthesis();
                        break;
                    /*
                     * Extend the menu to include the recursive 
                     * and iterative exercises.
                     */
                    case '0':
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Please enter some valid input (0, 1, 2, 3, 4)");
                        break;
                }
            }
        }

        /// <summary>
        /// Examines the datastructure List
        /// </summary>

        // Declaring myList here so I can use it across loops
        private static List<string> myList = new List<string>();

        static void ExamineList()
        {
            while (true)
            {

                Console.Write("Choose to add or remove from list:\n" +
                    "+ to add to list,\n" +
                    "- to remove from list,\n" +
                    "or enter Q to exit: ");

                string input = Console.ReadLine();

                //Converting to upper so we dont have to look for case sensitive inputs
                char nav = Char.ToUpper(input[0]);

                switch (nav)
                {
                    case '+':
                        Utility.AddToList(myList);
                        break;

                    case '-':
                        Utility.RemoveFromList(myList);
                        break;

                    case 'Q':
                        
                        return; //Exit loop

                    default:
                        Console.WriteLine("Please only use + & - for adding or removing.\n");
                        break;


                }
                //Listing the count and capacity + whatever is in the list
                Console.WriteLine($"List count: {myList.Count}, List capacity: {myList.Capacity}\n");
                
                //Nice to learn about foreach loop oneliners!
                myList.ForEach(Console.WriteLine);

            }
            

                /*
                 * Loop this method untill the user inputs something to exit to main menue.
                 * Create a switch statement with cases '+' and '-'
                 * '+': Add the rest of the input to the list (The user could write +Adam and "Adam" would be added to the list)
                 * '-': Remove the rest of the input from the list (The user could write -Adam and "Adam" would be removed from the list)
                 * In both cases, look at the count and capacity of the list
                 * As a default case, tell them to use only + or -
                 * Below you can see some inspirational code to begin working.
                */

                //List<string> theList = new List<string>();
                //string input = Console.ReadLine();
                //char nav = input[0];
                //string value = input.substring(1);

                //switch(nav){...}
            
        }

        /// <summary>
        /// Examines the datastructure Queue
        /// </summary>
        /// Once again creating outside of the of the loop so its saved
        static Queue<string> myQueue = new Queue<string>();
        static void ExamineQueue()
        {
            while (true)
            {

                Console.Write("Choose to enqueue or dequeue items:\n" +
                    "1 to Enqueue,\n" +
                    "2 to Dequeue,\n" +
                    "or enter Q to exit: ");

                string input = Console.ReadLine();

                char nav = Char.ToUpper(input[0]);

                switch (nav)
                {
                    case '1':
                        Utility.EnqueueItem(myQueue);
                        break;

                    case '2':
                        Utility.DequeueItem(myQueue);
                        break;

                    case 'Q':
                        return;

                    default:
                        Console.WriteLine("Enter a valid input.");
                        break;
                }

                Console.WriteLine("Current queue: ");
                foreach (var item in myQueue)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine("");
                /*
                 * Loop this method untill the user inputs something to exit to main menue.
                 * Create a switch with cases to enqueue items or dequeue items
                 * Make sure to look at the queue after Enqueueing and Dequeueing to see how it behaves
                */
            }
        }

        /// <summary>
        /// Examines the datastructure Stack
        /// </summary>
        static Stack<string> myStack = new Stack<string>();
        static void ExamineStack()
        {
            while (true)
            {

                Console.Write("Choose to push or pop items:\n" +
                    "1 to Push,\n" +
                    "2 to Pop,\n" +
                    "or enter Q to exit: ");

                string input = Console.ReadLine();

                char nav = Char.ToUpper(input[0]);

                switch (nav)
                {
                    case '1':
                        Utility.PushItem(myStack);
                        break;

                    case '2':
                        Utility.PopItem(myStack);
                        break;

                    case 'Q':
                        return;

                    default:
                        Console.WriteLine("Enter a valid input.");
                        break;
                }

                Console.WriteLine("\nCurrent stack: " + string.Join(", ", myStack));
                /*
                 * Loop this method until the user inputs something to exit to main menue.
                 * Create a switch with cases to push or pop items
                 * Make sure to look at the stack after pushing and and poping to see how it behaves
                */
            }
        }

        Stack<string> stringCheckP = new Stack<string>();

        static void CheckParenthesis()
        //PARENthesis() correction (was PARANthesis() earlier)

        {
            Console.WriteLine("Write (), [] or {} in any order to check if they are correct: ");
            string input = Console.ReadLine();
            bool isCorrect = Utility.PCheck(input);
            
            if (isCorrect)
            {
                Console.WriteLine("The input is correct! :)\n");
            }
            else
            {
                Console.WriteLine("The input is not correct. :(\n");
            }
            /*
             * Use this method to check if the paranthesis in a string is Correct or incorrect.
             * Example of correct: (()), {}, [({})],  List<int> list = new List<int>() { 1, 2, 3, 4 };
             * Example of incorrect: (()]), [), {[()}],  List<int> list = new List<int>() { 1, 2, 3, 4 );
             */

        }

    }
}


