using Microsoft.VisualStudio.TestTools.UnitTesting;
using RacingAssignNw;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RacingAssignNw.Tests
{
    [TestClass()]
    public class mainTests
    {
        [TestMethod()]
        public void mainTest()
        {
            better_Rohan better_Rohan = new better_Rohan(1, 10, 100);

            if (better_Rohan.rohan_Budget(1)==110)
            {
                Assert.IsTrue(true);
            }
            else {
                Assert.IsTrue(false);
            }
        }

        [TestMethod()]
        public void mainTest1()
        {
            better_Chris better_Chris = new better_Chris(1, 10, 100);

            if (better_Chris.chris_Budget(2)==90)
            {
                Assert.IsTrue(true);
            }
            else
            {
                Assert.IsTrue(false);
            }
        }
    }
}