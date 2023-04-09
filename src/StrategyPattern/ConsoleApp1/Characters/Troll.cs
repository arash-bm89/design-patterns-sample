using StrategyPattern.Abstractions;
using StrategyPattern.Behaviors;

namespace StrategyPattern.Characters
{
    public class Troll : Character
    {
        protected override IWeaponBehavior WeaponBehavior { get; set; } = new BowAndArrowBehavior();

    }
}
