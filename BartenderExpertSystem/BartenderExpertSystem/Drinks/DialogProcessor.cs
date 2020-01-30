using System;
using System.Collections.Generic;
using BartenderExpertSystem.Services;

namespace BartenderExpertSystem.Drinks
{
    internal class DialogProcessor
    {
        private readonly List<string> _alcoholes = IOManager.GetBeverages("alcohole.txt");
        private readonly List<string> _ingrediences = IOManager.GetBeverages("ingrediences.txt");
        private readonly List<string> _flavours = IOManager.GetFlavours("flavours.txt");
        private readonly Dictionary<string, List<string>> _rules = IOManager.GetRules("rules.txt");
        private readonly OrderService _orderService = new OrderService();
        public List<string> ProcessDialog()
        {

            var orderList = new List<string>();

            orderList.AddRange(_orderService.ChooseWithRepetition(_alcoholes, "Wybierz typy alkoholi, które preferujesz"));
            orderList.AddRange(_orderService.ChooseWithRepetition(_flavours, "Wybierz typy smaków, które preferujesz"));
            orderList.AddRange(_orderService.ChooseWithRepetition(_ingrediences, "Wybierz typy dodatków, które preferujesz"));
            orderList = new List<string>(new HashSet<string>(orderList));
            var topResults = _orderService.GetTopResults(_rules, orderList, 3);

            Console.WriteLine("Twoje preferencje to:");
            foreach (var item in orderList)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("\n\nNajlepsze propozycje to:");
            foreach (var (key, value) in topResults)
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(key);
                Console.ForegroundColor = ConsoleColor.White;
                foreach (var item in value)
                {
                    Console.Write(item + " ");
                }
            }
            Console.WriteLine();
            Console.WriteLine();

            return orderList;
        }
    }
}
