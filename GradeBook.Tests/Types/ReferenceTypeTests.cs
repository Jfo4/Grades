using Grades;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace GradesBookTestsTypes
{
    [TestClass]
    public class TypeTests
    {
        [TestMethod]
        public void IntVariablesHoldAValue()
        {
            int x1 = 100;
            int x2 = x1;

            x1 = 4;
            Assert.AreEqual(x1, x2);
        }
        [TestMethod]
        public void GradeBookVariablesHoldAReference()
        {
            GradeBook g1 = new GradeBook();
            GradeBook g2 = g1;

            //g1 = new GradeBook();
            g1.Name = "sdf";
            Assert.AreEqual(g1.Name, g2.Name);
        }

    }
}
