namespace Task_8
{
    internal class Program
    {
        private static int _buffer = 1;
        private static double _bufferDouble = 1.1d;
        private static float _bufferFloat = 1.1f;
        private static char _bufferChar = '1';
        private static string _bufferString = "1";
        private static bool _bufferBool = false;
        static void Main(string[] args)
        {
            var buf = (int)_bufferDouble;
            Console.WriteLine(buf);
        }
    }
}
