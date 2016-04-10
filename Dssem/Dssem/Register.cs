﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dssem
{
    class Register
    {

        //base class for registers
        string data;
        int size;// kaç bit
        public Register(string data, int size)
        {
            this.size = size;
            Load(data);
        }
        public void Load(string data)
        {
            if (data.Length > size)
            {
                this.data = data.Substring(data.Length - size, size - 1);
            }
            else {
                this.data = Util.expandBit(data, size);
            }

        }

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
        public void Clear()
        {
            data = Util.expandBit("0", size);
        }
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
        public string getData()
        {
            return data;
        }
        public int getDataInt()
        {
            return Convert.ToInt32(Util.convert(data, "BIN", "DEC"));
        }
        public void ASHR()
        {
            string result = "";
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

        }
        public void ASHL()
        {

            string result = "";
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


        }
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
