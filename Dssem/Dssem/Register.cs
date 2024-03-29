﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dssem
{
    public class Register
    {

        //base class for registers
        string data;
        int size;

        //create a register given size and load given data
        public Register(string data, int size)
        {
            this.size = size;
            Load(data);
        }
        // load given data to register it can expand and decrease to fit data
        public void Load(string data)
        {
            if (data.Length > size)
            {
                this.data = data.Substring(data.Length - size, size);
            }
            else {
                this.data = Util.expandBit(data, size);
            }

        }

        // increments register, if number overflows reset to 0
        public void Increment()
        {
            string number;
            number = Util.convert(data, "BIN", "DEC");
            long num = Convert.ToInt64(number) + 1;
            if (Math.Pow(2, size) < num)
            {
                number = Util.convert(Convert.ToString(num), "DEC", "BIN");
                Load(Util.expandBit("0", size));
            }
            else {
                number = Util.convert(Convert.ToString(num), "DEC", "BIN");
                Load(number);
            }


        }
        //clears register (load with "0")
        public void Clear()
        {
            data = Util.expandBit("0", size);
        }
        // decrement s register
        public void Decrement()
        {
            string number;
            number = Util.convert(data, "BIN", "DEC");
            long num = Convert.ToInt64(number) - 1;
            if (num < 0)
            {
                number = Util.convert(Convert.ToString(num), "DEC", "BIN");
                Load(number.Substring(number.Length - size, number.Length - 1));
            }
            else {
                number = Util.convert(Convert.ToString(num), "DEC", "BIN");
                Load(number);
            }



        }
        //get binary data
        public string getData()
        {
            return data;
        }
        //get integer data
        public int getDataInt()
        {
            return Convert.ToInt32(Util.convert(data, "BIN", "DEC"));
        }

        //shift funtions returns carry
        public int ASHR()
        {
            string result = "";
            string E = data.Substring(data.Length - 1, 1);
            for (int i = 0; i < size; i++)
            {
                if (i == 0)
                {
                    result += data[i];
                }
                else
                {
                    result += data[i - 1];
                }
            }
            Load(result);
            return Convert.ToInt32(E);
        }
        public int ASHL()
        {

            string result = "";
            string E = data.Substring(0, 1);
            for (int i = 0; i < size; i++)
            {
                if (i == data.Length - 1)
                {
                    result += 0;
                }
                else
                {
                    result += data[i + 1];
                }
            }
            Load(result);
            return Convert.ToInt32(E);

        }

        //1's complement
        public void Complement()
        {
            string result = "";
            for (int i = 0; i < size; i++)
            {
                if (data[i] == '0')
                {
                    result += "1";
                }
                else {
                    result += "0";
                }
            }
            Load(result);
        }

    }
}
