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

        public static Dictionary<string, string> memoryReference = new Dictionary<string, string>();
        public static Dictionary<string, string> registerReference = new Dictionary<string, string>();
        public static Dictionary<string, string> ioReference = new Dictionary<string, string>();
        public static Dictionary<string, string> stackReference = new Dictionary<string, string>();

        static void fullmemoryRef()
        {
            memoryReference.Add("OR", "0001");
            memoryReference.Add("AND", "0010");
            memoryReference.Add("XOR", "0011");
            memoryReference.Add("ADD", "0100");
            memoryReference.Add("LDA", "0101");
            memoryReference.Add("STA", "0110");
            memoryReference.Add("BUN", "1000");
            memoryReference.Add("BSA", "1001");
            memoryReference.Add("ISZ", "1111");
        }
        static void fullregisterRef()
        {
            registerReference.Add("CLA", "0001");
            registerReference.Add("SZA", "0010");
            registerReference.Add("SNA", "0011");
            registerReference.Add("CMA", "0100");
            registerReference.Add("INC", "0101");
            registerReference.Add("ASHR", "0111");
            registerReference.Add("ASHL", "1000");
            registerReference.Add("SZE", "0000");
            registerReference.Add("HLT", "1001");
        }
        static void fullioRef()
        {
            ioReference.Add("INP", "0111");
        }
        static void fullstackRef()
        {
            stackReference.Add("Push", "0001");
            stackReference.Add("Pop", "0010");
            stackReference.Add("SZEmpty", "0011");
            stackReference.Add("SZFull", "0100");
        }

        public static void initdic()
        {
            fullioRef();
            fullmemoryRef();
            fullregisterRef();
            fullstackRef();
        }

        public Memory(string i, string opcode, string data)
        {
            if (memoryReference.ContainsKey(opcode))
            {
                this.i = i;
                this.opcode = memoryReference[opcode];
                this.data = data;
            }
            else if (registerReference.ContainsKey(opcode))
            {
                this.i = "0";
                this.opcode = "0000";
                this.data = registerReference[opcode];
            }
            else if (ioReference.ContainsKey(opcode))
            {
                this.i = "1";
                this.opcode = "0000";
                this.data = ioReference[opcode];
            }
            else if (stackReference.ContainsKey(opcode))
            {
                this.i = "1";
                this.opcode = "0000";
                this.data = stackReference[opcode];
            }
            else {//data instruction
                this.i = i;
                this.opcode = opcode;
                this.data = data;
            }

        }

        public Memory()
        {
            i = "0";
            opcode = "0000";
            data = "0000";
        }

        public string ToString()
        {
            return i +""+ opcode + "" + data;
        }

        


    }
}
