using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dssem
{
    public static class Util
    {
        //sayi çevirme fonksiyonları
        public static string expandBit(string str,int bit)
        {
            string result="";
            for (int i = 0; i < bit-str.Length; i++)
            {
                result += "0";
            }
            return result + str;
        }
        public static string decreaseBit(string str, int bit)
        {
            return str.Substring(str.Length -bit,bit);
        }
        public static string convert(string number, string fromBase, string toBase)
        {
            string result = number;
            if (fromBase == "DEC" && toBase == "BIN")
            {
                result = Convert.ToString(Convert.ToInt32(number, 10), 2);
                result = expandBit(result, 4);
            }
            else if (fromBase == "DEC" && toBase == "HEX")
            {
                result = Convert.ToString(Convert.ToInt32(number, 10), 16);

            }
            else if (fromBase == "DEC" && toBase == "OCT")
            {
                result = Convert.ToString(Convert.ToInt32(number, 10), 8);
            }
            else if (fromBase == "BIN" && toBase == "HEX")
            {
                result = Convert.ToString(Convert.ToInt32(number, 2), 16);
            }
            else if (fromBase == "BIN" && toBase == "DEC")
            {
                result = Convert.ToString(Convert.ToInt32(number, 2), 10);
            }
            else if (fromBase == "BIN" && toBase == "OCT")
            {
                result = Convert.ToString(Convert.ToInt32(number, 2), 8);
            }
            else if (fromBase == "HEX" && toBase == "BIN")
            {
                result = Convert.ToString(Convert.ToInt32(number, 16), 2);
                result = expandBit(result, 4);
            }
            else if (fromBase == "HEX" && toBase == "DEC")
            {
                result = Convert.ToString(Convert.ToInt32(number, 16), 10);
            }
            else if (fromBase == "HEX" && toBase == "OCT")
            {
                result = Convert.ToString(Convert.ToInt32(number, 16), 8);
            }
            else if (fromBase == "OCT" && toBase == "HEX")
            {
                result = Convert.ToString(Convert.ToInt32(number, 8), 16);
            }
            else if (fromBase == "OCT" && toBase == "DEC")
            {
                result = Convert.ToString(Convert.ToInt32(number, 8), 10);
            }
            else if (fromBase == "OCT" && toBase == "BIN")
            {
                result = Convert.ToString(Convert.ToInt32(number, 8), 2);
                result = expandBit(result, 4);
            }


            return result;
        }
        public static int convertSigned(string bin)
        {
            double result = 0;

            for (int i = 0; i < bin.Length; i++)
            {
                if (i == 0)
                {
                    result += (int)Char.GetNumericValue(bin[i]) * (-1) * (Math.Pow(2, bin.Length - 1 - i));

                }
                else
                {

                    result += (int)Char.GetNumericValue(bin[i]) * (Math.Pow(2, bin.Length - 1 - i));
                }

            }
            return Convert.ToInt32(result);
        }
    }
}
