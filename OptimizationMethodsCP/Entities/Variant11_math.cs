using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptimizationMethodsCP.Entities
{
    public  static class Variant11_math
    {
        public static float GetFunctionValue(float T1,float T2) {
            return (float)(800 * (T1 - 1) * Math.Cos(3.14 * 1* Math.Sqrt(Math.Pow(T1,2) + Math.Pow(T2,2))));
        }
        public static bool IsLimit(float T1, float T2)
        {
            if (T2 - T1 <= 3)
            {
                if (Math.Cos(3.14 * 1 * Math.Sqrt(Math.Pow(T1, 2) + Math.Pow(T2, 2))) < 0) {
                    return false;
                }
                return true;
            }
            else {
                return true;
            }
        }
    }
}
