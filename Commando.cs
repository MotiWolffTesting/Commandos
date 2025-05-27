using System;

namespace Commandos
{
    // Basic Commando class
    public class Commando
    {
        // Changing name to private
        private string name;
        public string codeName;
        public string[] tools;
        public string status;

        // Constructor
        public Commando(string name, string codeName)
        {
            this.name = name;
            this.codeName = codeName;
            this.tools = new string[5] { "Chisel", "Bag", "Rope", "Water Tank", "Hammer" };
            this.status = "Standing";
        }

        // Walk Method
        public void Walk()
        {
            status = "Walking";
            Console.WriteLine($"Soldier {codeName} is walking.");
        }

        // Hide Method
        public void Hide()
        {
            status = "Hiding";
            Console.WriteLine($"Soldier {codeName} is hiding.");
        }

        // Attack Method
        public void Attack()
        {
            Console.WriteLine($"Commando with {codeName} code-name is attacking!");
        }

        // SayName Method
        public string SayName(string commanderRank)
        {
            switch (commanderRank.ToUpper())
            {
                case "GENERAL":
                    return $"Real name: {name}";
                case "COLONEL":
                    return $"Code-Name: {codeName}";
                default:
                    return "Access denied - Classified intel";
            }
        }

        // Another method to use private field
        public void IntroduceToGeneral()
        {
            Console.WriteLine($"Report to general: Soldier {name} with codename {codeName} reporting for duty!");
        }

        public void TryToRevealName()
        {
            Console.WriteLine("Someone is trying to reveal your name but the name is protected!");
        }

        public void DisplayWeaponInfo()
        {
            Console.WriteLine($"=== Soldier Details ===");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Codename: {codeName}");
            Console.WriteLine($"Status: {status}");
            Console.WriteLine($"Tools: {string.Join(", ", tools)}");
            Console.WriteLine($"==================");
        }
    }
}