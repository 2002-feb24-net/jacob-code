using System;

namespace MultiArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // you make an array that would contain any type
            // you can make an array of arrays

            // for example, for two dimensional image data
            string[][] image = new string[4][];
            image[0] = new string[] { "black", "black", "black", "black"};
            image[1] = new string[] { "black", "red", "red", "black"};
            image[2] = new string[] { "black", "red", "red", "black"};
            image[3] = new string[] { "black", "black", "black", "black"};
            string topRightCorner = image[0][3];

            //Jagged of array (array of array)
            string[][] secondImage = new string[4][];
            //string[][] secondImage = new string[4][3]; this doesnt work
            secondImage[0] = new string[3];
            secondImage[1] = new string[3];
            secondImage[2] = new string[3];
            secondImage[3] = new string[3];

            // rectangular multi dimensional array
            string[,] image = new string[4,4]
            {
            { "black", "black", "black", "black"},
            { "black", "red", "red", "black"},
            { "black", "red", "red", "black"},
            { "black", "black", "black", "black"}
            };
            string topRightCorner2 = image[0,3];


        }
    }
}
