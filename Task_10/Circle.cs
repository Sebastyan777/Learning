namespace Task_10
{
    public class Circle : Point
    {
        public Circle(float posX, float posY, float posRadius) : base(posX, posY) 
        {
            radius = posRadius;
        }
        public float radius;

        public override void ReturnToConsolePosition()
        {
            base.ReturnToConsolePosition();
            Console.WriteLine($"radius: {radius}");
        }
    }
}
