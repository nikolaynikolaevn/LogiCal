using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogiCal
{
    public class Calculator
    {
        public static string BinaryStringToHexString(string binary)
        {
            string eightBits;
            StringBuilder result = new StringBuilder(binary.Length / 8 + 1);
            int mod4Len = binary.Length % 8;
            if (mod4Len != 0) binary = binary.PadLeft(((binary.Length / 8) + 1) * 8, '0');
            for (int i = 0; i < binary.Length; i += 8)
            {
                eightBits = binary.Substring(i, 8);
                result.AppendFormat("{0:X2}", Convert.ToByte(eightBits, 2));
            }
            return result.ToString();
        }
        public static string SmallBinaryToHexString(string binary)
        {
            return Convert.ToInt32(binary, 2).ToString("X");
        }
    }
}
