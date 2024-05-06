﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Adapter
{
    public class FileWriter : IFileWriter
    {
        public void Write(string message)
        {
            // Логіка запису в файл
            Console.WriteLine($"Writing to file: {message}");
        }

        public void WriteLine(string message)
        {
            // Логіка запису в файл з новим рядком
            Console.WriteLine($"Writing to file (new line): {message}");
        }
    }
}
