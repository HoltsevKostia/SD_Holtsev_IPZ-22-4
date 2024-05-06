
namespace ClassLibrary.Decorator
{
    public class Warrior : IHero
    {
        public string Name { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }

        public Warrior()
        {
            Name = "Warrior";
            Attack = 10;
            Defense = 5;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Attack: {Attack}, Defense: {Defense}");
        }
    }
}
