using System;

namespace Commandos
{
    // Weapon class
    public class Weapon
    {
        public string name;
        public string manufacturer;
        public int bulletCount;

        public Weapon(string name, string manufacturer, int bulletCount)
        {
            this.name = name;
            this.manufacturer = manufacturer;
            this.bulletCount = bulletCount;
        }

        // Shoot Method
        public void Shoot()
        {
            if (bulletCount > 0)
            {
                bulletCount--;
                Console.WriteLine($"{name} is shooting!! Remaining bullets: {bulletCount}");
            }
            else
            {
                Console.WriteLine($"{name} has no bullets.");
            }
        }

        public void DisplayWeaponInfo()
        {
            Console.WriteLine($"=== Weapon Details ===");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Manufacturer: {manufacturer}");
            Console.WriteLine($"Bullets: {bulletCount}");
            Console.WriteLine($"=================");
        }
    }
}