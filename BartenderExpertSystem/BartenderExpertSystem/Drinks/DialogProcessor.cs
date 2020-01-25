using System.Collections.Generic;
using BartenderExpertSystem.Choices;
using BartenderExpertSystem.Services;

namespace BartenderExpertSystem.Drinks
{
    internal class DialogProcessor
    {
        private readonly OrderService _orderService = new OrderService();
        public List<string> ProcessDialog()
        {
            var orderList = new List<string>
            {
                _orderService.Choose(BarInfo.AlcoholTypes, "Jaki typ alkoholu preferujesz?"),
                _orderService.Choose(BarInfo.BeerTypes, "Jaki typ piwa preferujesz?"),
                _orderService.Choose(BarInfo.Syrups, "Jaki typ syropu preferujesz?")
            };
            return orderList;
        }
    }
}
