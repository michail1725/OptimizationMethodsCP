using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using OptimizationMethodsCP.Entities;
using OptimizationMethodsCP.UsersForms;


namespace OptimizationMethodsCP.Methods
{
    public static class Scaning
    {
        public static List<OptimizationTask.point> points = new List<OptimizationTask.point>();
        public static OptimizationTask.point p_max = new OptimizationTask.point();
        public static OptimizationTask.point p_min = new OptimizationTask.point();
        public static DataTable dt;
        
        public static void Body() {
            int dc_dig = GetDecimalDigitsCount(OptimizationTask.diffenition);
            dt = new DataTable();
            dt.Columns.Add("T1");
            dt.Columns.Add("T2");
            dt.Columns.Add("F");
            dt.Columns[0].DataType = Type.GetType("System.Decimal");
            dt.Columns[1].DataType = Type.GetType("System.Decimal");
            dt.Columns[2].DataType = Type.GetType("System.Decimal");
            for (float i = OptimizationTask.T1_min;i <= OptimizationTask.T1_max; i += OptimizationTask.diffenition) {
                i = (float)Math.Round(i, dc_dig);

                for (float j = OptimizationTask.T2_min; j <= OptimizationTask.T2_max; j += OptimizationTask.diffenition) {
                    j = (float)Math.Round(j, dc_dig);
                    if (!Variant11_math.IsLimit(i, j)) {
                        float result = Variant11_math.GetFunctionValue(i, j);
                        //if (result > 0)
                        //{
                            OptimizationTask.point point = new OptimizationTask.point();
                            point.t1_value = i;
                            point.t2_value = j;
                            point.f_value = (float)Math.Round(result, dc_dig);
                            points.Add(point);
                        dt.Rows.Add(point.t1_value, point.t2_value, point.f_value);
                        //}

                    }
                }    
            }
            
            p_max.f_value = points[0].f_value;
            p_min.f_value = points[0].f_value;
            foreach (OptimizationTask.point p in points) {
                if (p.f_value > p_max.f_value) {
                    p_max = p;
                }
                else if (p.f_value < p_min.f_value) {
                    p_min = p;
                }
            }
        }
        static int GetDecimalDigitsCount(float value)
        {
            string[] str = value.ToString(new System.Globalization.NumberFormatInfo() { NumberDecimalSeparator = "." })
               .Split('.');
            return str.Length == 2 ? str[1].Length : 0;
        }
    }
}
