using System;
using System.Collections.Generic;

namespace BartenderExpertSystem.Services
{
    internal class OrderService
    {
        public string Choose(IList<string> list, string question)
        {
            string x;
            do
            {
                Console.WriteLine(question);
                var counter = 1;
                foreach (var type in list)
                {
                    Console.WriteLine($"{counter++}. {type}");
                }

                x = Console.ReadLine();
            } while (!int.TryParse(x, out int result) || !IsInRange(result, list));

            return list[int.Parse(x) - 1];
        }

        private static bool IsInRange(int number, ICollection<string> list)
        {
            return number <= list.Count && number >= 1;
        }
    }
}