namespace Task_22
{
    internal class Program
    {
        private static int[][] array = new int[3][];

        static void Main()
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new int[3];
                for (int j = 0; j < array[i].Length; j++)
                {
                    array[i][j] = i * 3 + j + 1;
                }
            }

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    Console.Write(array[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
