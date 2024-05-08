
namespace ClassLibrary.Strategy
{
    public class FilesystemImageLoading : IImageLoading
    {
        public void LoadImage(string href)
        {
            Console.WriteLine($"Завантаження зображення з файлової системи: {href}");
        }
    }
}
