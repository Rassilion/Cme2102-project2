﻿using System;
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
        int count = 0;
        
        public exportFile(DSSM dssm)
        {
            InitializeComponent();
            this.dssm = dssm;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (choseFile.Text==".mif")
            {
                FileWriter("16","8",".mif","C");
                FileWriter("16", "8", ".mif", "D");
                FileWriter("8", "8", ".mif", "S");


            }
            else if (choseFile.Text == ".d")
            {

            }
        }

        public void FileWriter(string depth,string length,string filetype,string memorytype)
        {
            string path = "Example"+Convert.ToString(count)+".mif";
            count++;
            if (!File.Exists(path))
            {
                File.Create(path);
                TextWriter tw = new StreamWriter(path);
                tw.WriteLine("DEPTH="+depth+";");
                tw.WriteLine("WIDTH=" + length + ";");
                tw.WriteLine("ADRESS_RADIX="+choseAdress.Text+";");
                tw.WriteLine("DATA_RADIX=" + choseData.Text + ";");
                tw.WriteLine("CONTENT");
                tw.WriteLine("BEGIN");
                if (memorytype=="C")
                {
                    for (int i = 0; i < Convert.ToInt32(depth); i++)
                    {
                        tw.Write(Util.convert(Convert.ToString(i),"DEC",choseAdress.Text)+":");
                        tw.WriteLine(Util.convert(dssm.codeSegment[i].i + dssm.codeSegment[i].opcode + dssm.codeSegment[i].data,"BIN",choseData.Text) +";");
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
        }

    }
}
