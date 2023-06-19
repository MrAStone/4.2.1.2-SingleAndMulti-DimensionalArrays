using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._2._1._2_SingleAndMulti_DimensionalArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] basicArray = new string[10]; //array with 10 index locations
            basicArray[0] = "Start";
            basicArray[9] = "End";
            basicArray[basicArray.Length - 1] = "This is also the end";
            Console.WriteLine(basicArray[0]);
            for (int i = 0; i < basicArray.Length; i++)
            {
                Console.WriteLine(basicArray[i]);
            }
            string[] anotherArray = { "This", "Has", "Values", "Added", "At", "Time", "of", "Creation" };
            for (int i = 0; i < anotherArray.Length; i++)
            {
                Console.Write(anotherArray[i] + " ");
            }
            Console.WriteLine();
            int[] vectorArray = { 1, 2 };

            int[,] twoDArray = { { 1, 2 }, { 3, 4 }, { 5, 6 } }; // an array containing an array in each index
            Console.WriteLine(twoDArray[0, 0]); // array 0, index 0 = 1
            Console.WriteLine(twoDArray[1, 0]); // array 1, index 0 = 3
            Console.WriteLine(twoDArray[2, 1]); // array 2, index 1 = 6
            char[,] gameBoard = new char[8, 8]; // and 8 by 8 2D array
            string[,,] threeDArray = { { { "A", "B" }, { "B", "C" }, { "C", "D" } }, { { "D", "E" }, { "E", "F" }, { "F", "G" } } };

            Console.WriteLine("i j k Value");
            for (int i = 0; i < threeDArray.GetLength(0); i++)
            {
                for (int j = 0; j < threeDArray.GetLength(1); j++)
                {
                    for (int k = 0; k < threeDArray.GetLength(2); k++)
                    {
                        Console.WriteLine($"{i} {j} {k} {threeDArray[i, j, k]} ");
                    }
                }
            }
        }
    }
}
