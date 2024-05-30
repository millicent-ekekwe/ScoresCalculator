using System.Buffers.Text;
using System.Drawing;
using System;
using System.Diagnostics.CodeAnalysis;

namespace CalculateScore
{
    public class Program
    {
        static void Main(string[] args)
        {

            int[] input1 = { 1, 2, 3, 4, 5 };
            int[] input2 = { 15, 25, 35 };
            int[] input3 = { 8, 8 };
            Console.WriteLine(CalculateTotalScore.GetTotalScores(input1));
            Console.WriteLine(CalculateTotalScore.GetTotalScores(input2));
            Console.WriteLine(CalculateTotalScore.GetTotalScores(input3));
        }

       
    }
}
