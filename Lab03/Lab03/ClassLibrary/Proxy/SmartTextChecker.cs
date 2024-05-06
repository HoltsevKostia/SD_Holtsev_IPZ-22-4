using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Proxy
{
    public class SmartTextChecker : ITextReader
    {
        private SmartTextReader _textReader;

        public SmartTextChecker()
        {
            _textReader = new SmartTextReader();
        }

        public string[,] ReadText(string filePath)
        {
            Console.WriteLine($"Opening file: {filePath}");
            string[,] textArray = _textReader.ReadText(filePath);
            Console.WriteLine($"File read successfully. Total lines: {textArray.GetLength(0)}, Total characters: {textArray.Length}");
            Console.WriteLine($"Closing file: {filePath}");
            return textArray;
        }
    }
}
