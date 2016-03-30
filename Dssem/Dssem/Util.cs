using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dssem
{
    class Util
    {
        //sayi çevirme fonksiyonları

        public static string Converter(string number, string fromBase, string toBase)
        {
            string result = "";
            if (fromBase == "DEC" && toBase == "BIN")
            {
                result = Convert.ToString(Convert.ToInt32(number, 10), 2);
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
            }


            return result;
        }
    }
}
