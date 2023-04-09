using StrategyPattern.Abstractions;

namespace StrategyPattern.Behaviors
{
    public class SwordBehavior : IWeaponBehavior
    {
        public void UseWeapon()
        {
            Console.WriteLine("Sword sound...");
        }
    }
}
