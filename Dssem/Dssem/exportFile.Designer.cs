namespace Dssem
{
    partial class exportFile
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
            this.choseAdress = new System.Windows.Forms.ComboBox();
            this.choseFile = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.choseData = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.codeName = new System.Windows.Forms.TextBox();
            this.dataName = new System.Windows.Forms.TextBox();
            this.code = new System.Windows.Forms.Label();
            this.stackName = new System.Windows.Forms.TextBox();
            this.data = new System.Windows.Forms.Label();
            this.stack = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // choseAdress
            // 
            this.choseAdress.FormattingEnabled = true;
            this.choseAdress.Items.AddRange(new object[] {
            "HEX",
            "BIN",
            "OCT",
            "DEC",
            "UNS"});
            this.choseAdress.Location = new System.Drawing.Point(117, 53);
            this.choseAdress.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.choseAdress.Name = "choseAdress";
            this.choseAdress.Size = new System.Drawing.Size(92, 21);
            this.choseAdress.TabIndex = 3;
            this.choseAdress.Text = "HEX";
            // 
            // choseFile
            // 
            this.choseFile.FormattingEnabled = true;
            this.choseFile.Items.AddRange(new object[] {
            ".mif",
            ".hex"});
            this.choseFile.Location = new System.Drawing.Point(117, 138);
            this.choseFile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.choseFile.Name = "choseFile";
            this.choseFile.Size = new System.Drawing.Size(92, 21);
            this.choseFile.TabIndex = 4;
            this.choseFile.Text = ".mif";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 53);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "ADRESS_RADIX :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 99);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "DATA_RADIX :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 141);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "FILE :";
            // 
            // choseData
            // 
            this.choseData.FormattingEnabled = true;
            this.choseData.Items.AddRange(new object[] {
            "HEX",
            "BIN",
            "OCT",
            "DEC",
            "UNS"});
            this.choseData.Location = new System.Drawing.Point(117, 97);
            this.choseData.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.choseData.Name = "choseData";
            this.choseData.Size = new System.Drawing.Size(92, 21);
            this.choseData.TabIndex = 10;
            this.choseData.Text = "HEX";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(235, 210);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 43);
            this.button1.TabIndex = 11;
            this.button1.Text = "EXPORT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // codeName
            // 
            this.codeName.Location = new System.Drawing.Point(311, 55);
            this.codeName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.codeName.Name = "codeName";
            this.codeName.Size = new System.Drawing.Size(219, 20);
            this.codeName.TabIndex = 12;
            this.codeName.Text = "code";
            // 
            // dataName
            // 
            this.dataName.Location = new System.Drawing.Point(311, 95);
            this.dataName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataName.Name = "dataName";
            this.dataName.Size = new System.Drawing.Size(219, 20);
            this.dataName.TabIndex = 13;
            this.dataName.Text = "data";
            // 
            // code
            // 
            this.code.AutoSize = true;
            this.code.Location = new System.Drawing.Point(232, 55);
            this.code.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.code.Name = "code";
            this.code.Size = new System.Drawing.Size(61, 13);
            this.code.TabIndex = 14;
            this.code.Text = "Codename:";
            // 
            // stackName
            // 
            this.stackName.Location = new System.Drawing.Point(311, 142);
            this.stackName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.stackName.Name = "stackName";
            this.stackName.Size = new System.Drawing.Size(219, 20);
            this.stackName.TabIndex = 15;
            this.stackName.Text = "stack";
            // 
            // data
            // 
            this.data.AutoSize = true;
            this.data.Location = new System.Drawing.Point(232, 97);
            this.data.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(64, 13);
            this.data.TabIndex = 16;
            this.data.Text = "DataName :";
            // 
            // stack
            // 
            this.stack.AutoSize = true;
            this.stack.Location = new System.Drawing.Point(232, 142);
            this.stack.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.stack.Name = "stack";
            this.stack.Size = new System.Drawing.Size(67, 13);
            this.stack.TabIndex = 17;
            this.stack.Text = "Stackname :";
            // 
            // exportFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 284);
            this.Controls.Add(this.stack);
            this.Controls.Add(this.data);
            this.Controls.Add(this.stackName);
            this.Controls.Add(this.code);
            this.Controls.Add(this.dataName);
            this.Controls.Add(this.codeName);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.choseData);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.choseFile);
            this.Controls.Add(this.choseAdress);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "exportFile";
            this.Text = "exportFile";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox choseAdress;
        private System.Windows.Forms.ComboBox choseFile;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox choseData;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox codeName;
        private System.Windows.Forms.TextBox dataName;
        private System.Windows.Forms.Label code;
        private System.Windows.Forms.TextBox stackName;
        private System.Windows.Forms.Label data;
        private System.Windows.Forms.Label stack;
    }
}