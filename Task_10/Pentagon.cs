namespace Task_10
{
    internal partial class Program
    {
        public class Pentagon : Point
        {
            public Pentagon(float posX, float posY, float posRadius) : base(posX, posY)
            {
                radius = posRadius;
            }
            public float radius;

            public override void ReturnToConsolePosition()
            {
                Console.WriteLine("Координаты пятиугольника и радиус окружности, в которую он вписан:");
                base.ReturnToConsolePosition();
                Console.WriteLine($"radius: {radius}");
            }
        }
    }
}
