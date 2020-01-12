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
    public partial class MatrixCreator : Form
    {
        public MatrixCreator()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int h, l, flg = 0;

            // first input check
            if (int.TryParse(textBox1.Text, out l) && l > 0)
            {
                label4.Text = "Correct input";
                label4.ForeColor = Color.DarkGreen;
                flg += 1;
            }
            else
            {
                label4.Text = "Ïncorrect input";
                label4.ForeColor = Color.DarkRed;
            }

            // second input check
            if ((int.TryParse(textBox2.Text, out h) && h > 0) == true)
            {
                label5.Text = "Correct input";
                label5.ForeColor = Color.DarkGreen;
                flg += 1;
            }
            else
            {
                label5.Text = "Incorrect value";
                label5.ForeColor = Color.DarkRed;
            }

            int ShowNumber = 0, ShowNumber_Decimal = 0, diagonalSum = 0;
            int[,] matix = new int[h, l];
            // building matrix
            if (flg == 2)
            {
                for (int i = 0; i < h; i++)
                {
                    ShowNumber_Decimal += 10;
                    for (int j = 0; j < l; j++)
                    {
                        matix[i, j] = ShowNumber_Decimal + ShowNumber;
                        ShowNumber += 1;
                        if (i == j)
                        {
                            diagonalSum += matix[i, j];
                        }
                    }
                    ShowNumber = 0;
                }

                //printing matrix
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < h; i++)
                {
                    for (int j = 0; j < l; j++)
                    {
                        sb.AppendFormat("{0}\t", matix[i,j]);
                    }
                    sb.AppendFormat("\n");
                }
               
                richTextBox1.Text = sb.ToString();
            }

            if (checkBox1.Checked == false)
            {
                textBox3.Text = diagonalSum.ToString();
            }
            else
            {
                textBox3.Text = "WSB";
            }


        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Clear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            richTextBox1.Clear();
            label4.Text = string.Empty;
            label5.Text = string.Empty;
            checkBox1.Checked = false;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox1.Checked == true)
            {
                int h, l, flg = 0;

                // first input check
                if (int.TryParse(textBox1.Text, out l) && l > 0)
                {
                    label4.Text = "Correct input";
                    label4.ForeColor = Color.DarkGreen;
                    flg += 1;
                }
                else
                {
                    label4.Text = "Ïncorrect input";
                    label4.ForeColor = Color.DarkRed;
                }

                // second input check
                if ((int.TryParse(textBox2.Text, out h) && h > 0) == true)
                {
                    label5.Text = "Correct input";
                    label5.ForeColor = Color.DarkGreen;
                    flg += 1;
                }
                else
                {
                    label5.Text = "Incorrect value";
                    label5.ForeColor = Color.DarkRed;
                }

                int ShowNumber = 0, ShowNumber_Decimal = 0;
                object[,] matix = new object[h, l];
                // building matrix
                if (flg == 2)
                {
                    for (int i = 0; i < h; i++)
                    {
                        ShowNumber_Decimal += 10;
                        for (int j = 0; j < l; j++)
                        {
                            if (i == j)
                            {
                                matix[i, j] = "WSB";
                                ShowNumber += 1;
                            }
                            else
                            {
                                matix[i, j] = ShowNumber_Decimal + ShowNumber;
                                ShowNumber += 1;
                            }
                        }
                        ShowNumber = 0;
                    }

                    //printing matrix
                    StringBuilder sb = new StringBuilder();
                    for (int i = 0; i < h; i++)
                    {
                        for (int j = 0; j < l; j++)
                        {
                            sb.AppendFormat("{0}\t", matix[i, j]);
                        }
                        sb.AppendFormat("\n");
                    }

                    richTextBox1.Text = sb.ToString();

                    textBox3.Text = "WSB";
                }

            }
            else
            {
                button1.PerformClick();
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
    }
}
