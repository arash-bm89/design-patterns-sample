
using StrategyPattern.Behaviors;
using StrategyPattern.Characters;

var character = new King();

character.Fight();

character.SetWeapon(new SwordBehavior());

character.Fight();