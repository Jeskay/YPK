using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YPK
{
    public class Calculation
    {
        public void Calculate(Int64 a, Int64 b, Int64 c)
        {
            double Desc = Math.Sqrt( b * b - a * c * 4.0);
            if (Desc > 0)
            {
                answer2 = (b * (-1) - Desc) / (2 * a);
                answer1 = (Desc + b * (-1)) / (2 * a);
                Abequation = true;
            }
            else if (Desc == 0)
            {
                answer1 = b * (-1) / (2 * a);
                answer2 = 0;
                Abequation = true;
            }
            else if (Desc < 0) Abequation = false;
        }
        public double answer1
        {
            get;set;
        }
        public double answer2
        {
            get; set;
        }
        public bool Abequation
        {
            get;set;
        }
    }
}
