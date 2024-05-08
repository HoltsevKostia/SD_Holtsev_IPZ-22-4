
namespace ClassLibrary.Strategy
{
    public class Image
    {
        private IImageLoading _loading;

        public Image(IImageLoading loadingStrategy)
        {
            _loading = loadingStrategy;
        }

        public void SetLoadingStrategy(IImageLoading loadingStrategy)
        {
            _loading = loadingStrategy;
        }

        public void Load(string href)
        {
            _loading.LoadImage(href);
        }
    }
}
