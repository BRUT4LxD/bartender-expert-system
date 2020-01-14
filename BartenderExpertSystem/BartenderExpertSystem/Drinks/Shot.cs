using BartenderExpertSystem.Choices;

namespace BartenderExpertSystem.Drinks
{
    internal class Shot : DrinkBase
    {
        public VodkaType VodkaType { get; set; }
        public Syrup FirstSyrup { get; set; }
        public Syrup SecondSyrup { get; set; }
    }
}