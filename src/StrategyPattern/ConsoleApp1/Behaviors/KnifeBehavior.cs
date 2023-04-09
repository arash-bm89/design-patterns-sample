using StrategyPattern.Abstractions;

namespace StrategyPattern.Behaviors
{
    public class KnifeBehavior : IWeaponBehavior
    {
        public void UseWeapon()
        {
            Console.WriteLine("Knife sound...");
        }
    }
}
