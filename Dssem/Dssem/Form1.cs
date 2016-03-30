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
    public partial class Form1 : Form
    {
        Memory[] codeSegment = new Memory[16];
        Memory[] dataSegment = new Memory[16];
        Memory[] stackSegment = new Memory[8];



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
            parseCode();
            updateForm();
        }

        public void updateForm()
        {
            //code segment
            foreach (Memory cell in codeSegment)
            {
                if (cell == null)
                {
                    codeSegmentView.Rows.Add("");
                    continue;
                }
                codeSegmentView.Rows.Add(cell.ToString());
            }
            foreach (DataGridViewRow row in codeSegmentView.Rows)
            {
                codeSegmentView.Rows[row.Index].HeaderCell.Value = (row.Index).ToString();
            }

            //data segment
            foreach (Memory cell in dataSegment)
            {
                if (cell == null)
                {
                    dataSegmentView.Rows.Add("");
                    continue;
                }
                dataSegmentView.Rows.Add(cell.ToString());
            }
            foreach (DataGridViewRow row in dataSegmentView.Rows)
            {
                dataSegmentView.Rows[row.Index].HeaderCell.Value = (row.Index).ToString();
            }

            //stack segment
            foreach (Memory cell in stackSegment)
            {
                if (cell == null)
                {
                    stackSegmentView.Rows.Add("");
                    continue;
                }
                stackSegmentView.Rows.Add(cell.ToString());
            }
            foreach (DataGridViewRow row in stackSegmentView.Rows)
            {
                stackSegmentView.Rows[row.Index].HeaderCell.Value = (row.Index).ToString();
            }

        }

        public void loadFile()
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

        private void parseCode()
        {
            //TODO: error check
            labeltable.Items.Clear();
            int c_index = 0, d_index = -1;
            foreach (var line in codeList.Items)
            {
                string[] splited = line.ToString().Split(' ');
                for (int i = 0; i < splited.Length; i++)
                {
                    if (splited[i].StartsWith("%"))//comment 
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
                        {
                            if (splited[i + 1].ToUpper() == "C")
                                c_index = Convert.ToInt32(splited[i + 2]);
                            if (splited[i + 1].ToUpper() == "D")
                                d_index = Convert.ToInt32(splited[i + 2]);
                        }
                        else if (d_index == -1)
                        {
                            codeSegment[c_index] = new Memory();
                            codeSegment[c_index].i = "0";
                            codeSegment[c_index].opcode = splited[i];
                            codeSegment[c_index].data = splited[i + 1];
                            c_index++;
                        }
                    }
                    else if (splited[i].Contains(','))
                    {
                        labeltable.Items.Add(splited[i] + " " + splited[i + 1] + " " + splited[i + 2]);
                        dataSegment[d_index] = new Memory();
                        dataSegment[d_index].i = "0";
                        dataSegment[d_index].opcode = splited[i + 1];
                        dataSegment[d_index].data = splited[i + 2];
                        d_index++;
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
    }
}
