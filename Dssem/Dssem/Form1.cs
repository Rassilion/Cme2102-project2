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
    public partial class Form1 : Form
    {
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
            MessageBox.Show(filePath);
            

        }
        
                
    }
}
