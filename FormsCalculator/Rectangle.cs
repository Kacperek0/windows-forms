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
    public partial class Rectangle : Form
    {
        public Rectangle()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SideA_textBox.Text = string.Empty;
            SideB_textBox.Clear();
            Area_textBox.Clear();
            labelA.Text = string.Empty;
            label2.Text = string.Empty;
        }

        private void Color_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            panel1.BackColor = colorDialog1.Color;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            // panel1.Height = int.Parse(SideA_textBox.Text);
            // panel1.Width = int.Parse(SideB_textBox.Text);
            
        }

        private void Area_textBox_TextChanged(object sender, EventArgs e)
        {
  
        }

        private void SideA_textBox_TextChanged(object sender, EventArgs e)
        {
            int a;
            if (int.TryParse(SideA_textBox.Text, out a) && a > 0)
            {
                labelA.Text = "Correct value";
                panel1.Width = a;
            }
            else
            {
                labelA.Text = "Incorrect value";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            uint a, b;
            int flag = 0;
            if (uint.TryParse(SideA_textBox.Text, out a) && a > 0)
            {
                labelA.Text = "Correct value";
                flag += 1;
            }
            else
            {
                labelA.Text = "Incorrect value";
            }

            if (uint.TryParse(SideB_textBox.Text, out b) && b > 0)
            {
                label2.Text = "Correct value";
                flag += 1;
            }
            else
            {
                label2.Text = "Incorrect value";
            }

            if (flag == 2)
            {
                Area_textBox.Text = (a + b).ToString();
            }


        }

        private void Square_CheckedChanged(object sender, EventArgs e)
        {
            if (Square.Checked == true)
            {
                SideB_textBox.Text = SideA_textBox.Text;
                button1.PerformClick();
            }
        }

        private void SideB_textBox_TextChanged(object sender, EventArgs e)
        {
            int b;
            if (int.TryParse(SideA_textBox.Text, out b) && b > 0)
            {
                label2.Text = "Correct value";
                panel1.Height = b;
                
            }
            else
            {
                label2.Text = "Incorrect value";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (panel1.Visible == true)
            {
                panel1.Visible = false;
            }
            else
            {
                panel1.Visible = true;
            }
        }
    }
}
