using System;

namespace Commandos
{
    // Weapon class implementing IWeapon interface
    public class Weapon : IWeapon
    {
        // Encapsulating fields with properties
        private string _name;
        private string _manufacturer;
        private int _bulletCount;

        public string Name => _name;
        public string Manufacturer => _manufacturer;
        public int BulletCount => _bulletCount;

        public Weapon(string name, string manufacturer, int bulletCount)
        {
            _name = name;
            _manufacturer = manufacturer;
            _bulletCount = bulletCount;
        }

        // Shoot Method
        public void Shoot()
        {
            if (_bulletCount > 0)
            {
                _bulletCount--;
                Console.WriteLine($"{_name} is shooting!! Remaining bullets: {_bulletCount}");
            }
            else
            {
                Console.WriteLine($"{_name} has no bullets.");
            }
        }

        public void DisplayWeaponInfo()
        {
            Console.WriteLine($"=== Weapon Details ===");
            Console.WriteLine($"Name: {_name}");
            Console.WriteLine($"Manufacturer: {_manufacturer}");
            Console.WriteLine($"Bullets: {_bulletCount}");
            Console.WriteLine($"=================");
        }
    }
}