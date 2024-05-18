
namespace ClassLibrary.Extensions
{
    public static class ConsoleExtensions
    {
        public static void ConsoleWriteSlowly(this string text, int delayMilliseconds = 80)
        {
            foreach (char c in text)
            {
                Console.Write(c);
                Thread.Sleep(delayMilliseconds);
            }
        }

        public static void ConsoleWriteLineSlowly(this string text, int delayMilliseconds = 80)
        {
            text.ConsoleWriteSlowly(delayMilliseconds);
            Console.WriteLine();
        }
    }
}
