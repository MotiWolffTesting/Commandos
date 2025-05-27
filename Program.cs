namespace Commandos
{
    class Program
    {
        static void Main(string[] args)
        {
            Commando agent = new Commando("Moti", "The Young Wolf");

            // Accessing public fields
            Console.WriteLine(agent.codeName);
            Console.WriteLine(agent.status);
            Console.WriteLine(agent.tools[0]);

            // Console.WriteLine(agent.name); // Will result in a compilation error

            // Check SayName
            Console.WriteLine($"Result: {agent.SayName("GENERAL")}");
            Console.WriteLine($"Result: {agent.SayName("COLONEL")}");
            Console.WriteLine($"Result: {agent.SayName("SERGEANT")}");

            agent.IntroduceToGeneral();

            agent.TryToRevealName();


        }
    }
}