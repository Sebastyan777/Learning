using System.Runtime.CompilerServices;

namespace Task_10
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            Point A = new Point();
            A.ReturnToConsolePosition();

            Circle B = new Circle(4, 5, 15);
            B.ReturnToConsolePosition();

            Pentagon C = new Pentagon(7, 2, 8);
            C.ReturnToConsolePosition();
        }
    }
}
