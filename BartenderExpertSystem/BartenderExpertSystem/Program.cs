using System;
using BartenderExpertSystem.Drinks;

namespace BartenderExpertSystem
{
    internal class Program
    {
        protected Program() { }
        private static void Main()
        {
            var xx = new DialogProcessor().ProcessDialog();
            foreach (var x in xx)
            {
                Console.Write(x + " ");
            }
        }
    }
}
