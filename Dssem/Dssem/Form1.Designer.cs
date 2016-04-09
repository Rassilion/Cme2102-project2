namespace Dssem
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.extractToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.codeList = new System.Windows.Forms.ListBox();
            this.codeSegmentView = new System.Windows.Forms.DataGridView();
            this.value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Memory = new System.Windows.Forms.GroupBox();
            this.stackSegmentView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.insvalue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataSegmentView = new System.Windows.Forms.DataGridView();
            this.datavalue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.valueBox = new System.Windows.Forms.TextBox();
            this.opBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pctext = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.stext = new System.Windows.Forms.TextBox();
            this.fgitext = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.itext = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.etext = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.sctext = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.inprtext = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.irtext = new System.Windows.Forms.TextBox();
            this.sptext = new System.Windows.Forms.TextBox();
            this.drtext = new System.Windows.Forms.TextBox();
            this.actext = new System.Windows.Forms.TextBox();
            this.artext = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labeltable = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.mop = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.codeSegmentView)).BeginInit();
            this.Memory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stackSegmentView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSegmentView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.RoyalBlue;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(946, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileToolStripMenuItem,
            this.extractToolStripMenuItem,
            this.resetToolStripMenuItem});
            this.menuToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            this.openFileToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.openFileToolStripMenuItem.Text = "Open File";
            this.openFileToolStripMenuItem.Click += new System.EventHandler(this.openFileToolStripMenuItem_Click);
            // 
            // extractToolStripMenuItem
            // 
            this.extractToolStripMenuItem.Name = "extractToolStripMenuItem";
            this.extractToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.extractToolStripMenuItem.Text = "Extract";
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.resetToolStripMenuItem.Text = "Reset";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // codeList
            // 
            this.codeList.FormattingEnabled = true;
            this.codeList.Location = new System.Drawing.Point(0, 37);
            this.codeList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.codeList.Name = "codeList";
            this.codeList.Size = new System.Drawing.Size(212, 277);
            this.codeList.TabIndex = 1;
            // 
            // codeSegmentView
            // 
            this.codeSegmentView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.codeSegmentView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.value});
            this.codeSegmentView.Location = new System.Drawing.Point(11, 48);
            this.codeSegmentView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.codeSegmentView.Name = "codeSegmentView";
            this.codeSegmentView.RowHeadersWidth = 70;
            this.codeSegmentView.RowTemplate.Height = 24;
            this.codeSegmentView.Size = new System.Drawing.Size(188, 282);
            this.codeSegmentView.TabIndex = 3;
            // 
            // value
            // 
            this.value.HeaderText = "Value";
            this.value.Name = "value";
            this.value.ReadOnly = true;
            // 
            // Memory
            // 
            this.Memory.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Memory.Controls.Add(this.stackSegmentView);
            this.Memory.Controls.Add(this.dataSegmentView);
            this.Memory.Controls.Add(this.label13);
            this.Memory.Controls.Add(this.label12);
            this.Memory.Controls.Add(this.valueBox);
            this.Memory.Controls.Add(this.opBox);
            this.Memory.Controls.Add(this.label4);
            this.Memory.Controls.Add(this.label3);
            this.Memory.Controls.Add(this.label2);
            this.Memory.Controls.Add(this.codeSegmentView);
            this.Memory.Location = new System.Drawing.Point(215, 203);
            this.Memory.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Memory.Name = "Memory";
            this.Memory.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Memory.Size = new System.Drawing.Size(690, 334);
            this.Memory.TabIndex = 4;
            this.Memory.TabStop = false;
            this.Memory.Text = "Memory";
            // 
            // stackSegmentView
            // 
            this.stackSegmentView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stackSegmentView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.insvalue});
            this.stackSegmentView.Location = new System.Drawing.Point(413, 48);
            this.stackSegmentView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.stackSegmentView.Name = "stackSegmentView";
            this.stackSegmentView.RowTemplate.Height = 24;
            this.stackSegmentView.Size = new System.Drawing.Size(181, 282);
            this.stackSegmentView.TabIndex = 16;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Name";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 50;
            // 
            // insvalue
            // 
            this.insvalue.HeaderText = "Value";
            this.insvalue.Name = "insvalue";
            this.insvalue.ReadOnly = true;
            // 
            // dataSegmentView
            // 
            this.dataSegmentView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataSegmentView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.datavalue});
            this.dataSegmentView.Location = new System.Drawing.Point(213, 48);
            this.dataSegmentView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataSegmentView.Name = "dataSegmentView";
            this.dataSegmentView.RowHeadersWidth = 70;
            this.dataSegmentView.RowTemplate.Height = 24;
            this.dataSegmentView.Size = new System.Drawing.Size(196, 282);
            this.dataSegmentView.TabIndex = 15;
            // 
            // datavalue
            // 
            this.datavalue.HeaderText = "Value";
            this.datavalue.Name = "datavalue";
            this.datavalue.ReadOnly = true;
            this.datavalue.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(609, 97);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(48, 13);
            this.label13.TabIndex = 14;
            this.label13.Text = "VALUE :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(604, 26);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 13);
            this.label12.TabIndex = 13;
            this.label12.Text = "OPCODE";
            // 
            // valueBox
            // 
            this.valueBox.Location = new System.Drawing.Point(606, 113);
            this.valueBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.valueBox.Name = "valueBox";
            this.valueBox.Size = new System.Drawing.Size(76, 20);
            this.valueBox.TabIndex = 11;
            // 
            // opBox
            // 
            this.opBox.Location = new System.Drawing.Point(606, 63);
            this.opBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.opBox.Name = "opBox";
            this.opBox.Size = new System.Drawing.Size(76, 20);
            this.opBox.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(439, 26);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Stack :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(232, 26);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Data :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 26);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Instruction :";
            // 
            // pctext
            // 
            this.pctext.Location = new System.Drawing.Point(39, 38);
            this.pctext.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pctext.Name = "pctext";
            this.pctext.Size = new System.Drawing.Size(76, 20);
            this.pctext.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.stext);
            this.groupBox1.Controls.Add(this.fgitext);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.itext);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.etext);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.sctext);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.inprtext);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.irtext);
            this.groupBox1.Controls.Add(this.sptext);
            this.groupBox1.Controls.Add(this.drtext);
            this.groupBox1.Controls.Add(this.actext);
            this.groupBox1.Controls.Add(this.artext);
            this.groupBox1.Controls.Add(this.pctext);
            this.groupBox1.Location = new System.Drawing.Point(226, 44);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(409, 142);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registers";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(278, 124);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(17, 13);
            this.label18.TabIndex = 31;
            this.label18.Text = "S:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(221, 124);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(30, 13);
            this.label17.TabIndex = 30;
            this.label17.Text = "FGI :";
            // 
            // stext
            // 
            this.stext.Location = new System.Drawing.Point(295, 121);
            this.stext.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.stext.Name = "stext";
            this.stext.Size = new System.Drawing.Size(25, 20);
            this.stext.TabIndex = 29;
            // 
            // fgitext
            // 
            this.fgitext.Location = new System.Drawing.Point(250, 121);
            this.fgitext.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.fgitext.Name = "fgitext";
            this.fgitext.Size = new System.Drawing.Size(25, 20);
            this.fgitext.TabIndex = 28;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(278, 96);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(16, 13);
            this.label16.TabIndex = 27;
            this.label16.Text = "I :";
            // 
            // itext
            // 
            this.itext.Location = new System.Drawing.Point(295, 93);
            this.itext.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.itext.Name = "itext";
            this.itext.Size = new System.Drawing.Size(25, 20);
            this.itext.TabIndex = 26;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(226, 96);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(20, 13);
            this.label15.TabIndex = 25;
            this.label15.Text = "E :";
            // 
            // etext
            // 
            this.etext.Location = new System.Drawing.Point(250, 93);
            this.etext.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.etext.Name = "etext";
            this.etext.Size = new System.Drawing.Size(25, 20);
            this.etext.TabIndex = 24;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(226, 69);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(27, 13);
            this.label14.TabIndex = 23;
            this.label14.Text = "SC :";
            // 
            // sctext
            // 
            this.sctext.Location = new System.Drawing.Point(256, 69);
            this.sctext.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.sctext.Name = "sctext";
            this.sctext.Size = new System.Drawing.Size(76, 20);
            this.sctext.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(226, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 9);
            this.label1.TabIndex = 21;
            this.label1.Text = "INPR :";
            // 
            // inprtext
            // 
            this.inprtext.Location = new System.Drawing.Point(256, 38);
            this.inprtext.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.inprtext.Name = "inprtext";
            this.inprtext.Size = new System.Drawing.Size(76, 20);
            this.inprtext.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(332, 14);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "NumberMod:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "BINARY",
            "DECIMAL",
            "HEX"});
            this.comboBox1.Location = new System.Drawing.Point(345, 38);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(50, 21);
            this.comboBox1.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(124, 100);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(24, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "IR :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(120, 67);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "SP :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(118, 38);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "DR :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 100);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "AC :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 69);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "AR :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 38);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "PC :";
            // 
            // irtext
            // 
            this.irtext.Location = new System.Drawing.Point(146, 100);
            this.irtext.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.irtext.Name = "irtext";
            this.irtext.Size = new System.Drawing.Size(76, 20);
            this.irtext.TabIndex = 11;
            // 
            // sptext
            // 
            this.sptext.Location = new System.Drawing.Point(146, 67);
            this.sptext.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.sptext.Name = "sptext";
            this.sptext.Size = new System.Drawing.Size(76, 20);
            this.sptext.TabIndex = 10;
            // 
            // drtext
            // 
            this.drtext.Location = new System.Drawing.Point(146, 38);
            this.drtext.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.drtext.Name = "drtext";
            this.drtext.Size = new System.Drawing.Size(76, 20);
            this.drtext.TabIndex = 9;
            // 
            // actext
            // 
            this.actext.Location = new System.Drawing.Point(39, 100);
            this.actext.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.actext.Name = "actext";
            this.actext.Size = new System.Drawing.Size(76, 20);
            this.actext.TabIndex = 8;
            // 
            // artext
            // 
            this.artext.Location = new System.Drawing.Point(39, 67);
            this.artext.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.artext.Name = "artext";
            this.artext.Size = new System.Drawing.Size(76, 20);
            this.artext.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.mop);
            this.groupBox2.Location = new System.Drawing.Point(718, 44);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(219, 128);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Micro operation";
            // 
            // labeltable
            // 
            this.labeltable.FormattingEnabled = true;
            this.labeltable.Location = new System.Drawing.Point(25, 338);
            this.labeltable.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.labeltable.Name = "labeltable";
            this.labeltable.Size = new System.Drawing.Size(147, 121);
            this.labeltable.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button1.ForeColor = System.Drawing.Color.Blue;
            this.button1.Location = new System.Drawing.Point(639, 47);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 49);
            this.button1.TabIndex = 9;
            this.button1.Text = "Read Next-->";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // mop
            // 
            this.mop.AutoSize = true;
            this.mop.Location = new System.Drawing.Point(6, 19);
            this.mop.Name = "mop";
            this.mop.Size = new System.Drawing.Size(41, 13);
            this.mop.TabIndex = 0;
            this.mop.Text = "label19";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(946, 547);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labeltable);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Memory);
            this.Controls.Add(this.codeList);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.Black;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "DSSM";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.codeSegmentView)).EndInit();
            this.Memory.ResumeLayout(false);
            this.Memory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stackSegmentView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSegmentView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem extractToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.ListBox codeList;
        private System.Windows.Forms.DataGridView codeSegmentView;
        private System.Windows.Forms.GroupBox Memory;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox pctext;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox irtext;
        private System.Windows.Forms.TextBox sptext;
        private System.Windows.Forms.TextBox drtext;
        private System.Windows.Forms.TextBox artext;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox valueBox;
        private System.Windows.Forms.TextBox opBox;
        private System.Windows.Forms.DataGridView stackSegmentView;
        private System.Windows.Forms.DataGridView dataSegmentView;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox actext;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn insvalue;
        private System.Windows.Forms.ListBox labeltable;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn datavalue;
        private System.Windows.Forms.DataGridViewTextBoxColumn value;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox etext;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox sctext;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inprtext;
        private System.Windows.Forms.TextBox itext;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox stext;
        private System.Windows.Forms.TextBox fgitext;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label mop;
    }
}

