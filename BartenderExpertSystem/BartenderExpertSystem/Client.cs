using BartenderExpertSystem.States;

namespace BartenderExpertSystem
{
    internal class Client : IClient
    {
        public string Name { get; set; }
        public AbstractState State { get; set; }
    }
}