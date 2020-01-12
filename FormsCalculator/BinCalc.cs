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
            ushort dec;

            try
            {
               dec = ushort.Parse(textBox1.Text);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
