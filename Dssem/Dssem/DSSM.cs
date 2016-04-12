using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dssem
{
    public class DSSM

    {
        public Memory[] codeSegment = new Memory[16];
        public Memory[] dataSegment = new Memory[16];
        public Memory[] stackSegment = new Memory[8];
        public Register PC = new Register("0", 4);
        public Register DR = new Register("0", 4);
        public Register IR = new Register("0", 9);
        public Register AC = new Register("0", 4);
        public Register AR = new Register("0", 4);
       
        public Register SP = new Register("0", 3);


        public int E = 0;
        public int SC = 0;
        public int S = 0;
        public string I = "0";
        public int FGI = 0;
        public int d;
        public int r;
        public int p;
        public int b;
        public string input="";




        public Dictionary<string, string> labelTable = new Dictionary<string, string>();

        //memory , opcode tablosu, register arrayı
        //programın ana classı

        public DSSM()
        {
            if (!Memory.initFlag)
                Memory.initDic();
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
                    op = "T0:IR <- M[PC]";
                }
                else if (SC == 1)
                {
                    decode();
                    op = "T1 :D0…D15 IR(4..7)  , AR <- IR(0..3)  ,PC <-PC+1 ,I <- IR(8)";
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
                    op = "SZE  :rB0 if(E==0) then PC<-PC+1";
                }
                else if (b == 1)
                {
                    //CLA
                    AC.Clear();
                    op = "CLA :rB1 AC <-0";
                }
                else if (b == 2)
                {
                    //SZA
                    if (AC.getDataInt() == 0)
                    {
                        PC.Increment();
                    }
                    op = "SZA : rB2 if(AC==0) then PC <-PC+1";
                }
                else if (b == 3)
                {
                    //SNA 
                    if (AC.getData().Substring(0, 1) == "1")
                    {
                        PC.Increment();
                    }
                    op = "SNA :rB3 if(AC(8)==1)then PC<-PC+1";
                }
                else if (b == 4)
                {
                    //CMA
                    AC.Complement();
                    op = "CMA :rB4 AC <-AC’";
                }
                else if (b == 5)
                {
                    //INC
                    AC.Increment();
                    op = "INC : rB5 AC <- AC+1";
                }
                else if (b == 7)
                {
                    //ASHR
                    AC.ASHR();
                    op = "ASHR : rB7  AC <- ShiftRight(AC)";
                }
                else if (b == 8)
                {
                    //ASHL
                    AC.ASHL();
                    op = "ASHL :rB8 AC <- ShiftLeft(AC)";
                }
                else if (b == 9)
                {
                    //HLT
                    S = 0;//rB9
                    op = "HLT : rB9 S <- 0";
                }

                SC = 0;
            }
            else if (p == 1)
            {
                if (b == 7 || b == 15)
                {
                    AC.Load(input);
                    FGI = 0;
                    SC = 0;
                    op = "INP pB7 | pB15 : AC(0..7) <-INPR FGI <-0";
                }
                else if (b == 1 || b == 8)
                {
                    SP.Increment();
                    incSC();
                    op = "Push : pB1 | pB8 SP<-SP+1 ";
                }
                else if (b == 2 || b == 10)
                {
                    DR.Load(stackSegment[SP.getDataInt()].data);
                    incSC();
                    op = "Pop: pB2 | pB10 DR <-Stack[SP] ";
                }
                else if (b == 3 || b == 11)
                {
                    if (SP.getDataInt() == 0)
                    {
                        PC.Increment();
                    }
                    SC = 0;
                    op = "SizeEmpty:pB3 | pB11 if(SP=0) then PC<-PC+1";
                }
                else if (b == 4 || b == 12)
                {
                    if (SP.getDataInt() == 0)
                    {
                        PC.Increment();

                    }
                    SC = 0;
                    op = "SizeFull :pB4 | pB12 if(SP=7) then PC <-PC+1";
                }
            }
            else if (d != 0 && I == "1")//indirect
            {
                AR.Load(dataSegment[AR.getDataInt()].data);
              
                incSC();
                op = "Indirect :D0’IT2  :AR <- M[AR]";
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
                    op = " Stack[SP] < -DR";
                }
                else if (b == 2 || b == 10)
                {
                    SP.Decrement();
                    SC = 0;
                    op = " SP <- SP-1";
                }
                
            }
            else if (d == 1)
            {
                //OR
                DR.Load(dataSegment[AR.getDataInt()].data);//D1T3
                incSC();
                op = "DR <- M[AR] ";
            }
            else if (d == 2)
            {
                //AND
                DR.Load(dataSegment[AR.getDataInt()].data);//D2T3
                incSC();
                op = "DR<-M[AR]";
            }
            else if (d == 3)
            {
                //XOR
                DR.Load(dataSegment[AR.getDataInt()].data);//D3T3
                incSC();
                op = "DR<-M[AR]";
            }
            else if (d == 4)
            {
                //ADD
                DR.Load(dataSegment[AR.getDataInt()].data);//D4T3
                incSC();
                op = "DR<-M[AR]";
            }
            else if (d == 5)
            {
                //LDA
                DR.Load(dataSegment[AR.getDataInt()].data);//D5T3
                op = "DR<-M[AR]";
                incSC();
            }
            else if (d == 6)
            {
                //STA
                dataSegment[AR.getDataInt()].data = AC.getData();
                SC = 0;
                op = "M[AR] <- AC SC <-0";
            }
            else if (d == 8)
            {
                //BUN
                PC.Load(AR.getData());
                SC = 0;
                op = "PC <- AR SC <-0";
            }
            else if (d == 9)
            {
                //BSA
                dataSegment[AR.getDataInt()].data = PC.getData();
                AR.Increment();//D9T3
                incSC();
                op = "M[SP] <- PC , SC<-0 ";
            }
            else if (d == 15)
            {
                //ISZ
                DR.Load(dataSegment[AR.getDataInt()].data);//D15T3
                incSC();
                op = ":  DR <- M[AR] ";
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
                op = "AC <- AC | DR ,SC <- 0";
            }
            else if (d == 2)
            {
                //AND
                AC.Load(Util.convert(Convert.ToString(AC.getDataInt() & DR.getDataInt()), "DEC", "BIN"));
                SC = 0; //D2T4
                op = "AC <- AC ^ DR , SC <-0";
            }
            else if (d == 3)
            {
                //XOR
                AC.Load(Util.convert(Convert.ToString(AC.getDataInt() ^ DR.getDataInt()), "DEC", "BIN"));
                SC = 0; //D3T4
                op = "AC <- AC ®DR , SC <-0";
            }
            else if (d == 4)
            {
                //ADD
                int result = Util.convertSigned(AC.getData()) + Util.convertSigned(DR.getData());
                if (result < -8 || result > 7)
                {
                    E = 1;

                }
                else {
                    E = 0;
                }
                AC.Load(Util.convert(Convert.ToString(result), "DEC", "BIN"));
                SC = 0; //D4T4
                op = "AC <- DR+AC , E <- Cout ,SC<-0";
            }
            else if (d == 5)
            {
                //LDA
                AC.Load(DR.getData());
                SC = 0;//D5T4
                op = "AC <- DR , SC<-0";
            }
            else if (d == 9)
            {
                //BSA
                PC.Load(AR.getData());
                SC = 0;//D9T4
                op = "PC <- AR , SC <-0";
            }
            else if (d == 15)
            {
                //ISZ
                DR.Increment();//D15T4
                op = "DR <- DR+1";
                incSC();
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
                op = "M[AR] < -DR)  if (DR == 0) then(PC < -PC + 1) SC < -0";
                //D15T5
            }
            return op;
        }

        }

    }


