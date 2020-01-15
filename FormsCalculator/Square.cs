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
    public partial class Square : Form
    {
        public Square()
        {
            InitializeComponent();
        }

        private void eventLog1_EntryWritten(object sender, System.Diagnostics.EntryWrittenEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            panel1.BackColor = colorDialog1.Color;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (panel1.Visible)
            {
                panel1.Visible = false;
            }
            else
            {
                panel1.Visible = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (DialogResult.Yes == result)
            {
                Application.Exit();
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (DialogResult.Yes == result)
            {
                this.Hide();
                CalculatorMenu cm = new CalculatorMenu();
                cm.Show();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int a;

            if (int.TryParse(textBox1.Text, out a) && a > 0)
            {
                panel1.Width = a;
                panel1.Height = a;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a;
            try
            {
                a = int.Parse(textBox1.Text);
                textBox2.Text = (a * a).ToString();
                textBox3.Text = (4 * a).ToString();
            }
            catch (NullReferenceException)
            {
                label4.Text = "You cannot place null here.";
            }
        }
    }
}
