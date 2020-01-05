using System;
using Xunit;
using ConsoleApp1;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Program program = new Program();
            program.SortNamefromFile(@"c:\names.txt");
        }
    }
}
