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
    public partial class BinCalc : Form
    {
        public BinCalc()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int dec;
            int a, b, c;
            List<int> binary = new List<int>();



            if (int.TryParse(textBox1.Text, out dec) && dec < 256)
            {





                a = dec;

                if (a % 2 == 1)

                {

                    c = a / 2;

                    binary.Add(1);

                    a = c;

                }

                else

                {

                    c = a / 2;

                    binary.Add(0);

                    a = c;

                }

                while (c != 0)

                {

                    if (a % 2 == 1)

                    {

                        c = a / 2;

                        binary.Add(1);

                        a = c;

                    }

                    else

                    {

                        c = a / 2;

                        binary.Add(0);

                        a = c;

                    }

                }



                binary.Reverse();



                StringBuilder sb = new StringBuilder();

                foreach (var item in binary)

                {

                    sb.AppendFormat(item.ToString());

                }



                textBox2.Text = sb.ToString();

                label2.Text = "Correct value";

                label2.ForeColor = Color.DarkGreen;
            }
            else
            {
                label2.Text = "Please use value in range form 0 to 255";
                label2.ForeColor = Color.DarkRed;
            }

                
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure?", "Back", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                this.Hide();
                Form1 cm = new Form1();
                cm.ShowDialog();
            }
        }
    }
}
