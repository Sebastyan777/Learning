namespace Task_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Example("Hello", "World");
        }

        private static void Example(string line1, string line2)
        {
            Console.WriteLine($"{line1} {line2}");
            Example(line1);
        }

        private static void Example(string line1)
        {
            Console.WriteLine($"{line1}");
        }

        private static string Example(string line1, string line2, string line3)
        {
            return line1 + line2 + line3;
        }
    }
}
