namespace Commandos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Commandos Project ===\n");

            // Creating polymorphic 
            Console.WriteLine("Crearting an array of 3 soldiers...");
            Commando regularCommando = new Commando("Moti Wolff", "The Young Wolf");
            AirCommando airCommando = new AirCommando("Sternie Wolff", "The Wifey");
            SeaCommando seaCommando = new SeaCommando("Wolff's Future", "Future");

            Commando[] commandoArray = new Commando[3];
            commandoArray[0] = regularCommando;
            commandoArray[1] = airCommando;
            commandoArray[2] = seaCommando;

            Console.WriteLine($"Array Length: {commandoArray.Length}");
            Console.WriteLine($"Array Type: {commandoArray.GetType()}\n");

            foreach (Commando soldier in commandoArray)
            {
                Console.Write($"Soldier {soldier.codeName}: ");
                soldier.Attack();
            }

            // Integration Check
            Console.WriteLine("\n=== Final Phase | Integration Check ===");

            // Basic Functionality Check for each type

            // Walk Check
            foreach (Commando soldier in commandoArray)
            {
                soldier.Walk();
            }

            // Hide Check
            foreach (Commando soldier in commandoArray)
            {
                soldier.Hide();
            }

            // Accessing private fields via SayName
            foreach (Commando soldier in commandoArray)
            {
                Console.WriteLine($"\n{soldier.codeName}:");
                Console.WriteLine($"  GENERAL access: {soldier.SayName("GENERAL")}");
                Console.WriteLine($"  COLONEL access: {soldier.SayName("COLONEL")}");
                Console.WriteLine($"  SERGEANT access: {soldier.SayName("SERGEANT")}");
            }

            // Check changing codename via property
            string[] originalNames = new string[3];

            for (int i = 0; i < commandoArray.Length; i++)
            {
                originalNames[i] = commandoArray[i].codeName;
                commandoArray[i].codeName = $"New{originalNames[i]}";
                Console.WriteLine($"Changed: {originalNames[i]} → {commandoArray[i].codeName}");
            }

            // Returning original names
            for (int i = 0; i < commandoArray.Length; i++)
            {
                commandoArray[i].codeName = originalNames[i];
            }

            // Check Special Functionalities
            foreach (Commando soldier in commandoArray)
            {
                if (soldier is AirCommando airSoldier)
                {
                    Console.Write($"{soldier.codeName} (Air): ");
                    airSoldier.Parachute();
                }
                else if (soldier is SeaCommando seaSoldier)
                {
                    Console.Write($"{soldier.codeName} (Sea): ");
                    seaSoldier.Swim();
                }
                else
                {
                    Console.WriteLine($"{soldier.codeName} (Regular): No special abilities");
                }
            }


            // Creating Weapons & Using
            Weapon[] weapons = new Weapon[3];
            weapons[0] = new Weapon("M4A1", "Colt", 30);
            weapons[1] = new Weapon("AK-47", "Kalashnikov", 25);
            weapons[2] = new Weapon("MP5", "H&K", 20);

            for (int i = 0; i < commandoArray.Length; i++)
            {
                Console.WriteLine($"\n{commandoArray[i].codeName} recieves {weapons[i].name}:");
                weapons[i].DisplayWeaponInfo();

                Console.WriteLine($"{commandoArray[i].codeName} shooting:");
                weapons[i].Shoot();
                weapons[i].Shoot();
            }

            // Displaying info
            foreach (Commando soldier in commandoArray)
            {
                soldier.DisplayInfo();
                Console.WriteLine($"Type: {soldier.GetType().Name}");
            }

            foreach (Weapon weapon in weapons)
            {
                weapon.DisplayWeaponInfo();
            }


        }
    }
}