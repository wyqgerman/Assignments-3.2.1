namespace Assignments_3._2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = {
            { 2, 3, 4 },
            { 1, 4, 6 }
        };

            PrintMatrix(matrix);
        }

        static void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                Console.Write("| ");

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " | ");
                }

                Console.WriteLine(); 
            }
        }
    }
}
