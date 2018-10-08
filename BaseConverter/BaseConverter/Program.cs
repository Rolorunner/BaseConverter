using System;
using System.Collections.Generic;

namespace BaseConverter
{
    class Program
    {
        static public bool ConvertingFromBaseTen;
        static void Main(string[] args)
        {
            int[] inputs = UserInput();
            int numberBeingConverted = inputs[0];
            int numberBase = inputs[1];
            if (ConvertingFromBaseTen)
            {

            }
        }

        /// <summary>
        /// Asks the user for a number and the base they want to convert to or from.
        /// </summary>
        /// <returns></returns>
        static int[] UserInput()
        {
            Console.WriteLine("enter 1 if your want to convert from base 10, 2 if you want to convert to base 10 n/ and 3 if you want to exit");
            int input = int.Parse(Console.ReadLine());
            switch (input)
            {
                case 1:
                    ConvertingFromBaseTen = true;
                    break;
                case 2:
                    ConvertingFromBaseTen = false;
                    break;
                default:
                    break;
            }

            if (ConvertingFromBaseTen)
            {
                Console.WriteLine("Please enter the number your converting from and what base your converting to on two lines");
                int number = int.Parse(Console.ReadLine());
                int baseConvertTo = int.Parse(Console.ReadLine());
                return new int[] { number, baseConvertTo };
            }
            else
            {
                Console.WriteLine("Please enter the number your converting from its base on two lines");
                int number = int.Parse(Console.ReadLine());
                int baseConvertFrom = int.Parse(Console.ReadLine());
                return new int[] { number, baseConvertFrom };
            }
        }

        static List<double> MainConvertingFromBaseTen(double numberBeingConverted, double BaseBeingConvertedTo)
        {
            List<double> result = new List<double>();
            while(numberBeingConverted > BaseBeingConvertedTo)
            {
                double[] methodResult = DivideAndRemainder(numberBeingConverted, BaseBeingConvertedTo);
                numberBeingConverted = methodResult[0];
                result.Add(methodResult[1]);
            };
            result.Add(numberBeingConverted);
            return result;
        }

        //static double MainConvertingToBaseTen(double numberBeingConverted, double originalBase)
        //{
        //    double result = 0;

        //}

        static double ConverNumberToBaseTen(double number, double originalBase, double power)
        {
            return number * Math.Pow(originalBase, power);
        }

        /// <summary>
        /// Returns the floored result of a division and the remainder of that division
        /// </summary>
        /// <param name="number"></param>
        /// <param name="targetBase"></param>
        /// <returns></returns>
        static double[] DivideAndRemainder(double number, double targetBase)
        {
            double remainder = number % targetBase;
            double divideResult = Math.Floor(number / targetBase);
            return new double[] { divideResult, remainder };
        }
    }
}
