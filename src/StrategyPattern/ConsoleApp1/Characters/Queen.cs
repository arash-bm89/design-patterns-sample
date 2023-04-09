using StrategyPattern.Abstractions;
using StrategyPattern.Behaviors;

namespace StrategyPattern.Characters
{
    public class Queen : Character
    {
        protected override IWeaponBehavior WeaponBehavior { get; set; } = new KnifeBehavior();
    }
}
