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
            IR.Load(codeSegment[PC.getDataInt()].i+ codeSegment[PC.getDataInt()].opcode+ codeSegment[PC.getDataInt()].data);
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
        {   //OR
           DR.Load(dataSegment[AR.getDataInt()].data);//D1T3
           AC.Load(Util.convert(Convert.ToString(AC.getDataInt() | DR.getDataInt()),"DEC","BIN"));
           SC = 0; //D1T4
            //AND
           DR.Load(dataSegment[AR.getDataInt()].data);//D2T3
           AC.Load(Util.convert(Convert.ToString(AC.getDataInt() & DR.getDataInt()), "DEC", "BIN"));
           SC = 0; //D2T4
            //XOR
           DR.Load(dataSegment[AR.getDataInt()].data);//D3T3
           AC.Load(Util.convert(Convert.ToString(AC.getDataInt() ^ DR.getDataInt()), "DEC", "BIN"));
           SC = 0; //D3T4
            //ADD
           DR.Load(dataSegment[AR.getDataInt()].data);//D4T3
           AC.Load(Util.convert(Convert.ToString(AC.getDataInt() + DR.getDataInt()), "DEC", "BIN"));
           SC = 0; //D4T4
            //CDA
           DR.Load(dataSegment[AR.getDataInt()].data);//D5T3
           AC.Load(DR.getData());
           SC = 0;//D5T4
            //STA
           dataSegment[AR.getDataInt()].data = AC.getData();
           SC = 0;//D6T3
            //BUN
           PC.Load(AR.getData());
           SC = 0;//D8T3
            //BSA
           dataSegment[AR.getDataInt()].data = PC.getData();
           AR.Increment();//D9T3
           PC.Load(AR.getData()); SC = 0;//D9T4
            //ISZ
           DR.Load(dataSegment[AR.getDataInt()].data);//D15T3
           DR.Increment();//D15T4
           dataSegment[AR.getDataInt()].data = DR.getData();
           if (DR.getData() == "000000000")
           {
               PC.Increment();
           }
           SC = 0;
            //D15T5


        
        }


    }
}
