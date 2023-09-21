using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Click_Click(object sender, EventArgs e)
        {
            String var = richTextBox1.Text;
            // split the input on the basis of space
            String[] words = var.Split(' ');
            // Regular Expression for variables
            Regex regex1 = new Regex(@"^[0-9][0-9]*(([\.][0-9][0-9]*)?([e][+|-][0-9][0-9]*)?)?$");
            for (int i = 0; i < words.Length; i++)
            {
                Match match1 = regex1.Match(words[i]);
                if (match1.Success)
                {
                    richTextBox2.Text += words[i] + " ";
                }
                else
                {
                    MessageBox.Show("invalid " + words[i]);
                }
            }
            
        }

        private void btn_gotoTask2_Click(object sender, EventArgs e)
        {

            Form2 frm2 = new Form2() { TopLevel = false, TopMost = true };
            frm2.FormBorderStyle = FormBorderStyle.Sizable;
            this.Controls.Add(frm2);
            frm2.Show();
        }

        private void btn_gotoTask3_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3() { TopLevel = false, TopMost = true };
            frm3.FormBorderStyle = FormBorderStyle.Sizable;
            this.Controls.Add(frm3);
            frm3.Show();

        }
    }
}
