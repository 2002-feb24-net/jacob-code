using System;
namespace Matrices
{
    class Matrix
    {
        int[][] firstMatrix;
        int[][] secondMatrix;

        int _rows;

        public int Rows
        {
            get 
            {
                return _rows; 
            }
            set
            {
                int incomingValue = value;
            }
        }
        //field(s)
        // how will we store the data of this matrix

        // methods
        // 1. some way to fill in the data

        // 2. some common matrix operations
        //
        public int[][] matrixConverter(string input)
        {
            string[] matrix = input.Split(','); //split the input into rows
            string[][] tempMatrix = new string[matrix.Length][];
            int[][] intMatrix = new int[matrix.Length][];
            for (int i = 0; i < matrix.Length; i++)
            {
                tempMatrix[i] = matrix[i].Split(' '); //split spaces for the columns
            }
            string temp = "";
            for (int i = 0; i < tempMatrix[0].Length; i++)
            {
                intMatrix[i] = new int[matrix.Length];
                for (int a = 0; a < tempMatrix.Length; a++)
                {
                    temp = tempMatrix[i][a];
                    intMatrix[i][a] = int.Parse(temp);  //Convert string array to int array
                    //Console.Write(intMatrix[i][a]);
                }
            }
            return intMatrix;
        }
        public void matrixSubtract(int[][] firstMatrix,int[][] secondMatrix)
        {
            Console.WriteLine("Subtracting Matrices:");
            int[][] intMatrix = new int[firstMatrix.Length][];
            for (int i = 0; i < firstMatrix[0].Length; i++)
            {
                for (int a = 0; a < firstMatrix.Length; a++)
                {
                    intMatrix[i] = new int[firstMatrix.Length];
                    intMatrix[i][a] = firstMatrix[i][a] - secondMatrix[i][a];
                    Console.Write(intMatrix[i][a] + " ");
                }
                Console.WriteLine();
            }
        }
        public void matrixAdd(int[][] firstMatrix,int[][] secondMatrix)
        {
            Console.WriteLine("Adding Matrices:");
            int[][] intMatrix = new int[firstMatrix.Length][];
            for (int i = 0; i < firstMatrix[0].Length; i++)
            {
                for (int a = 0; a < firstMatrix.Length; a++)
                {
                    intMatrix[i] = new int[firstMatrix.Length];
                    intMatrix[i][a] = firstMatrix[i][a] + secondMatrix[i][a];
                    Console.Write(intMatrix[i][a] + " ");
                }
                Console.WriteLine();
            }
        }
        public void matrixNegation(int[][] firstMatrix)
        {
            Console.WriteLine("Negation of first array:");
            int[][] intMatrix = new int[firstMatrix.Length][];
            for (int i = 0; i < firstMatrix[0].Length; i++)
            {
                for (int a = 0; a < firstMatrix.Length; a++)
                {
                    intMatrix[i] = new int[firstMatrix.Length];
                    intMatrix[i][a] = firstMatrix[i][a] * (-1);
                    Console.Write(intMatrix[i][a] + " ");
                }
                Console.WriteLine();
            }
        }
        public void matrixMultiplication(int[][] firstMatrix,int[][] secondMatrix)
        {
            Console.WriteLine("Multiplying Matrices:");
            int[][] intMatrix = new int[firstMatrix.Length][];
            int runningTotal;
            int counter = 0;
            for (int i = 0; i < firstMatrix[0].Length; i++)
            {
                runningTotal=0;
                intMatrix[i] = new int[firstMatrix.Length];
                while(counter<firstMatrix[0].Length)
                {
                    for (int a = 0; a < firstMatrix.Length; a++)
                    {
                        runningTotal += firstMatrix[a][counter] * secondMatrix[i][a];
                        Console.Write(intMatrix[i][a] + " ");
                    }
                    intMatrix[i][counter] = runningTotal;
                    Console.Write(intMatrix[i][counter] + " ");
                    counter++;
                }
                counter = 0;
                //intMatrix[i][0] = runningTotal;
                Console.WriteLine();
            }
        }
        public void matrixTransposer(int[][] firstMatrix)
        {
            Console.WriteLine("Adding Matrices:");
            int[][] intMatrix = new int[firstMatrix.Length][];
            for (int i = 0; i < firstMatrix[0].Length; i++)
            {
                for (int a = 0; a < firstMatrix.Length; a++)
                {
                    intMatrix[i] = new int[firstMatrix.Length];
                    intMatrix[i][a] = firstMatrix[a][i];
                    Console.Write(intMatrix[i][a] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}