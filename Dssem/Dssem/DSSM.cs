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
        public int S = 0;
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
        public void nextInstruction()
        {
            do
            {
                nextMicroOp();
            } while (SC != 0);

        }
        public string nextMicroOp()
        {
            if (SC == 0)
            {
                fetch();
            }
            else if (SC == 1)
            {
                decode();
            }
            else if (SC == 2)
            {
                T2();
            }
            else if (SC == 3)
            {
                T3();
            }
            else if (SC == 4)
            {

            }
            else if (SC == 5)
            {

            }


            return "";
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
            b = Convert.ToInt32(Util.convert(IR.getData().Substring(4, 4), "BIN", "DEC"));
            if (d == 0 && I != "1")
            {
                r = 1;
            }
            else if (d == 0 && I == "1")
            {
                p = 1;
            }

        }

        public void T2()
        {

            if (r == 1)
            {
                if (b == 0)
                {
                    //SZE
                    if (E == 0)//rB0
                    {
                        PC.Increment();
                    }
                }
                else if (b == 1)
                {
                    //CLA
                    AC.Clear();
                }
                else if (b == 2)
                {
                    //SZA
                    if (AC.getDataInt() == 0)
                    {
                        PC.Increment();
                    }
                }
                else if (b == 3)
                {
                    //SNA 
                    if (AC.getData().Substring(0, 1) == "1")
                    {
                        PC.Increment();
                    }
                }
                else if (b == 4)
                {
                    //CMA
                    //ac ac compl at
                }
                else if (b == 5)
                {
                    //INC
                    AC.Increment();
                }
                else if (b == 6)
                {

                }
                else if (b == 7)
                {
                    //ASHR
                    // ac shift right ac at//rB7
                }
                else if (b == 8)
                {
                    //ASHL
                    //AC shift left ac at //rB8
                }
                else if (b == 9)
                {
                    //HLT
                    SC = 0;//rB9
                }
            }
            else if (p == 1)
            {
                //io
            }
            else if (d != 0 && I == "1")//indirect
            {
                AR.Load(dataSegment[AR.getDataInt()].data);
            }

            incSC();
        }

        public void T3()
        {
            if (d == 1)
            {
                //OR
                DR.Load(dataSegment[AR.getDataInt()].data);//D1T3
            }
            else if (d == 2)
            {
                //AND
                DR.Load(dataSegment[AR.getDataInt()].data);//D2T3
            }
            else if (d == 3)
            {
                //XOR
                DR.Load(dataSegment[AR.getDataInt()].data);//D3T3
            }
            else if (d == 4)
            {
                //ADD
                DR.Load(dataSegment[AR.getDataInt()].data);//D4T3
            }
            else if (d == 5)
            {
                //CDA
                DR.Load(dataSegment[AR.getDataInt()].data);//D5T3
            }
            else if (d == 6)
            {
                //STA
                dataSegment[AR.getDataInt()].data = AC.getData();
                AR.Increment();
            }
            else if (d == 7)
            {
                //BUN
                PC.Load(AR.getData());
                AR.Increment();
            }
            else if (d == 8)
            {
                //BSA
                dataSegment[AR.getDataInt()].data = PC.getData();
                AR.Increment();//D9T3
            }
            else if (d == 9)
            {
                //ISZ
                DR.Load(dataSegment[AR.getDataInt()].data);//D15T3
            }
            incSC();
        }
        public void memoryOR()
        {   //OR
            DR.Load(dataSegment[AR.getDataInt()].data);//D1T3
            AC.Load(Util.convert(Convert.ToString(AC.getDataInt() | DR.getDataInt()), "DEC", "BIN"));
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
            //Register Reference

            //SZE
            if (E == 0)//rB0
            {
                PC.Increment();
            }
            //CLA
            AC.Clear();//rB1
                       //SZA
            if (AC.getData() == "000000000")//rB2
            {
                PC.Increment();
            }
            //SNA 
            if (AC.getData().Substring(0, 1) == "1")//rB3
            {
                PC.Increment();
            }
            //CMA
            //ac ac compl at //rB4
            //INC
            AC.Increment();//rB5
                           //ASHR
                           // ac shift right ac at//rB7
                           //ASHL
                           //AC shift left ac at //rB8
                           //HLT
            SC = 0;//rB9

            //ınput output Reference


            //INP
            //pB7 or pB15
            //ınpr ac at

            //Stack Reference
            //push
            //pB1 or pB8
            SP.Increment();
            stackSegment[SP.getDataInt()].data = DR.getData();
            //Pop
            //pB2 or pB10
            DR.Load(stackSegment[SP.getDataInt()].data);
            SP.Decrement();
            //Size Empty
            //pB3 or pB11
            if (SP.getDataInt() == 0)
            {
                PC.Increment();
            }
            //size full
            //pB4 or pB12
            if (SP.getDataInt() == 0)
            {
                PC.Increment();

            }



        }

    }







}

