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

        public bool NutonClassRootMethodTest(double number,int n,double prec)
        {
            double actResult = NutonClass.Root(number,n,prec);
            return (actResult-Math.Pow(number,1.0/ n)<prec);
        }



    }
}
