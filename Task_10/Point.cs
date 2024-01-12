namespace Task_10
{
    public class Point
    {
        public float x;
        public float y;

        public Point()
        {
            x = 7;
            y = 10;
        }

        public Point(float posX, float posY)
        {
            x = posX;
            y = posY;
        }

        public virtual void ReturnToConsolePosition()
        {
            Console.WriteLine($"x:{x}, y:{y}");
        }
    }
}
