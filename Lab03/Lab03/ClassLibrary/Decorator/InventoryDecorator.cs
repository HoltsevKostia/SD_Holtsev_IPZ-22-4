
namespace ClassLibrary.Decorator
{
    public abstract class InventoryDecorator : IHero
    {
        protected IHero _hero;

        public string Name { get => _hero.Name; set => _hero.Name = value; }
        public int Attack { get => _hero.Attack; set => _hero.Attack = value; }
        public int Defense { get => _hero.Defense; set => _hero.Defense = value; }

        public InventoryDecorator(IHero hero)
        {
            _hero = hero;
        }

        public virtual void DisplayInfo()
        {
            _hero.DisplayInfo();
        }
    }
}
