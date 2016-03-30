using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dssem
{
    public class Memory
    {
        public string i;
        public string opcode;
        public string data;
        /*
        public Memory(string i, string opcode,string data)
        {
            this.i = i;
            this.opcode = opcode;
            this.data = data;

        }*/

        public string ToString()
        {
            return i + opcode + data;
        }
        

    }
}
