namespace BartenderExpertSystem.Services
{
    internal struct ResultBeverage
    {
        public readonly string Name;
        public readonly double Confidence;

        public ResultBeverage(string name, double confidence)
        {
            Name = name;
            Confidence = confidence;
        }
    }
}