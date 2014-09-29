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
            var para = 100;
            var testMS = string.Empty;
            //in stimsContext the test function of ShimstaticTest will behave as follow
            using (ShimsContext.Create())
            {
                //redefine the action that test function of ShimstaticTest will be done
                mockAndShim.Fakes.ShimstaticTest.testInt32 = (b) =>
                    {
                        var res = b.ToString() + "haha";
                        return res;
                    };

                testMS = test.testMock(para);
                Console.WriteLine(testMS);

                Assert.AreEqual(testMS, para.ToString() + "haha");
            }

            //out of stimsContext the test function of ShimstaticTest will behave as nomal
            testMS = test.testMock(para);
            Console.WriteLine(testMS);
        }
    }
}
