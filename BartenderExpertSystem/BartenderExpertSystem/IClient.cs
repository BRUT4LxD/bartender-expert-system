using BartenderExpertSystem.States;

namespace BartenderExpertSystem
{
    internal interface IClient
    {
        string Name { get; set; }
        AbstractState State { get; set; }
    }
}