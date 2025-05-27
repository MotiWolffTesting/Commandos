namespace Commandos
{
    class Program
    {
        static void Main(string[] args)
        {
            Commando agent = new Commando("Moti", "The Young Wolf");

            // Calling property
            Console.WriteLine($"Current CodeName: {agent.codeName}");

            agent.DisplayInfo();

            // Changing code name
            agent.codeName = "The Old Wolf";
            Console.WriteLine($"New code name: {agent.codeName}");

        }
    }
}