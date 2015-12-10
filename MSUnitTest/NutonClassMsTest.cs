using System;
using Logic;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSUnitTest
{
    [TestClass]

    public class NutonClassMsTest
    {

        [TestMethod]
        public void RootMethod_MathPowChecking()
        {
            //Asrage
            double number = 100;
            int n = 2;
            double prec = 0.0000001;
            //Actual
            double act = NutonClass.Root(number, n, prec);
            //Expected
            double exp = Math.Pow(number, 1.0 / n);
            //Assert
            Assert.AreEqual(10, act);
        }
        [TestMethod]
        public void RootMethod_PrecisionMoreThan1()
        {
            //Asrage
            double number = 100;
            int n = 2;
            double prec = 2;
            //Actual
            double act = NutonClass.Root(number, n, prec);
            //Expected
            double exp = Math.Pow(number, 1.0 / n);
            //Assert
            Assert.AreEqual(10, act);
        }

    }
}
