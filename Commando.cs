using System;

namespace Commandos
{
    // Basic Commando class implementing multiple interfaces
    public class Commando : IMovable, ICombatant, IIdentifiable, IDisplayable
    {
        // Encapsulating fields
        private string _name;
        private string[] _tools;
        private string _status;

        // Property with proper naming convention
        public string CodeName { get; set; }

        // Equipment property - making it nullable to fix constructor issue
        private IWeapon? _weapon;
        public IWeapon? Weapon
        {
            get => _weapon;
            set => _weapon = value;
        }

        // Constructor
        public Commando(string name, string codeName)
        {
            _name = name;
            CodeName = codeName;
            _tools = new string[5] { "Chisel", "Bag", "Rope", "Water Tank", "Hammer" };
            _status = "Standing";
        }

        // IMovable implementation
        public void Walk()
        {
            _status = "Walking";
            Console.WriteLine($"Soldier {CodeName} is walking.");
        }

        public void Hide()
        {
            _status = "Hiding";
            Console.WriteLine($"Soldier {CodeName} is hiding.");
        }

        // ICombatant implementation
        public virtual void Attack()
        {
            Console.WriteLine($"Regular attack by {CodeName}");
        }

        // IIdentifiable implementation
        public string SayName(string commanderRank)
        {
            switch (commanderRank.ToUpper())
            {
                case "GENERAL":
                    return $"Real name: {_name}";
                case "COLONEL":
                    return $"Code-Name: {CodeName}";
                default:
                    return "Access denied - Classified intel";
            }
        }

        // Another method to use private field
        public void IntroduceToGeneral()
        {
            Console.WriteLine($"Report to general: Soldier {_name} with codename {CodeName} reporting for duty!");
        }

        public void TryToRevealName()
        {
            Console.WriteLine("Someone is trying to reveal your name but the name is protected!");
        }

        // IDisplayable implementation
        public void DisplayInfo()
        {
            Console.WriteLine($"=== Soldier Details ===");
            Console.WriteLine($"Name: {_name}");
            Console.WriteLine($"Codename: {CodeName}");
            Console.WriteLine($"Status: {_status}");
            Console.WriteLine($"Tools: {string.Join(", ", _tools)}");
            if (_weapon != null)
            {
                Console.WriteLine($"Weapon: {_weapon.Name} ({_weapon.BulletCount} bullets)");
            }
            Console.WriteLine($"==================");
        }
    }

    // AirCommando adds IAirMovable to interface implementations
    public class AirCommando : Commando, IAirMovable
    {
        public AirCommando(string name, string codeName) : base(name, codeName) { }

        // IAirMovable implementation
        public void Parachute()
        {
            Console.WriteLine($"Air Commando {CodeName} is parachuting!");
        }

        // Override from ICombatant implementation
        public override void Attack()
        {
            Console.WriteLine($"Air Strike is ongoing!");
        }
    }

    // SeaCommando adds ISeaMovable to interface implementations
    public class SeaCommando : Commando, ISeaMovable
    {
        public SeaCommando(string name, string codeName) : base(name, codeName) { }

        // ISeaMovable implementation
        public void Swim()
        {
            Console.WriteLine($"Sea Commando {CodeName} is diving under water!");
        }

        // Override from ICombatant implementation
        public override void Attack()
        {
            Console.WriteLine($"Sea Strike is ongoing!");
        }
    }
}