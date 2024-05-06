
namespace ClassLibrary.Decorator
{
    public interface IHero
    {
        string Name { get; set; }
        int Attack { get; set; }
        int Defense { get; set; }
        void DisplayInfo();
    }
}
