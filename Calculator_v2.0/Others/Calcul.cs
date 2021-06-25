using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_v2._0.Others
{
    public class Calcul
    {

        public static double Pow(double var1, double var2)
        {
            return (Math.Pow(var1, var2));
        }


        public static string Divide(string var1, string var2)
        {
            double num1 = Convert.ToDouble(var1);
            double num2 = Convert.ToDouble(var2);

            if ((num2 != 0))
            {
                return Convert.ToString((num1 / num2));
            }
            else if (num2 == 0)
            {
                return "Ошибка";
            }
            return "";
        }

        public static double Multiply(double var1, double var2)
        {
            return (var1 * var2);
        }

        public static double Minus(double var1, double var2)
        {
            return (var1 - var2);
        }

        public static double Plus(double var1, double var2)
        {
            return (var1 + var2);
        }
    }
}
