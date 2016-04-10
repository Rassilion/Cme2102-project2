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
    public partial class Form1 : Form
    {
        private DSSM dssm = new DSSM();

        string showValue = "BIN";

        public static string filePath;
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFile of = new OpenFile();
            of.ShowDialog();
            loadFile();
            parseLabel();
            parseCode();
            updateForm();
        }

        public void updateForm()
        {
            //clear
            codeSegmentView.Rows.Clear();
            dataSegmentView.Rows.Clear();
            stackSegmentView.Rows.Clear();
            labeltable.Items.Clear();

            //code segment
            foreach (Memory cell in dssm.codeSegment)
            {
                if (cell == null)
                {
                    codeSegmentView.Rows.Add("");
                    continue;
                }
                codeSegmentView.Rows.Add(Util.convert(cell.ToString(), "BIN", showValue));
            }
            foreach (DataGridViewRow row in codeSegmentView.Rows)
            {
                codeSegmentView.Rows[row.Index].HeaderCell.Value = (row.Index).ToString();
                if (dssm.PC.getDataInt() == row.Index)
                {
                    row.Selected = true;
                }
            }

            //data segment
            foreach (Memory cell in dssm.dataSegment)
            {
                if (cell == null)
                {
                    dataSegmentView.Rows.Add("");
                    continue;
                }
                dataSegmentView.Rows.Add(Util.convert(cell.ToString(), "BIN", showValue));
            }
            foreach (DataGridViewRow row in dataSegmentView.Rows)
            {
                dataSegmentView.Rows[row.Index].HeaderCell.Value = (row.Index).ToString();
            }

            //stack segment
            foreach (Memory cell in dssm.stackSegment)
            {
                if (cell == null)
                {
                    stackSegmentView.Rows.Add("");
                    continue;
                }
                stackSegmentView.Rows.Add(Util.convert(cell.ToString(), "BIN", showValue));
            }
            foreach (DataGridViewRow row in stackSegmentView.Rows)
            {
                stackSegmentView.Rows[row.Index].HeaderCell.Value = (row.Index).ToString();
            }

            //registers

            pctext.Text = Util.convert(dssm.PC.getData(), "BIN", showValue);
            artext.Text = Util.convert(dssm.AR.getData(), "BIN", showValue);
            drtext.Text = Util.convert(dssm.DR.getData(), "BIN", showValue);
            irtext.Text = Util.convert(dssm.IR.getData(), "BIN", showValue);
            actext.Text = Util.convert(dssm.AC.getData(), "BIN", showValue);
            sptext.Text = Util.convert(dssm.SP.getData(), "BIN", showValue);
            inprtext.Text = Util.convert(dssm.INPR.getData(), "BIN", showValue);

            //flags
            etext.Text = Util.convert(Convert.ToString(dssm.E), "BIN", showValue);
            fgitext.Text = Util.convert(Convert.ToString(dssm.FGI), "BIN", showValue);
            stext.Text = Util.convert(Convert.ToString(dssm.S), "BIN", showValue);
            itext.Text = Util.convert(Convert.ToString(dssm.I), "BIN", showValue);
            sctext.Text = Util.convert(Convert.ToString(dssm.SC), "BIN", showValue);

            //labeltable
            foreach (KeyValuePair<string, string> entry in dssm.labelTable)
            {
                labeltable.Items.Add(entry.Key + " " + Util.convert(entry.Value, "BIN", showValue));//gui
            }
           

        }

        public void loadFile()
        {
            try
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    String line;
                    // Read and display lines from the file until the end of 
                    // the file is reached.
                    while ((line = sr.ReadLine()) != null)
                    {
                        line = line.Replace('\t', ' ');//remove tabs
                        codeList.Items.Add(line);
                    }
                }
            }
            catch (ArgumentException e)
            {
                MessageBox.Show("Wrong input");

            }



        }
        private void parseLabel()
        { //TODO: error check
            labeltable.Items.Clear();
            int c_index = 0, d_index = -1;
            foreach (var line in codeList.Items)
            {
                string[] splited = line.ToString().Split(' ');
                for (int i = 0; i < splited.Length; i++)
                {
                    if (splited[i] == "")
                        continue;
                    if (splited[i].StartsWith("%"))//comment 
                    {
                        break;
                    }
                    else if (!splited[i].Contains(','))//opcode
                    {
                        if (splited[i] == "ORG")
                        {
                            if (splited[i + 1].ToUpper() == "C")
                                c_index = Convert.ToInt32(splited[i + 2]);
                            if (splited[i + 1].ToUpper() == "D")
                                d_index = Convert.ToInt32(splited[i + 2]);
                            break;
                        }
                    }
                    else if (splited[i].Contains(','))
                    {
                        splited[i] = splited[i].Remove(splited[i].Length - 1);
                      
                        dssm.labelTable.Add(splited[i], Util.convert(Convert.ToString(d_index), "DEC", "BIN"));//add label adress to label table
                        dssm.dataSegment[d_index] = new Memory("0", "0000", Util.convert(splited[i + 2], splited[i + 1], "BIN"));//add label's initial value to data memory
                        d_index++;
                    }
                }
            }

        }
        private void parseCode()
        {
            //TODO: error check
            int c_index = 0, d_index = -1;
            foreach (var line in codeList.Items)
            {
                string[] splited = line.ToString().Split(' ');
                for (int i = 0; i < splited.Length; i++)
                {
                    if (splited[i] == "")
                        continue;
                    if (splited[i].StartsWith("%"))//comment 
                    {
                        break;
                    }
                    else if (!splited[i].Contains(','))//opcode
                    {
                        if (splited[i] == "ORG")
                        {
                            if (splited[i + 1].ToUpper() == "C")
                            {
                                c_index = Convert.ToInt32(splited[i + 2]);
                                dssm.initPC(Util.convert(splited[i + 2], "DEC", "BIN"));
                            }
                            if (splited[i + 1].ToUpper() == "D")
                                d_index = Convert.ToInt32(splited[i + 2]);
                            break;
                        }
                        else if (d_index == -1)
                        {
                            string ibit = "0", data = "0000";
                            if (splited.Length > 2 && splited[i + 2] == "I")//opcode data I
                            {
                                ibit = "1";
                                data = splited[i + 1];
                            }
                            else if (splited.Length > 1) //opcode with data
                            {
                                ibit = "0";
                                data = splited[i + 1];
                            }
                            //get label adress
                            if (dssm.labelTable.ContainsKey(data))
                                data = dssm.labelTable[data];
                            dssm.codeSegment[c_index] = new Memory(ibit, splited[i], data);
                            c_index++;
                            break;
                        }
                    }
                    else if (splited[i].Contains(','))
                    {
                        break;
                    }
                }

            }
        }


        private void parse(string line)
        {
            opBox.Text = "";

            string[] splited = line.Split(' ');
            for (int i = 0; i < splited.Length; i++)
            {
                if (splited[i] == "")//skip space
                {
                    continue;
                }
                else if (splited[i] == "END")//program end
                {
                    opBox.Text = splited[i];
                    index = -1;
                }

                else if (splited[i].StartsWith("%"))//comment 
                {/*
                    for (int j = i; j < splited.Length; j++)//finish comment
                    {
                        commentBox.Text += " " + splited[j];
                    }*/
                    break;
                }
                else if (splited[i].Length == 3 && !splited[i].Contains(','))//opcode
                {
                    if (splited[i] == "ORG")
                        splited[i] = splited[i] + " " + splited[i + 1];
                    opBox.Text = splited[i];
                }
                else//value part
                {
                    valueBox.Text = splited[i];
                }
            }
        }


        int index = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            codeList.SelectedIndex = index;
            parse(codeList.Items[index].ToString());
            index++;

        }

        private void numbermod_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (numbermod.Text == "BINARY")
            {
                showValue = "BIN";
                updateForm();
            }
            else if (numbermod.Text == "HEX")
            {
                showValue = "HEX";
                updateForm();
            }
            else if (numbermod.Text == "DECIMAL")
            {
                showValue = "DEC";
                updateForm();
            }
            else if (numbermod.Text == "OCTAL")
            {
                showValue = "OCT";
                updateForm();
            }
        }
    }
}
