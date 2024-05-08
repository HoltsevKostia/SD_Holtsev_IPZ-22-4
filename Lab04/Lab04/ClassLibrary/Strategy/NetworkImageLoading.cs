
namespace ClassLibrary.Strategy
{
    public class NetworkImageLoading : IImageLoading
    {
        public void LoadImage(string href)
        {
            Console.WriteLine($"Завантаження зображення з мережi: {href}");
        }
    }
}
