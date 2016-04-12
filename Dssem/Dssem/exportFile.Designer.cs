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
            this.choseAdress.Location = new System.Drawing.Point(254, 70);
            this.choseAdress.Name = "choseAdress";
            this.choseAdress.Size = new System.Drawing.Size(121, 24);
            this.choseAdress.TabIndex = 3;
            this.choseAdress.Text = "HEX";
            // 
            // choseFile
            // 
            this.choseFile.FormattingEnabled = true;
            this.choseFile.Items.AddRange(new object[] {
            ".mif",
            ".hex"});
            this.choseFile.Location = new System.Drawing.Point(254, 175);
            this.choseFile.Name = "choseFile";
            this.choseFile.Size = new System.Drawing.Size(121, 24);
            this.choseFile.TabIndex = 4;
            this.choseFile.Text = ".mif";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(110, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "ADRESS_RADIX :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(129, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "DATA_RADIX :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(142, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 17);
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
            this.choseData.Location = new System.Drawing.Point(254, 124);
            this.choseData.Name = "choseData";
            this.choseData.Size = new System.Drawing.Size(121, 24);
            this.choseData.TabIndex = 10;
            this.choseData.Text = "HEX";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(193, 257);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 53);
            this.button1.TabIndex = 11;
            this.button1.Text = "EXPORT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // exportFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 349);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.choseData);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.choseFile);
            this.Controls.Add(this.choseAdress);
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
    }
}