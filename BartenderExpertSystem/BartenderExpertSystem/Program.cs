using BartenderExpertSystem.Drinks;

namespace BartenderExpertSystem
{
    internal class Program
    {
        protected Program() { }
        private static void Main()
        {
            new DialogProcessor().ProcessDialog();
        }
    }
}
