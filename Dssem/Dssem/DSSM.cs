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
        public Register PC = new Register("0", 4);
        public Register DR = new Register("0", 4);
        public Register IR = new Register("0", 9);
        public Register AC = new Register("0", 4);
        public Register AR = new Register("0", 4);
        public Register INPR = new Register("0", 8);
        public Register SP = new Register("0", 3);


        public int E = 0;
        public int SC = 0;
        public int S = 1;
        public string I = "0";
        public int FGI = 0;
        public int d;
        public int r;
        public int p;
        public int b;




        public Dictionary<string, string> labelTable = new Dictionary<string, string>();

        //memory , opcode tablosu, register arrayı
        //programın ana classı

        public DSSM()
        {
            Memory.initdic();
            for (int i = 0; i < codeSegment.Length; i++)
            {
                codeSegment[i] = new Memory();
            }
            for (int i = 0; i < dataSegment.Length; i++)
            {
                dataSegment[i] = new Memory();
            }
            for (int i = 0; i < stackSegment.Length; i++)
            {
                stackSegment[i] = new Memory();
            }
        }

        public void initPC(string value)
        {
            PC.Load(value);
        }

        public void incSC()
        {
            SC++;
            if (SC == 16)
            {
                SC = 0;
            }
        }

        public string nextInstruction()
        {
            string op = "";
            do
            {
                op += nextMicroOp() + "\n";
            } while (SC != 0);

            return op;
        }

        public string nextMicroOp()
        {
            string op = "";
            if (S == 0)
            {
                op = "HALT";
            }
            else {
                if (SC == 0)
                {
                    fetch();
                    op = "fetch";
                }
                else if (SC == 1)
                {
                    decode();
                    op = "decode";
                }
                else if (SC == 2)
                {
                    op ="t2: " +T2();
                }
                else if (SC == 3)
                {
                    op = "t3: " + T3();
                }
                else if (SC == 4)
                {
                    op = "t4: " + T4();
                }
                else if (SC == 5)
                {
                    op = "t5: " + T5();
                }
            }


            return op;
        }

        public void fetch()
        {
            IR.Load(codeSegment[PC.getDataInt()].i + codeSegment[PC.getDataInt()].opcode + codeSegment[PC.getDataInt()].data);
            incSC();
        }
        public void decode()
        {
            p = 0;
            r = 0;

            PC.Increment();
            I = (IR.getData()).Substring(0, 1);
            AR.Load((IR.getData()).Substring(5, 4));
            decodeIR();
            incSC();
        }
        //Memory Reference
        public void decodeIR()
        {
            d = Convert.ToInt32(Util.convert(IR.getData().Substring(1, 4), "BIN", "DEC"));
            b = Convert.ToInt32(Util.convert(IR.getData().Substring(5, 4), "BIN", "DEC"));
            if (d == 0 && I != "1")
            {
                r = 1;
            }
            else if (d == 0 && I == "1")
            {
                p = 1;
            }

        }

        public string T2()
        {
            string op = "emtpy";
            if (r == 1)
            {
                if (b == 0)
                {
                    //SZE
                    if (E == 0)//rB0
                    {
                        PC.Increment();
                    }
                    op = "sze";
                }
                else if (b == 1)
                {
                    //CLA
                    AC.Clear();
                    op = "cla";
                }
                else if (b == 2)
                {
                    //SZA
                    if (AC.getDataInt() == 0)
                    {
                        PC.Increment();
                    }
                    op = "sza";
                }
                else if (b == 3)
                {
                    //SNA 
                    if (AC.getData().Substring(0, 1) == "1")
                    {
                        PC.Increment();
                    }
                    op = "sna";
                }
                else if (b == 4)
                {
                    //CMA
                    AC.Complement();
                    op = "comp";
                }
                else if (b == 5)
                {
                    //INC
                    AC.Increment();
                    op = "inc";
                }
                else if (b == 7)
                {
                    //ASHR
                    AC.ASHR();
                    op = "ashr";
                }
                else if (b == 8)
                {
                    //ASHL
                    AC.ASHL();
                    op = "ashl";
                }
                else if (b == 9)
                {
                    //HLT
                    S = 0;//rB9
                    op = "hlt";
                }

                SC = 0;
            }
            else if (p == 1)
            {
                if (b == 7 || b == 15)
                {
                    AC.Load(INPR.getData());
                    FGI = 0;
                    SC = 0;
                }
                else if (b == 1 || b == 8)
                {
                    SP.Increment();
                    incSC();
                }
                else if (b == 2 || b == 10)
                {
                    DR.Load(stackSegment[SP.getDataInt()].data);
                    incSC();
                }
                else if (b == 3 || b == 11)
                {
                    if (SP.getDataInt() == 0)
                    {
                        PC.Increment();
                    }
                    SC = 0;
                }
                else if (b == 4 || b == 12)
                {
                    if (SP.getDataInt() == 0)
                    {
                        PC.Increment();

                    }
                    SC = 0;
                }
            }
            else if (d != 0 && I == "1")//indirect
            {
                AR.Load(dataSegment[AR.getDataInt()].data);
                op = "indirect";
                incSC();
            }
            else
            {
                op = "wait direct";
                incSC();
            }
            
            return op;
        }

        public string T3()
        {
            string op = "";
            if (p == 1)
            {
                op = "stack";
                if (b == 1 || b == 8)
                {
                    stackSegment[SP.getDataInt()].data = DR.getData();
                    SC = 0;
                }
                else if (b == 2 || b == 10)
                {
                    SP.Decrement();
                    SC = 0;
                }
            }
            else if (d == 1)
            {
                //OR
                DR.Load(dataSegment[AR.getDataInt()].data);//D1T3
                incSC();
                op = "or";
            }
            else if (d == 2)
            {
                //AND
                DR.Load(dataSegment[AR.getDataInt()].data);//D2T3
                incSC();
                op = "and";
            }
            else if (d == 3)
            {
                //XOR
                DR.Load(dataSegment[AR.getDataInt()].data);//D3T3
                incSC();
                op = "xor";
            }
            else if (d == 4)
            {
                //ADD
                DR.Load(dataSegment[AR.getDataInt()].data);//D4T3
                incSC();
                op = "add";
            }
            else if (d == 5)
            {
                //LDA
                DR.Load(dataSegment[AR.getDataInt()].data);//D5T3
                op = "LDA";
                incSC();
            }
            else if (d == 6)
            {
                //STA
                dataSegment[AR.getDataInt()].data = AC.getData();
                SC = 0;
                op = "sta";
            }
            else if (d == 8)
            {
                //BUN
                PC.Load(AR.getData());
                SC = 0;
                op = "bun";
            }
            else if (d == 9)
            {
                //BSA
                dataSegment[AR.getDataInt()].data = PC.getData();
                AR.Increment();//D9T3
                incSC();
            }
            else if (d == 15)
            {
                //ISZ
                DR.Load(dataSegment[AR.getDataInt()].data);//D15T3
                incSC();
            }

            return op;
        }

        public string T4()
        {
            string op = "";
            if (d == 1)
            {
                //OR
                AC.Load(Util.convert(Convert.ToString(AC.getDataInt() | DR.getDataInt()), "DEC", "BIN"));
                SC = 0; //D1T4
            }
            else if (d == 2)
            {
                //AND
                AC.Load(Util.convert(Convert.ToString(AC.getDataInt() & DR.getDataInt()), "DEC", "BIN"));
                SC = 0; //D2T4
            }
            else if (d == 3)
            {
                //XOR
                AC.Load(Util.convert(Convert.ToString(AC.getDataInt() ^ DR.getDataInt()), "DEC", "BIN"));
                SC = 0; //D3T4
            }
            else if (d == 4)
            {
                //ADD
                AC.Load(Util.convert(Convert.ToString(AC.getDataInt() + DR.getDataInt()), "DEC", "BIN"));
                SC = 0; //D4T4
                op = "add";
            }
            else if (d == 5)
            {
                //LDA
                AC.Load(DR.getData());
                SC = 0;//D5T4
                op = "LDA";
            }
            else if (d == 9)
            {
                //BSA
                PC.Load(AR.getData()); SC = 0;//D9T4
            }
            else if (d == 15)
            {
                //ISZ
                DR.Increment();//D15T4
            }
            return op;
        }

        public string T5()
        {
            string op = "";
            if (d == 15)
            {
                //isz
                dataSegment[AR.getDataInt()].data = DR.getData();
                if (DR.getDataInt() == 0)
                {
                    PC.Increment();
                }
                SC = 0;
                //D15T5
            }
            return op;
        }

        }

    }


