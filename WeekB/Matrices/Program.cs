using System;

namespace Matrices
{
    class Program
    {
        static void Main(string[] args)
        {
            Matrix matrix = new Matrix();
            Console.WriteLine("Enter Matrix: ");
            Console.WriteLine("e.g. 2 3,4 0");
            string input = Console.ReadLine();
            int[][] firstMatrix = matrix.matrixConverter(input);
            Console.WriteLine("Enter Second Matrix: ");
            Console.WriteLine("e.g. 2 3,4 0");
            input = Console.ReadLine();
            int[][] secondMatrix = matrix.matrixConverter(input);
            if(firstMatrix.Length != secondMatrix.Length || firstMatrix[0].Length != secondMatrix[0].Length)
            {
                Console.WriteLine("Error: Matrix dimensions do not match! ");
            }
            matrix.matrixSubtract(firstMatrix,secondMatrix);
            matrix.matrixAdd(firstMatrix,secondMatrix);
            matrix.matrixNegation(firstMatrix);
            matrix.matrixTransposer(firstMatrix);
            matrix.matrixMultiplication(firstMatrix,secondMatrix);
        }
    }
}
