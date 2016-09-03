using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2016002503Lab4Git
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void forLoopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtOutput.Clear();   // Clears the text box so you can run each loop one after another and not have problems.
            for(int num = 1; num <= 7; num++)
            {
                txtOutput.Text += num + "\r\n";
            }
        }

        private void nestedForLoopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtOutput.Clear();
            for (int nest = 1; nest <= 7; nest++)
            {
                for(int nest2 = 1; nest2 <= nest; nest2++)
                {
                    txtOutput.Text += nest2;
                }
                txtOutput.Text += "\r\n";
            }
        }

        private void whileLoopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtOutput.Clear();
            int wLoop = 0;  // W stands for While
            while (wLoop <= 6)
            {
                wLoop++;
                txtOutput.Text += wLoop + "\r\n";
            }
        }

        private void doWhileLoopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtOutput.Clear();
            int dwLoop = 0;  // DW stands for DoWhile

            do
            {
                dwLoop++;
                txtOutput.Text += dwLoop + "\r\n";
            }
            while (dwLoop <= 6);
        }

        private void forEachLoopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtOutput.Clear();
            int[] feLoop = new int[] { 1, 2, 3, 4, 5, 6, 7};     // FE stands for ForEach       
            foreach (int element in feLoop)
            {
                txtOutput.Text += element;
                txtOutput.Text += "\r\n";
            }
                

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Help N/A");
        }
    }
}
