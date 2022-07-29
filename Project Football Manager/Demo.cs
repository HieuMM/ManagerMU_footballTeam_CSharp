using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Project_Football_Manager
{
    public partial class Demo : Form
    {
        public Demo()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
  
        }
        
        private bool isNumber1(string s)
        {
           int value;
            if (int.TryParse(s, out value) && value > 0)
                {
                   return true;
                }
                else
                {
                    return false;
                }
        }

            private void button1_Click(object sender, EventArgs e)
        {
            
            if (isNumber1(textBox1.Text))
            {
                MessageBox.Show("Yes");
            }
            else
            {
                MessageBox.Show("Fail");
            }
        }
    }
}
