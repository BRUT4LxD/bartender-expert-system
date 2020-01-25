namespace BartenderExpertSystem.States
{
    internal class BeerState : AbstractState
    {
        public BeerState(IClient client) : base(client)
        {
        }

        public override void ChooseAlcohol()
        {
            throw new System.NotImplementedException();
        }

        public override void ChooseJuice()
        {
            throw new System.NotImplementedException();
        }

        public override void ChooseSyrup()
        {
            throw new System.NotImplementedException();
        }

        public override void ChooseFruit()
        {
            throw new System.NotImplementedException();
        }

        public override void ChooseBeverage()
        {
            throw new System.NotImplementedException();
        }
    }
}