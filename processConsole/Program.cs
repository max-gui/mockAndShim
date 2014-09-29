using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace processConsole
{
    public class test
    {
        static public string testMock(int para)
        {
            var res = mockAndShim.staticTest.test(para);
            return res;
        }
    }

    class Program
    {
        static public int Main()
        {
            return 0;
        }
    }
}
