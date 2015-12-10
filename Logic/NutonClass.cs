using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class NutonClass
    {
        public static double Root(double number, int n, double prec)
        {
            double A1 = number / 2;
            double result = 0;
            double precResult = 1;

            if (number<0 && n % 2==0)
            {
                throw new Exception();
            }
            if(prec>1)
            {
                throw new Exception();
            }
            if(prec<=0)
            {
                throw new Exception();
            }
            if(n==0)
            {
                return 1;
            }
            if(number==0)
            {
                throw new Exception();
            }
            else 
            {
                if (n < 0)
                {
                    number = 1 / number;
                    n = n * -1;
                }
                while (Math.Abs(precResult) > prec)
                    {
                        result = ((n - 1) * A1 + (number / Math.Pow(A1, n - 1))) / n;
                        precResult = A1 - result;
                        A1 = result;
                    }
                    return result;
                }

        }

        }
    }

