using StrategyPattern.Abstractions;
using StrategyPattern.Behaviors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Characters
{
    public class Knight : Character
    {
        protected override IWeaponBehavior WeaponBehavior { get; set; } = new SwordBehavior();

    }
}
