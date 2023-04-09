using StrategyPattern.Abstractions;

namespace StrategyPattern.Behaviors
{
    public class BowAndArrowBehavior : IWeaponBehavior
    {
        public void UseWeapon()
        {
            Console.WriteLine("Bow and arrow sound...");
        }
    }
}
