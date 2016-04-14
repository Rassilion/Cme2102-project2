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
                writehexFile("C",codeName.Text);
                writehexFile("D", dataName.Text);
                writehexFile("S", stackName.Text);
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
                            tw.Write((Util.convert(Convert.ToString(i), "DEC", choseAdress.Text)).ToUpper() + ":");
                        string a = Util.convert(dssm.codeSegment[i].i + dssm.codeSegment[i].opcode + dssm.codeSegment[i].data, "BIN", choseData.Text).ToUpper();
                        if (choseData.Text == "HEX")
                        {
                            a = Util.expandBit(a, 3);

                        }
                        tw.WriteLine( a+ ";");
                      
                        }
                    }
                    else if (memorytype == "D")
                    {
                        for (int i = 0; i < Convert.ToInt32(depth); i++)
                        {
                            tw.Write((Util.convert(Convert.ToString(i), "DEC", choseAdress.Text)).ToUpper() + ":");
                            tw.WriteLine(Util.convert(dssm.dataSegment[i].i + dssm.dataSegment[i].opcode + dssm.dataSegment[i].data, "BIN", choseData.Text).ToUpper() + ";");
                        }
                    }
                    else if (memorytype == "S")
                    {
                        for (int i = 0; i < Convert.ToInt32(depth); i++)
                        {
                            tw.Write((Util.convert(Convert.ToString(i), "DEC", choseAdress.Text)).ToUpper() + ":");
                            tw.WriteLine(Util.convert(dssm.stackSegment[i].i + dssm.stackSegment[i].opcode + dssm.stackSegment[i].data, "BIN", choseData.Text).ToUpper() + ";");
                        }
                    }

                    tw.Close();

                

            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("File error");
            }
        }

        public void writehexFile(string memorytype,string path)
        {
            path = path + ".hex";
            if (File.Exists(path))
            {
                MessageBox.Show(path+"adinda bir dosya zaten var ");
            
            }
            else
            {
                TextWriter tw = new StreamWriter(path, true);

                if (memorytype == "C")
                {


                    for (int i = 0; i < dssm.codeSegment.Length; i++)
                    {
                        int result = 0;
                        string address = Util.convert(Convert.ToString(i), "DEC", "HEX");
                        address = Util.expandBit(address, 4);
                        string data = Util.convert(dssm.codeSegment[i].ToString(), "BIN", "HEX").ToUpper();
                        string writer = ":02" + address.ToUpper() + "00" + Util.expandBit(data, 4);
                        for (int j = 1; j <= writer.Length - 2; j += 2)
                        {
                            string a = writer.Substring(j, 2);
                            result += Convert.ToInt32(Util.convert(a, "HEX", "DEC"));
                        }
                        result = result % 256;
                        string b = Util.convert(Convert.ToString(result), "DEC", "BIN");
                        b = Util.expandBit(b, 8);
                        b = Complement(b);
                        int k = Convert.ToInt32(Util.convert(b, "BIN", "DEC")) + 1;
                        string t = Util.convert(Convert.ToString(k), "DEC", "BIN");
                        t = Util.convert(t, "BIN", "HEX").ToUpper();
                        tw.WriteLine(writer + t);


                    }
                    tw.WriteLine(":00000001FF");
                }
                else if (memorytype == "D")
                {
                    for (int i = 0; i < dssm.dataSegment.Length; i++)
                    {
                        int result = 0;
                        string address = Util.convert(Convert.ToString(i), "DEC", "HEX");
                        address = Util.expandBit(address, 4);
                        string data = Util.convert(dssm.dataSegment[i].ToString(), "BIN", "HEX");
                        string writer = ":02" + address + "00" + Util.expandBit(data, 4);
                        for (int j = 1; j <= writer.Length - 2; j += 2)
                        {
                            string a = writer.Substring(j, 2);
                            result += Convert.ToInt32(Util.convert(a, "HEX", "DEC"));
                        }
                        result = result % 256;
                        string b = Util.convert(Convert.ToString(result), "DEC", "BIN");
                        b = Util.expandBit(b, 8);
                        b = Complement(b);
                        int k = Convert.ToInt32(Util.convert(b, "BIN", "DEC")) + 1;
                        string t = Util.convert(Convert.ToString(k), "DEC", "BIN");
                        t = Util.convert(t, "BIN", "HEX");
                        tw.WriteLine(writer + t);


                    }
                    tw.WriteLine(":00000001FF");
                }
                else if (memorytype == "S")
                {
                    for (int i = 0; i < dssm.stackSegment.Length; i++)
                    {
                        int result = 0;
                        string address = Util.convert(Convert.ToString(i), "DEC", "HEX");
                        address = Util.expandBit(address, 4);
                        string data = Util.convert(dssm.stackSegment[i].ToString(), "BIN", "HEX");
                        string writer = ":02" + address + "00" + Util.expandBit(data, 4);
                        for (int j = 1; j <= writer.Length - 2; j += 2)
                        {
                            string a = writer.Substring(j, 2);
                            result += Convert.ToInt32(Util.convert(a, "HEX", "DEC"));
                        }
                        result = result % 256;
                        string b = Util.convert(Convert.ToString(result), "DEC", "BIN");
                        b = Util.expandBit(b, 8);
                        b = Complement(b);
                        int k = Convert.ToInt32(Util.convert(b, "BIN", "DEC")) + 1;
                        string t = Util.convert(Convert.ToString(k), "DEC", "BIN");
                        t = Util.convert(t, "BIN", "HEX");
                        tw.WriteLine(writer + t);


                    }
                    tw.WriteLine(":00000001FF");
                }
                tw.Close();
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
