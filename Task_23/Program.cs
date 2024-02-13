namespace Task_23
{
    using System;

    class Point
    {
        protected double x, y, z;

        public void SetOptions(double x = 0.0, double y = 0.0, double z = 0.0)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public void PrintCoordinates()
        {
            Console.WriteLine($"Coordinates: ({x}, {y}, {z})");
        }
    }

    class Pentagon : Point
    {
        private double[] angles;

        public Pentagon(double x = 0.0, double y = 0.0, double z = 0.0)
        {
            SetOptions(x, y, z);
            angles = new double[5];
        }

        public void SetPentagonAngles(params double[] pentagonAngles)
        {
            if (pentagonAngles.Length == 5)
            {
                angles = pentagonAngles;
            }
            else
            {
                Console.WriteLine("Error: Pentagon should have exactly 5 angles.");
            }
        }

        public void PrintPentagonDetails()
        {
            PrintCoordinates();
            Console.Write("Pentagon Angles: ");
            foreach (double angle in angles)
            {
                Console.Write(angle + " ");
            }
            Console.WriteLine();
        }
    }

    class Program
    {
        static void Main()
        {
            Pentagon pentagon = new Pentagon();
            pentagon.SetOptions(1.0, 2.0, 3.0);
            pentagon.SetPentagonAngles(90.0, 108.0, 108.0, 108.0, 108.0);
            pentagon.PrintPentagonDetails();
        }
    }

}
