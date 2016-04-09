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
        Register PC;
        Register DR;
        Register IR;
        Register AC;
        Register AR;
        Register INPR;
        Register SP;

        int E;
        int SC;
        int S;
        int I;
        int FGI;
       
        


        public Dictionary<string, string> labelTable = new Dictionary<string, string>();

        //memory , opcode tablosu, register arrayı
        //programın ana classı

        public DSSM()
        {
            Memory.initdic();
        }
        public void initPC(string value)
        {
           
        }
        

        public void fetch()
        {
            
        }
        public void decode()
        {
            
        }


    }
}
