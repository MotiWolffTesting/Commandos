using System;

namespace Commandos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Commandos Project ===\n");

            // Creating polymorphic 
            Console.WriteLine("Creating an array of 3 soldiers...");
            Commando regularCommando = new Commando("Moti Wolff", "The Young Wolf");
            AirCommando airCommando = new AirCommando("Sternie Wolff", "The Wifey");
            SeaCommando seaCommando = new SeaCommando("Wolff's Future", "Future");

            Commando[] commandoArray = new Commando[3];
            commandoArray[0] = regularCommando;
            commandoArray[1] = airCommando;
            commandoArray[2] = seaCommando;

            Console.WriteLine($"Array Length: {commandoArray.Length}");
            Console.WriteLine($"Array Type: {commandoArray.GetType()}\n");

            // Using them as ICombatants
            foreach (ICombatant soldier in commandoArray)
            {
                Console.Write($"Soldier {((Commando)soldier).CodeName}: ");
                soldier.Attack();
            }

            // Integration Check
            Console.WriteLine("\n=== Final Phase | Integration Check ===");

            // Basic Functionality Check for each type

            // Walk Check - using them as IMovable
            foreach (IMovable soldier in commandoArray)
            {
                soldier.Walk();
            }

            // Hide Check - using them as IMovable
            foreach (IMovable soldier in commandoArray)
            {
                soldier.Hide();
            }

            // Accessing private fields via SayName - using them as IIdentifiable
            foreach (IIdentifiable soldier in commandoArray)
            {
                Console.WriteLine($"\n{((Commando)soldier).CodeName}:");
                Console.WriteLine($"  GENERAL access: {soldier.SayName("GENERAL")}");
                Console.WriteLine($"  COLONEL access: {soldier.SayName("COLONEL")}");
                Console.WriteLine($"  SERGEANT access: {soldier.SayName("SERGEANT")}");
            }

            // Check changing codename via property
            string[] originalNames = new string[3];

            for (int i = 0; i < commandoArray.Length; i++)
            {
                originalNames[i] = commandoArray[i].CodeName;
                commandoArray[i].CodeName = $"New{originalNames[i]}";
                Console.WriteLine($"Changed: {originalNames[i]} → {commandoArray[i].CodeName}");
            }

            // Returning original names
            for (int i = 0; i < commandoArray.Length; i++)
            {
                commandoArray[i].CodeName = originalNames[i];
            }

            // Check Special Functionalities
            foreach (Commando soldier in commandoArray)
            {
                if (soldier is IAirMovable airSoldier)
                {
                    Console.Write($"{soldier.CodeName} (Air): ");
                    airSoldier.Parachute();
                }
                else if (soldier is ISeaMovable seaSoldier)
                {
                    Console.Write($"{soldier.CodeName} (Sea): ");
                    seaSoldier.Swim();
                }
                else
                {
                    Console.WriteLine($"{soldier.CodeName} (Regular): No special abilities");
                }
            }

            // Creating Weapons & Using
            IWeapon[] weapons = new IWeapon[3];
            weapons[0] = new Weapon("M4A1", "Colt", 30);
            weapons[1] = new Weapon("AK-47", "Kalashnikov", 25);
            weapons[2] = new Weapon("MP5", "H&K", 20);

            // Assigning weapons to soldiers
            for (int i = 0; i < commandoArray.Length; i++)
            {
                commandoArray[i].Weapon = weapons[i];
                Console.WriteLine($"\n{commandoArray[i].CodeName} receives {weapons[i].Name}:");
                weapons[i].DisplayWeaponInfo();

                Console.WriteLine($"{commandoArray[i].CodeName} shooting:");
                weapons[i].Shoot();
                weapons[i].Shoot();
            }

            // Displaying info - using them as IDisplayable
            foreach (IDisplayable soldier in commandoArray)
            {
                soldier.DisplayInfo();
                Console.WriteLine($"Type: {soldier.GetType().Name}");
            }

            foreach (IWeapon weapon in weapons)
            {
                weapon.DisplayWeaponInfo();
            }
        }
    }
}