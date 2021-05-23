using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptimizationMethodsCP.Entities
{
    public static class OptimizationTask
    {
        public static double T1_min { set; get; }
        public static double T2_min { set; get; }
        public static double T1_max { set; get; }
        public static double T2_max { set; get; }
        public static string solution_target { get; set; }
        public static bool is_max { get; set; }
        public static double diffenition { get; set; }
        public static string solution_method { get; set; }
        public static double graph_diffenition { get; set; }
        public class point
        {
            public double t1_value;
            public double t2_value;
            public double f_value;
        }
    }
}
