using StrategyPattern.Abstractions;

namespace StrategyPattern.Behaviors
{
    public class AxeBehavior : IWeaponBehavior
    {
        public void UseWeapon()
        {
            Console.WriteLine("Axe sound...");
        }
    }
}
