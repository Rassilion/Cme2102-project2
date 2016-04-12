using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dssem
{
    public partial class exportFile : Form
    {
        DSSM dssm = new DSSM();
        int count = 12;
        
        public exportFile(DSSM dssm)
        {
            InitializeComponent();
            this.dssm = dssm;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (choseFile.Text==".mif")
            {
                FileWriter("16","8", codeName.Text,"C");
               FileWriter("16", "8", dataName.Text, "D");
                FileWriter("8", "8", stackName.Text, "S");


            }
            else if (choseFile.Text == ".hex")
            {
                
            }
        }

        public void FileWriter(string depth,string length,string filename,string memorytype)
        {

            string path = filename+".mif";
            count++;
            try
            {
                
                    

                    MessageBox.Show("GELDİ");
                    FileStream fs1 = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write);
                    StreamWriter tw = new StreamWriter(fs1);
                  
                    tw.WriteLine("DEPTH=" + depth + ";");
                    tw.WriteLine("WIDTH=" + length + ";");
                    tw.WriteLine("ADRESS_RADIX=" + choseAdress.Text + ";");
                    tw.WriteLine("DATA_RADIX=" + choseData.Text + ";");
                    tw.WriteLine("CONTENT");
                    tw.WriteLine("BEGIN");
                    if (memorytype == "C")
                    {
                        for (int i = 0; i < Convert.ToInt32(depth); i++)
                        {
                            tw.Write(Util.convert(Convert.ToString(i), "DEC", choseAdress.Text) + ":");
                            tw.WriteLine(Util.convert(dssm.codeSegment[i].i + dssm.codeSegment[i].opcode + dssm.codeSegment[i].data, "BIN", choseData.Text) + ";");
                        }
                    }
                    else if (memorytype == "D")
                    {
                        for (int i = 0; i < Convert.ToInt32(depth); i++)
                        {
                            tw.Write(Util.convert(Convert.ToString(i), "DEC", choseAdress.Text) + ":");
                            tw.WriteLine(Util.convert(dssm.dataSegment[i].i + dssm.dataSegment[i].opcode + dssm.dataSegment[i].data, "BIN", choseData.Text) + ";");
                        }
                    }
                    else if (memorytype == "S")
                    {
                        for (int i = 0; i < Convert.ToInt32(depth); i++)
                        {
                            tw.Write(Util.convert(Convert.ToString(i), "DEC", choseAdress.Text) + ":");
                            tw.WriteLine(Util.convert(dssm.stackSegment[i].i + dssm.stackSegment[i].opcode + dssm.stackSegment[i].data, "BIN", choseData.Text) + ";");
                        }
                    }

                    tw.Close();

                

            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("File error");
            }
        }

        public void writehexFile(string memorytype)
        {

            TextWriter tw = new StreamWriter("newHex.hex", true);

            if (memorytype == "C")
            { 
               

                for (int i = 0; i < dssm.codeSegment.Length; i++)
                { 
                    int result=0;
                    string address=Util.convert(Convert.ToString(i),"DEC","HEX");
                    string data = Util.convert(dssm.codeSegment[i].data,"BIN","HEX");
                    string writer = ":02" + address + "00" + Util.expandBit(data, 4);
                    for (int j = 1; j <writer.Length ; j+=2)
                    {
                        string a = writer.Substring(i,2);
                        result+= Convert.ToInt32(Util.convert(a,"HEX","DEC"));
                    }
                    result = result % 256;
                    string b = Util.convert(Convert.ToString(result),"DEC","BIN");
                    b = Util.expandBit(b,8);
                    b = Complement(b);
                    int k = Convert.ToInt32(Util.convert(b, "BIN", "DEC"))+1;
                    tw.WriteLine(writer+Util.convert(Convert.ToString(k),"DEC","BIN"));

                    
                }
            }
            else if (memorytype == "D")
            {
               
            }
            else if (memorytype == "S")
            {
              
            }


        }
        public string Complement(string data)
        {
            string result = "";
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == '0')
                {
                    result += "1";
                }
                else
                {
                    result += "0";
                }
            }

            return result;
        }

        
    }
}
