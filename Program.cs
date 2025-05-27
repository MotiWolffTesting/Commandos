namespace Commandos
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating Weapon class instances
            Console.WriteLine("== Weapons Manufcaturing ==");
            Weapon rifle1 = new Weapon("M16", "Colt", 30);
            Weapon pistol = new Weapon("Glock 17", "Glock", 17);
            Weapon sniperRifle = new Weapon("Barrett M82", "Barrett", 10);
            Weapon mag = new Weapon("FN MAG", "Colt", 200);

            // Diaplating weapons info
            rifle1.DisplayWeaponInfo();
            pistol.DisplayWeaponInfo();
            sniperRifle.DisplayWeaponInfo();
            mag.DisplayWeaponInfo();

            Console.WriteLine("Shoot Method Check: ");

            // Rifle shot
            Console.WriteLine("Rifle shooting: ");
            rifle1.Shoot();
            rifle1.Shoot();

            // Pistol shooting
            Console.WriteLine("Pistol shooting: ");
            pistol.Shoot();
            pistol.Shoot();

            Console.WriteLine("Check shooting series");
            Console.WriteLine("Sniper shooting");
            for (int i = 0; i < 12; i++)
            {
                Console.Write($"Shot {i + 1}: ");
                sniperRifle.Shoot();
            }


            // Creating Commando class instances
            Commando soldier = new Commando("Moti", "The Young Wolf");

            Console.WriteLine($"Soldier {soldier.codeName} preparing waepon: ");
            Weapon soldierWeapon = new Weapon("AK-47", "Kalashnikov", 25);
            soldierWeapon.DisplayWeaponInfo();

            Console.WriteLine("Battle simulation:");
            soldier.Walk();
            Console.WriteLine($"{soldier.codeName} using weapon: ");
            soldierWeapon.Shoot();
            soldierWeapon.Shoot();

            soldier.Hide();
            Console.WriteLine($"{soldier.codeName} shooting from hideout: ");
            soldierWeapon.Shoot();

            soldier.Attack();
            Console.WriteLine($"{soldier.codeName} with a mighty attack: ");
            for (int i = 0; i < 5; i++)
            {
                soldierWeapon.Shoot();
            }

            Console.WriteLine("\n--- Check Weapon Fields---");
            Console.WriteLine($"Weapon Name: {soldierWeapon.name}");
            Console.WriteLine($"Weapon Manufacturer: {soldierWeapon.manufacturer}");
            Console.WriteLine($"Remaining Bullets: {soldierWeapon.bulletCount}");
        }
    }
}