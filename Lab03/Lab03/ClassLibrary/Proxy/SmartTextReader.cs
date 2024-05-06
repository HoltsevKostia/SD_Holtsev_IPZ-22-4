
namespace ClassLibrary.Proxy
{
    public class SmartTextReader : ITextReader
    {
        public string[,] ReadText(string filePath)
        {
            string[] lines = File.ReadAllLines(filePath);
            string[,] textArray = new string[lines.Length, lines[0].Length];

            for (int i = 0; i < lines.Length; i++)
            {
                char[] chars = lines[i].ToCharArray();
                for (int j = 0; j < chars.Length; j++)
                {
                    textArray[i, j] = chars[j].ToString();
                }
            }

            return textArray;
        }
    }
}
