using BartenderExpertSystem.Choices;

namespace BartenderExpertSystem.Drinks
{
    internal class Cocktail : DrinkBase
    {
        public Fruit Fruit { get; set; }
        public Beverage Beverage { get; set; }
        public Syrup Syrup { get; set; }
    }
}