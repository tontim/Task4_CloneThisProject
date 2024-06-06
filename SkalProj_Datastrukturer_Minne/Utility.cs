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
    }
}

