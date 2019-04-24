using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChnNumProc
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged_1(object sender, EventArgs e)
        {
           

        }
        private void Form1_Activated(object sender, EventArgs e)
        {
            InBox.Focus();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string box_string = InBox.Text;

            int input_data = System.Convert.ToInt32(box_string); 
            NumToChn UnumTochn = new NumToChn();
            string result = UnumTochn.NumberToChinese(input_data);
            OutBox.Text = result;
        }
    }
}
