namespace Commandos
{
    // Weapon operation interface
    public interface IWeapon
    {
        string Name { get; }
        string Manufacturer { get; }
        int BulletCount { get; }
        void Shoot();
        void DisplayWeaponInfo();
    }
}
