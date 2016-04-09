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
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.irtext = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.datatext = new System.Windows.Forms.TextBox();
            this.actext = new System.Windows.Forms.TextBox();
            this.artext = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labeltable = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.codeSegmentView)).BeginInit();
            this.Memory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stackSegmentView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSegmentView)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1261, 28);
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
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            this.openFileToolStripMenuItem.Size = new System.Drawing.Size(147, 26);
            this.openFileToolStripMenuItem.Text = "Open File";
            this.openFileToolStripMenuItem.Click += new System.EventHandler(this.openFileToolStripMenuItem_Click);
            // 
            // extractToolStripMenuItem
            // 
            this.extractToolStripMenuItem.Name = "extractToolStripMenuItem";
            this.extractToolStripMenuItem.Size = new System.Drawing.Size(147, 26);
            this.extractToolStripMenuItem.Text = "Extract";
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(147, 26);
            this.resetToolStripMenuItem.Text = "Reset";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // codeList
            // 
            this.codeList.FormattingEnabled = true;
            this.codeList.ItemHeight = 16;
            this.codeList.Location = new System.Drawing.Point(0, 46);
            this.codeList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.codeList.Name = "codeList";
            this.codeList.Size = new System.Drawing.Size(281, 340);
            this.codeList.TabIndex = 1;
            // 
            // codeSegmentView
            // 
            this.codeSegmentView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.codeSegmentView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.value});
            this.codeSegmentView.Location = new System.Drawing.Point(15, 59);
            this.codeSegmentView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.codeSegmentView.Name = "codeSegmentView";
            this.codeSegmentView.RowHeadersWidth = 70;
            this.codeSegmentView.RowTemplate.Height = 24;
            this.codeSegmentView.Size = new System.Drawing.Size(251, 347);
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
            this.Memory.Location = new System.Drawing.Point(287, 250);
            this.Memory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Memory.Name = "Memory";
            this.Memory.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Memory.Size = new System.Drawing.Size(920, 411);
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
            this.stackSegmentView.Location = new System.Drawing.Point(551, 59);
            this.stackSegmentView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.stackSegmentView.Name = "stackSegmentView";
            this.stackSegmentView.RowTemplate.Height = 24;
            this.stackSegmentView.Size = new System.Drawing.Size(241, 347);
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
            this.dataSegmentView.Location = new System.Drawing.Point(284, 59);
            this.dataSegmentView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataSegmentView.Name = "dataSegmentView";
            this.dataSegmentView.RowHeadersWidth = 70;
            this.dataSegmentView.RowTemplate.Height = 24;
            this.dataSegmentView.Size = new System.Drawing.Size(261, 347);
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
            this.label13.Location = new System.Drawing.Point(812, 119);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 17);
            this.label13.TabIndex = 14;
            this.label13.Text = "VALUE :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(805, 32);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 17);
            this.label12.TabIndex = 13;
            this.label12.Text = "OPCODE";
            // 
            // valueBox
            // 
            this.valueBox.Location = new System.Drawing.Point(808, 139);
            this.valueBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.valueBox.Name = "valueBox";
            this.valueBox.Size = new System.Drawing.Size(100, 22);
            this.valueBox.TabIndex = 11;
            // 
            // opBox
            // 
            this.opBox.Location = new System.Drawing.Point(808, 78);
            this.opBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.opBox.Name = "opBox";
            this.opBox.Size = new System.Drawing.Size(100, 22);
            this.opBox.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(585, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Stack :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(309, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Data :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Instruction :";
            // 
            // pctext
            // 
            this.pctext.Location = new System.Drawing.Point(52, 47);
            this.pctext.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pctext.Name = "pctext";
            this.pctext.Size = new System.Drawing.Size(100, 22);
            this.pctext.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.textBox7);
            this.groupBox1.Controls.Add(this.textBox6);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.irtext);
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.datatext);
            this.groupBox1.Controls.Add(this.actext);
            this.groupBox1.Controls.Add(this.artext);
            this.groupBox1.Controls.Add(this.pctext);
            this.groupBox1.Location = new System.Drawing.Point(301, 54);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(545, 175);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registers";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(393, 115);
            this.textBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(32, 22);
            this.textBox4.TabIndex = 26;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(302, 118);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(25, 17);
            this.label15.TabIndex = 25;
            this.label15.Text = "E :";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(333, 115);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(32, 22);
            this.textBox3.TabIndex = 24;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(301, 85);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(34, 17);
            this.label14.TabIndex = 23;
            this.label14.Text = "SC :";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(341, 85);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(302, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "INPR :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(341, 47);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(442, 17);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 17);
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
            this.comboBox1.Location = new System.Drawing.Point(460, 47);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(65, 24);
            this.comboBox1.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(165, 123);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 17);
            this.label10.TabIndex = 17;
            this.label10.Text = "IR :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(160, 82);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 17);
            this.label9.TabIndex = 16;
            this.label9.Text = "SP :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(157, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "DR :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "AC :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "AR :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "PC :";
            // 
            // irtext
            // 
            this.irtext.Location = new System.Drawing.Point(195, 123);
            this.irtext.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.irtext.Name = "irtext";
            this.irtext.Size = new System.Drawing.Size(100, 22);
            this.irtext.TabIndex = 11;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(195, 82);
            this.textBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 22);
            this.textBox5.TabIndex = 10;
            // 
            // datatext
            // 
            this.datatext.Location = new System.Drawing.Point(195, 47);
            this.datatext.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.datatext.Name = "datatext";
            this.datatext.Size = new System.Drawing.Size(100, 22);
            this.datatext.TabIndex = 9;
            // 
            // actext
            // 
            this.actext.Location = new System.Drawing.Point(52, 123);
            this.actext.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.actext.Name = "actext";
            this.actext.Size = new System.Drawing.Size(100, 22);
            this.actext.TabIndex = 8;
            // 
            // artext
            // 
            this.artext.Location = new System.Drawing.Point(52, 82);
            this.artext.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.artext.Name = "artext";
            this.artext.Size = new System.Drawing.Size(100, 22);
            this.artext.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(957, 54);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(292, 158);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Micro operation";
            // 
            // labeltable
            // 
            this.labeltable.FormattingEnabled = true;
            this.labeltable.ItemHeight = 16;
            this.labeltable.Location = new System.Drawing.Point(33, 416);
            this.labeltable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labeltable.Name = "labeltable";
            this.labeltable.Size = new System.Drawing.Size(195, 148);
            this.labeltable.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button1.ForeColor = System.Drawing.Color.Blue;
            this.button1.Location = new System.Drawing.Point(852, 58);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 60);
            this.button1.TabIndex = 9;
            this.button1.Text = "Read Next-->";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(371, 118);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(19, 17);
            this.label16.TabIndex = 27;
            this.label16.Text = "I :";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(333, 149);
            this.textBox6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(32, 22);
            this.textBox6.TabIndex = 28;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(393, 149);
            this.textBox7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(32, 22);
            this.textBox7.TabIndex = 29;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(295, 152);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(38, 17);
            this.label17.TabIndex = 30;
            this.label17.Text = "FGI :";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(371, 152);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(21, 17);
            this.label18.TabIndex = 31;
            this.label18.Text = "S:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1261, 673);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labeltable);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Memory);
            this.Controls.Add(this.codeList);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.Black;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox datatext;
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
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label16;
    }
}

