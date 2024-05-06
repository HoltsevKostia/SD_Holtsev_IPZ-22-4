using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ClassLibrary.Proxy
{
    public class SmartTextReaderLocker : ITextReader
    {
        private readonly SmartTextReader _textReader;
        private readonly Regex _fileRegex;

        public SmartTextReaderLocker(string filePattern)
        {
            _textReader = new SmartTextReader();
            _fileRegex = new Regex(filePattern);
        }

        public string[,] ReadText(string filePath)
        {
            if (_fileRegex.IsMatch(filePath))
            {
                Console.WriteLine("Access denied!");
                return null;
            }
            else
            {
                return _textReader.ReadText(filePath);
            }
        }
    }
}
