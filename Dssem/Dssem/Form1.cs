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
        private DSSM dssm = new DSSM();

        //gui number base
        string showValue = "BIN";
        //code list selected index
        int index = 1;
        int indexstart = 1;
        //file path
        public static string filePath;

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            updateForm();
            inprtext.Text = "0";
        }



        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFile of = new OpenFile();
            of.ShowDialog();
            //reset dssm
            dssm = new DSSM();
            //parse file and update gui
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
                codeSegmentView.Rows.Add(Util.convert(cell.ToString(), "BIN", showValue));
            }
            foreach (DataGridViewRow row in codeSegmentView.Rows)
            {
                codeSegmentView.Rows[row.Index].HeaderCell.Value = (row.Index).ToString();
                codeSegmentView.CurrentCell = null;
                if (dssm.PC.getDataInt() == row.Index)
                {
                    row.Selected = true;
                }
            }

            //data segment
            foreach (Memory cell in dssm.dataSegment)
            {
                dataSegmentView.Rows.Add(Util.convert(cell.ToString(), "BIN", showValue));
            }
            foreach (DataGridViewRow row in dataSegmentView.Rows)
            {
                dataSegmentView.Rows[row.Index].HeaderCell.Value = (row.Index).ToString();
                dataSegmentView.CurrentCell = null;
                if (dssm.AR.getDataInt() == row.Index)
                {
                    row.Selected = true;
                }
            }

            //stack segment
            foreach (Memory cell in dssm.stackSegment)
            {
                stackSegmentView.Rows.Add(Util.convert(cell.ToString(), "BIN", showValue));
            }
            foreach (DataGridViewRow row in stackSegmentView.Rows)
            {
                stackSegmentView.Rows[row.Index].HeaderCell.Value = (row.Index).ToString();
                stackSegmentView.CurrentCell = null;
                if (dssm.SP.getDataInt() == row.Index)
                {
                    row.Selected = true;
                }
            }

            //registers

            pctext.Text = Util.convert(dssm.PC.getData(), "BIN", showValue);
            artext.Text = Util.convert(dssm.AR.getData(), "BIN", showValue);
            drtext.Text = Util.convert(dssm.DR.getData(), "BIN", showValue);
            irtext.Text = Util.convert(dssm.IR.getData(), "BIN", showValue);
            actext.Text = Util.convert(dssm.AC.getData(), "BIN", showValue);
            sptext.Text = Util.convert(dssm.SP.getData(), "BIN", showValue);

            dssm.input = Util.convert(inprtext.Text, showValue, "BIN");

            //flags
            etext.Text = Util.convert(Convert.ToString(dssm.E), "BIN", showValue);
            fgitext.Text = Util.convert(Convert.ToString(dssm.FGI), "BIN", showValue);
            stext.Text = Util.convert(Convert.ToString(dssm.S), "BIN", showValue);
            itext.Text = Util.convert(Convert.ToString(dssm.I), "BIN", showValue);
            sctext.Text = Util.convert(Convert.ToString(dssm.SC), "DEC", showValue);

            //labeltable
            foreach (KeyValuePair<string, string> entry in dssm.labelTable)
            {
                labeltable.Items.Add(entry.Key + " " + Util.convert(entry.Value, "BIN", showValue));//gui
            }



        }

        public void loadFile()
        {
            //reset code list
            codeList.Items.Clear();
            //reset index
            index = 1;
            //reset text
            mop.Text = "";
            //reset input
            inprtext.Text = "0";
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
                        //remove double spaces
                        line = string.Join(" ", line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));
                        if (line == "")
                        {
                            continue;
                        }
                        codeList.Items.Add(line);
                    }
                }
                dssm.S = 1;
            }
            catch (ArgumentException e)
            {
                MessageBox.Show("Wrong input");

            }
            catch (FileNotFoundException e)
            {
                MessageBox.Show("File not Found", "ERROR !!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }




        }
        private void parseLabel()
        { //TODO: error check
            labeltable.Items.Clear();
            int c_index = 0, d_index = -1;
            foreach (var line in codeList.Items)
            {
                string[] splited = line.ToString().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < splited.Length; i++)
                {
                    if (splited[i] == "")
                        continue;
                    if (splited[i].StartsWith("%"))//comment 
                    {
                        if (i == 0)//skipto code 
                        {
                            indexstart++;
                        }
                        break;
                    }
                    else if (!splited[i].Contains(','))//opcode
                    {
                        if (splited[i] == "ORG")
                        {
                            if (splited[i + 1].ToUpper() == "C")
                            {
                                c_index = Convert.ToInt32(splited[i + 2]);
                                indexstart = indexstart - c_index;
                            }
                            else if (splited[i + 1].ToUpper() == "D")
                                d_index = Convert.ToInt32(splited[i + 2]);
                            break;
                        }
                        c_index++;//increase code address
                        break;
                    }
                    else if (splited[i].Contains(','))
                    {
                        splited[i] = splited[i].Remove(splited[i].Length - 1);
                        if (splited[i + 1] == "DEC" || splited[i + 1] == "HEX" || splited[i + 1] == "BIN" || splited[i + 1] == "OCT")
                        {
                            dssm.labelTable.Add(splited[i], Util.convert(Convert.ToString(d_index), "DEC", "BIN"));//add label adress to label table
                            dssm.dataSegment[d_index] = new Memory("0", "0000", Util.convert(splited[i + 2], splited[i + 1], "BIN"));//add label's initial value to data memory
                            d_index++;
                        }
                        else
                        {
                            dssm.labelTable.Add(splited[i], Util.convert(Convert.ToString(c_index), "DEC", "BIN"));//add label adress to label table
                            c_index++;
                        }
                        break;
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
                string[] splited = line.ToString().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
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
                        if (splited[i + 1] == "DEC" || splited[i + 1] == "HEX" || splited[i + 1] == "BIN" || splited[i + 1] == "OCT")
                        {
                            break;
                        }
                        else
                        {
                            string ibit = "0", data = "0000";
                            if (splited.Length > 3 && splited[i + 3] == "I")//opcode data I
                            {
                                ibit = "1";
                                data = splited[i + 2];
                            }
                            else if (splited.Length > 2) //opcode with data
                            {
                                ibit = "0";
                                data = splited[i + 2];
                            }
                            //get label adress
                            if (dssm.labelTable.ContainsKey(data))
                                data = dssm.labelTable[data];
                            dssm.codeSegment[c_index] = new Memory(ibit, splited[i + 1], data);
                            c_index++;
                            break;
                        }
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



        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (dssm.S == 1)
                {
                    codeList.SelectedIndex = indexstart + dssm.PC.getDataInt();
                    parse(codeList.Items[index].ToString());
                    mop.Text = dssm.nextInstruction();
                }
                else
                {
                    //TODO warning
                }
            }
            catch (ArgumentOutOfRangeException A)
            {
                MessageBox.Show("File error", "ERROR !!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            updateForm();
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

        private void runMicro_Click(object sender, EventArgs e)
        {
            try
            {
                if (dssm.S == 1)
                {
                    if (dssm.SC == 0)
                        mop.Text = "";
                    mop.Text += dssm.nextMicroOp() + "\n";
                    codeList.SelectedIndex = indexstart + dssm.PC.getDataInt();

                }
                else
                {
                    //TODO warning
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Error");

            }
            updateForm();
        }

        private void baseColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            this.BackColor = colorDialog1.Color;
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            exportFile ExportFile = new exportFile(dssm);
            ExportFile.ShowDialog();

        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.dssm = new DSSM();
            showValue = "BIN";
            //code list selected index
            index = 1;
            indexstart = 1;
            //file path
            filePath = "";
            updateForm();
            mop.Text = "";
            codeList.Items.Clear();
            labeltable.Items.Clear();
            opBox.Text = "";
            valueBox.Text = "";

        }
    }
}
