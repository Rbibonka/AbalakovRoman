using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomaMath
{
    public class MathR
    {
        public static double addition(double FirstNumber, double SecondNumber)
        {
            return FirstNumber + SecondNumber;
        }
        public static double difference(double FirstNumber, double SecondNumber)
        {
            return FirstNumber - SecondNumber;
        }
        public static double multiplication(double FirstNumber, double SecondNumber)
        {
            return FirstNumber * SecondNumber;
        }
        public static double division(double FirstNumber, double SecondNumber)
        {
            if (SecondNumber == 0)
            {
                return 0;
            }
            else
            {
                return FirstNumber / SecondNumber;
            }
        }
        public static double areaCircle(double Radius)
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
        public static double areaSquare(double Side)
        {
            return Math.Pow(Side, 2);
        }
        public static double areaParallelogram(double Footing, double Height)
        {
            return Footing * Height;
        }
    }
}
