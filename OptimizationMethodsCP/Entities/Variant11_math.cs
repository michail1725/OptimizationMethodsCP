using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptimizationMethodsCP.Entities
{
    public  static class Variant11_math
    {
        public static double GetFunctionValue(double T1,double T2) {
            return (T1 - 1000) * Math.Cos(3.14 * 1000 * Math.Sqrt(Math.Pow(T1,2) + Math.Pow(T2,2)));
        }
        public static bool IsLimit(double T1, double T2)
        {
            if (T2 - T1 <= 3)
            {
                return false;
            }
            else {
                return true;
            }
        }
    }
}
