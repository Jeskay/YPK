using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YPK
{
    public class Calculation
    {
        private double aparameter = 0;
        private double bparameter = 0;
        private double cparameter = 0;
        private int    roots      = 0;
        public string Answer(string Data)
        {
            String number = "";
            Int32 Coefficient = 1;
            Int32 DCoefficeient = 1;
            String S = Data;
            for (Int32 i = 0; i < S.Length; i++)
            {

                if (S[i] == 'x')
                {
                    if (number == "") number = "1";
                    if (i + 2 < S.Length)
                    {
                        if (S[i + 1] == '^' && S[i + 2] == '2')
                        {

                            Aparemeter += Convert.ToDouble(number) * Coefficient;
                            i += 2;
                            number = "";
                        }
                        else
                        {
                            Bparemeter += Convert.ToDouble(number) * Coefficient;
                            number = "";
                        }
                    }
                    else
                    {
                        Bparemeter += Convert.ToDouble(number) * Coefficient;
                        number = "";
                    }
                }
                else if (S[i] == '-')
                {
                    if (number != "") Cparemeter += Convert.ToDouble(number) * Coefficient;
                    Coefficient = -1 * DCoefficeient;
                    number = "";
                }
                else if (S[i] == '+' || S[i] == '=')
                {
                    if (S[i] == '=') DCoefficeient = -1;
                    if (number != "") Cparemeter += Convert.ToDouble(number) * Coefficient;
                    Coefficient = 1 * DCoefficeient;
                    number = "";
                }
                else number += S[i];
            }
            if (number != "") Cparemeter += Convert.ToDouble(number) * Coefficient;

            Console.WriteLine("A= " + Aparemeter);
            Console.WriteLine("B= " + Bparemeter);
            Console.WriteLine("C= " + Cparemeter);
            Calculate();
            
            string answer = "уравнение имеет " + roots + " корней" + '\n';
            if (roots == 1) answer += "x= " + answer1;
            else if (roots == 2) answer += "x1= " + answer1 + '\n' + "x2= " + answer2;
            return answer;
        }
        public void Calculate()
        {
           double a = aparameter;
           double b = bparameter;
           double c = cparameter;
            if (b == 0)
            {
                answer1 = Math.Sqrt(c / a);
                answer2 = answer1 * (-1);
                roots = 2;
                return;
            }
            if (a == 0)
            {
                answer1 = c / b;
                roots = 1;
                return;
            }
            if (c == 0)
            {
                answer1 = 0;
                answer2 = b / a;
                roots = 2;
                return;
            }
            double Desc = Math.Sqrt( b * b - a * c * 4.0);
            if (Desc > 0)
            {
                answer2 = (b * (-1) - Desc) / (2 * a);
                answer1 = (Desc + b * (-1)) / (2 * a);
                roots = 2;
            }
            else if (Desc == 0)
            {
                answer1 = b * (-1) / (2 * a);
                answer2 = 0;
                roots = 2;
            }
            else if (Desc < 0) roots = 0;
        }
        public double answer1
        {
            get;set;
        }
        public double answer2
        {
            get; set;
        }
        public double Aparemeter
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

        public double Bparemeter
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

        public double Cparemeter
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
       
    }
}
