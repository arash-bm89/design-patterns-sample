namespace StrategyPattern.Abstractions
{
    public abstract class Character
    {
        protected abstract IWeaponBehavior WeaponBehavior { get; set; }
        public void Fight()
        {
            WeaponBehavior.UseWeapon();
        }

        public void SetWeapon(IWeaponBehavior weaponBehavior)
        {
            WeaponBehavior = weaponBehavior;
        }
    }
}
