using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dssem
{
    class DSSM

    {
        public Memory[] codeSegment = new Memory[16];
        public Memory[] dataSegment = new Memory[16];
        public Memory[] stackSegment = new Memory[8];
       public Register PC = new Register("0000",4);
        public Register DR = new Register("0000", 4);
        public Register IR = new Register("0000", 9);
        public Register AC = new Register("0000", 4);
        public Register AR = new Register("0000", 4);
        public Register INPR = new Register("0000", 8);
        public Register SP = new Register("0000", 3);

        public int E = 0;
        public int SC = 0;
        public int S = 0;
        public string I = "0";
        public int FGI = 0;
       
        


        public Dictionary<string, string> labelTable = new Dictionary<string, string>();

        //memory , opcode tablosu, register arrayı
        //programın ana classı

        public DSSM()
        {
            Memory.initdic();
          

        }
        public void initPC(string value)
        {
            PC.Load(value);
        }
        

        public void fetch()
        {
            IR.Load(PC.getData());
        }
        public string decode()
        {
            PC.Increment();
            I = (IR.getData()).Substring(0, 1);
            AR.Load((IR.getData()).Substring(4, 4));
            return (IR.getData()).Substring(1, 3);


        }
       //Memory Reference
        public void memoryOR()
        {
           // DR.Load(dataSegment);
        
        }


    }
}
