using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YPK
{
    public class Calculation
    {
        private Int64 aparameter;
        private Int64 bparameter;
        private Int64 cparameter;
        public void Calculate()
        {
           Int64 a = aparameter;
           Int64 b = bparameter;
           Int64 c = cparameter;
            if (b == 0)
            {
                answer1 = Math.Sqrt(c / a);
                answer2 = answer1 * (-1);
                return;
            }
            if (a == 0)
            {
                answer1 = c / b;
                answer2 = 0;
                return;
            }
            if (c == 0)
            {
                answer1 = 0;
                answer2 = b / a;
                return;
            }
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
        public Int64 Aparemeter
        {
            get
            {
                return aparameter;
            }
            set
            {
                aparameter = value;
            }
        }

        public Int64 Bparemeter
        {
            get
            {
                return bparameter;
            }
            set
            {
                bparameter = value;
            }
        }

        public Int64 Cparemeter
        {
            get
            {
                return cparameter;
            }
            set
            {
                cparameter = value;
            }
        }
        public bool Abequation
        {
            get;set;
        }
    }
}
