using BartenderExpertSystem.Choices;

namespace BartenderExpertSystem.Drinks
{
    internal class Beer : DrinkBase
    {
        public Beer Type { get; set; }
        public Syrup Syrup { get; set; }
    }
}