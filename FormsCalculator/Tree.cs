using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsCalculator
{
    public partial class Tree : Form
    {
        public Tree()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            uint treeHeight;
            StringBuilder sb = new StringBuilder();

            try
            {
                treeHeight = uint.Parse(textBox1.Text);
                label2.Text = "Correct value";
                label2.ForeColor = Color.DarkGreen;

                uint asterixNumber = 1;
                uint treeWidth = treeHeight;

                //drawing a tree
                for (int i = 0; i < treeHeight; i++)
                {
                    
                    for (int j = 0; j < treeWidth; j++)
                    {
                        sb.AppendFormat(" ");
                    }
                    for (int k = 0; k < asterixNumber; k++)
                    {
                        sb.AppendFormat("* ");
                    }
                    asterixNumber++;
                    treeWidth--;
                    sb.AppendFormat("\n");
                }

                //tree log

                for (int i = 0; i < treeHeight; i++)
                {
                    sb.AppendFormat(" ");
                }
                sb.AppendFormat(" |");

                richTextBox1.Text = sb.ToString();
            }
            catch (ArgumentNullException)
            {
                label2.Text = "You can't use null here";
                label2.ForeColor = Color.DarkRed;
            }
            catch (FormatException)
            {
                label2.Text = "Wrong number format";
                label2.ForeColor = Color.DarkRed;
            }
            catch (OverflowException)
            {
                label2.Text = "Number is too big.";
                label2.ForeColor = Color.DarkRed;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 menu = new Form1();
            menu.ShowDialog();
        }

        private void treeColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            richTextBox1.ForeColor = colorDialog1.Color;
        }
    }
}
