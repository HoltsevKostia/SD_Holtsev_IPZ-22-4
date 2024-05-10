using ClassLibrary.LightHTML;

namespace ClassLibrary.LightHTML
{
    public class LightHTMLFactory
    {
        public LightNode GetNode(string text, bool isFirstLine)
        {
            if (string.IsNullOrWhiteSpace(text))
            {
                return null;
            }

            if (isFirstLine)
            {
                return new LightHeaderNode(text.Trim(), 1);
            }
            else if (text.Length < 20)
            {
                return new LightHeaderNode(text.Trim(), 2);
            }
            else if (text.StartsWith(" "))
            {
                return new LightBlockquoteNode(text.Trim());
            }
            else
            {
                return new LightTextNode(text.Trim());
            }
        }
    }
}
