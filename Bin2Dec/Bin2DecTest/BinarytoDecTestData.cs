using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Bin2DecTest
{
   public class BinarytoDecTestData : TheoryData<int, int>
    {
        public BinarytoDecTestData()
        {
            Add(1, 1);
            Add(101101, 45);
            Add(1110011, 115);
            Add(11111111, 255);
            Add(10000111, 135);

        }
    }
}
