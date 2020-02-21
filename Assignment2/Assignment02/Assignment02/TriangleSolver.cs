using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02
{
    static class TriangleSolver
    {
        public static string Analyze(int sideA, int sideB, int sideC)
        {
            string output = String.Empty;
            /*
             * triangle is valis when
             * sideA + sideB > sideC
             * sideA + sideC > sideB
             * sideB + sideC > sideA
            */
            if((sideA + sideB > sideC) &&
               (sideA + sideC > sideB) &&
               (sideB + sideC > sideA))
            {
                //equilateral check -> all sides are equal
                if(sideA == sideB && 
                   sideB == sideC)
                {
                    output = "Equilateral Triangle";
                }
                //scalene triangle check -> all sides are different
                else if(sideA != sideB && 
                        sideA != sideC &&
                        sideB != sideC)
                {
                    output = "Scalene Triangle";
                }
                //isosceles triangle check -> two of the sides are same
                else if (sideA == sideB || 
                        sideA == sideC ||
                        sideB == sideC)
                {
                    output = "Isosceles Triangle";
                }
            }
            else
            {
                output = "Dimensions don't compose a triangle";
            }
            return output;
        }
    }
}
