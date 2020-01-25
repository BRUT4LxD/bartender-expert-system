namespace BartenderExpertSystem.States
{
    internal abstract class AbstractState
    {
        protected readonly IClient Client;
        protected AbstractState(IClient client)
        {
            Client = client;
        }

        public abstract void ChooseAlcohol();

        public abstract void ChooseJuice();

        public abstract void ChooseSyrup();

        public abstract void ChooseFruit();

        public abstract void ChooseBeverage();
    }
}
