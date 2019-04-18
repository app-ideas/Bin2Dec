using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bin2Dec_App
{
    public static class Bin2DecConvertor
    {
        public static int ConvertBinarytoDecimal(int BinaryNumber)
        {
            int[] binarray = BinaryNumber.ToString().Select(o => Convert.ToInt32(o.ToString())).ToArray();

            int i = 0;

            int result = 0;

            for (int j = 0; j < binarray.Length; j++)
            {
                result += binarray[binarray.Length - j - 1] * (int)Math.Pow(2, Convert.ToDouble(j));
            }


            return result;
        }
    }
}
