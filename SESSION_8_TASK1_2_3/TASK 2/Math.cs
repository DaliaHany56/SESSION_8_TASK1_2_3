using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SESSION_8_TASK1_2_3.TASK_2
{
    public static class Math
    {
        public static double Power_2(double baseNumber)
        {
            return System.Math.Pow(baseNumber, 2);
        }
        public static double Power_n(double baseNumber, double exponent)
        {
            return System.Math.Pow(baseNumber, exponent);
        }
        public static double SquareRoot (double Number )
        {
            return System.Math.Sqrt(Number);
        }
        public static double MaxNumber(double num1  ,double num2)
        {
            return System.Math.Max(num1, num2);
        }
        public static double MinNumber (double num1,double num2)
        {
            return System.Math.Min(num1, num2);
        }
        public static double Absolute(double number)
        {
            return System.Math.Abs(number);
        }

    }
}
