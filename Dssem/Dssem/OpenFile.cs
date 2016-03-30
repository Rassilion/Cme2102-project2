using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dssem
{
    public partial class OpenFile : Form
    {
        
        public OpenFile()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Browse file

            openFileDialog1.Title = " Please select the assembly file " ;

            openFileDialog1.Filter = " (*.asm) | *.asm | (*.basm) | *.basm " ;

            openFileDialog1.ShowDialog();

            filetext.Text = openFileDialog1.FileName;

            if (filetext.Text == "") return;
            else Form1.filePath = filetext.Text;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
