using System;

namespace Task.Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Weapon weapon = new Weapon();
            weapon.maxNumbers = 30;
            Console.WriteLine(weapon.curNumber);
            weapon.Shoot();
            Console.WriteLine(weapon.curNumber);
            weapon.Reload();
            Console.WriteLine(weapon.curNumber);

        }
    }
}
