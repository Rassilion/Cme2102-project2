using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dssem
{
   
    class Instruction
    {
        string i;
        int opcode;
        int data;




        public Dictionary<string, string> memoryReference = new Dictionary<string, string>();
        public Dictionary<string, string> registerReference = new Dictionary<string, string>();
        public Dictionary<string, string> ioReference = new Dictionary<string, string>();
        public Dictionary<string, string> stackReference = new Dictionary<string, string>();

        public void fullmemoryRef()
        {
            memoryReference.Add("OR","0001");
            memoryReference.Add("AND", "0010");
            memoryReference.Add("XOR", "0011");
            memoryReference.Add("ADD", "0100");
            memoryReference.Add("LDA", "0101");
            memoryReference.Add("STA", "0110");
            memoryReference.Add("BUN", "1000");
            memoryReference.Add("BSA", "1001");
            memoryReference.Add("ISZ", "1111");
        }
        public void fullregisterRef()
        {
            registerReference.Add("CLA","0001");
            registerReference.Add("SZA", "0010");
            registerReference.Add("SNA", "0011");
            registerReference.Add("CMA", "0100");
            registerReference.Add("INC", "0101");
            registerReference.Add("ASHR", "0111");
            registerReference.Add("ASHL", "1000");
            registerReference.Add("SZE", "0000");
            registerReference.Add("HLT", "1001");
        }
        public void fullioRef()
        {
            ioReference.Add("INP","0111");
        }
        public void fullstackRef()
        {
            stackReference.Add("Push","0001");
            stackReference.Add("Pop", "0010");
            stackReference.Add("SZEmpty", "0011");
            stackReference.Add("SZFull", "0100");
        }

        public void selectInstruction(string i,string instruction)
        {
            if (memoryReference.ContainsKey(instruction))
            {
                
            }
            else if (registerReference.ContainsKey(instruction))
            {
                
            }
            else if (ioReference.ContainsKey(instruction))
            {

            }
            else if (stackReference.ContainsKey(instruction))
            {

            }
        }

    }
}
