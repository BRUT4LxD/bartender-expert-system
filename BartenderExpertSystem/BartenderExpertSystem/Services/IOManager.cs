using System.Collections.Generic;
using System.IO;

namespace BartenderExpertSystem.Services
{
    public class IOManager
    {
        protected IOManager()
        {
        }

        public static Dictionary<string, List<string>> GetRules(string filePath)
        {
            var results = new Dictionary<string, List<string>>();

            string[] lines = File.ReadAllLines(filePath);

            foreach (string line in lines)
            {
                string[] beverage = line.Split(',');
                var ing = new List<string>(beverage);
                ing.RemoveAt(beverage.Length - 1);
                results[beverage[^1]] = ing;
            }

            return results;
        }
        public static List<string> GetBeverages(string filePath)
        {
            return new List<string>(File.ReadAllLines(filePath));
        }

        public static List<string> GetIngrediences(string filePath)
        {
            return new List<string>(File.ReadAllLines(filePath));
        }

        public static List<string> GetFlavours(string filePath)
        {
            return new List<string>(File.ReadAllLines(filePath));
        }
    }
}
