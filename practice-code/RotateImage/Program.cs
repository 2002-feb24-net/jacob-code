// using System;

// namespace RotateImage
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             int[][] array = {
//     { 1,2,3,4 },
//     { 5,6,7,8 },
//     { 9,0,1,2 },
//     { 3,4,5,6 }
//             };
//             Console.WriteLine(RotateImage(array));
//         }
//         int[][] RotateImage(int[][] a)
//         {
//             int[][] b = a;
//             for (int x = 0; x < a.GetLength(0); x++)
//             {
//                 for (int y = 0; y < a.GetLength(1); y++)
//                 {
//                     if(a.GetLength(0)%2!=0||a.GetLength(1)%2!=0)
//                     b[x][y] = a[a.GetLength(0) - y - 1][x];
//                 }
//             }
//             return b;
//         }

//     }
// }
