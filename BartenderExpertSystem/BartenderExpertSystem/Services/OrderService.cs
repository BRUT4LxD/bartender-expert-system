using System;
using System.Collections.Generic;
using System.Linq;

namespace BartenderExpertSystem.Services
{
    internal class OrderService
    {
        public IList<string> ChooseWithRepetition(IList<string> list, string question)
        {
            string x;
            string repetitionCommand = "Żeby zakończyć wybieranie wpisz x";
            IList<string> results = new List<string>();
            do
            {
                Console.WriteLine(repetitionCommand);
                Console.WriteLine();
                Console.WriteLine(question);
                var counter = 1;
                foreach (var type in list)
                {
                    Console.WriteLine($"{counter++}. {type}");
                }

                x = Console.ReadLine();

                if (!IsBadChoice(x, list))
                {
                    results.Add(list[int.Parse(x) - 1]);
                }

            } while (x.ToLower() != "x");

            return results;
        }

        private static bool IsBadChoice(string x, IList<string> list) => !int.TryParse(x, out int result) || !IsInRange(result, list);
        private static bool IsInRange(int number, ICollection<string> list)
        {
            return number <= list.Count && number >= 1;
        }
        public Dictionary<string, List<string>> GetTopResults(Dictionary<string, List<string>> rules, List<string> terms, int numberOfResults)
        {
            var results = new Dictionary<string, List<string>>();
            List<ResultBeverage> confBeverages = new List<ResultBeverage>();

            foreach (var (drinkName, ingrediences) in rules)
            {
                double a = terms.Intersect(ingrediences).ToList().Count;
                var conf = (a / terms.Count);
                PlaceBeverage(confBeverages, new ResultBeverage(drinkName, conf));
            }

            for (int i = 0; i < numberOfResults; i++)
            {
                results[confBeverages[i].Name] = rules[confBeverages[i].Name];
            }
            return results;
        }
        private void PlaceBeverage(List<ResultBeverage> confBeverages, ResultBeverage resultBeverage)
        {
            if (confBeverages.Count == 0)
            {
                confBeverages.Add(resultBeverage);
                return;
            }

            for (int i = 0; i < confBeverages.Count; i++)
            {
                if (confBeverages[i].Confidence < resultBeverage.Confidence)
                {
                    confBeverages.Insert(i, resultBeverage);
                    return;
                }
            }
            confBeverages.Add(resultBeverage);
        }

    }
}