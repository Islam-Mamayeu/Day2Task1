using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logic;
using NUnit.Framework;

namespace Logic.NUnitTests
{
    [TestFixture]
    public class NutonClassTest
    {

        [TestCase(100, 2, 0.001, Result = true)]
        [TestCase(100, -2, 0.001, Result = true)]
        [TestCase(100, 0, 0.001, Result = true)]

        [TestCase(100, 2, 5, ExpectedException = typeof(Exception))]
        [TestCase(100, 2, -5, ExpectedException = typeof(Exception))]
        [TestCase(100, 2, 0, ExpectedException = typeof(Exception))]
        [TestCase(-100, 2, 0.001,ExpectedException = typeof(Exception))]
        [TestCase(0, 2, 0.001, ExpectedException = typeof(Exception))]

        [TestCase(double.MaxValue, int.MaxValue, 0.001, Result = true)]
        [TestCase(double.MaxValue, int.MaxValue, double.MinValue, Result = true)]


        public bool NutonClassRootMethodTest(double number,int n,double prec)
        {
            double actResult = NutonClass.Root(number,n,prec);
            return (actResult-Math.Pow(number,1.0/ n)<prec);
        }


        [TestCase(-27, 3, 1e-15,Result = -3.0)]
        public double NutonClassRootMethodResultTest(double number, int n, double prec)
        {
            double actResult = NutonClass.Root(number, n, prec);

            return actResult;
        }



    }
}
