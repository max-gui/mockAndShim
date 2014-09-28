using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using processConsole;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.QualityTools.Testing.Fakes;
namespace processConsole.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void testMockTest()
        {
            using(ShimsContext.Create())
            {
                mockAndShim.Fakes.ShimstaticTest.testInt32 = (b) =>
                    {
                        var res = b.ToString() + "haha";
                        return res;
                    };

                var para = 100;
                var testMS = test.testMock(para);
                Console.WriteLine(testMS);

                Assert.AreEqual(testMS, para.ToString() + "haha");
            }
        }
    }
}
