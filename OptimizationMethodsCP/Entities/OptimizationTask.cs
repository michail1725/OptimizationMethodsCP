using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptimizationMethodsCP.Entities
{
    public static class OptimizationTask
    {
        public static float T1_min { set; get; }
        public static float T2_min { set; get; }
        public static float T1_max { set; get; }
        public static float T2_max { set; get; }
        public static string solution_target { get; set; }
        public static bool is_max { get; set; }
        public static float diffenition { get; set; }
        public static string solution_method { get; set; }
        public class point
        {
            public float t1_value;
            public float t2_value;
            public float f_value;
        }
    }
}
