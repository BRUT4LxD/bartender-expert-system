using System;
using BartenderExpertSystem.Drinks;

namespace BartenderExpertSystem
{
    internal class Program
    {
        protected Program() { }
        private static void Main()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("\n\n\t\tSYSTEM EKSPERCKI POMAGAJĄCY W PODJĘCIU DECYZJI ALKOHOLOWEJ\n\n");


            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            new DialogProcessor().ProcessDialog();
        }
    }
}
