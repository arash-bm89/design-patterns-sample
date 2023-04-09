using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StrategyPattern.Abstractions;
using StrategyPattern.Behaviors;

namespace StrategyPattern.Characters
{
    public class King : Character
    {
        protected override IWeaponBehavior WeaponBehavior { get; set; } = new AxeBehavior();
    }
}
