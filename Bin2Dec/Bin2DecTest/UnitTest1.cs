using Bin2Dec_App;
using System;
using Xunit;

namespace Bin2DecTest
{
    public class Bin2Dec
    {
        [Theory]
        [ClassData(typeof(BinarytoDecTestData))]
        public void Test1(int i,int j)
        {
            var Result = Bin2DecConvertor.ConvertBinarytoDecimal(i);
            Assert.Equal(j, Result);
        }
    }
}
