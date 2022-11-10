using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DS_P4roj3_Calulator
{
    public partial class Form1 : Form
    {
    double result = 0;
    string operation = "";
    string fstNum, secNum;
    bool enterValue = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void xit_butt_Click(object sender, EventArgs e)
        {
      this.Close();
        }

    private void Form1_Load(object sender, EventArgs e)
    {

    }

    private void math_op_click(object sender, EventArgs e)
    {

    }

    private void num_click(object sender, EventArgs e)
    {
      if (display_txt1.Text == "0" || enterValue)
        display_txt1.Text = "";
      enterValue = false;
      Button btn = (Button)sender;
      if (btn.Text == ".")
      {
        if (!display_txt1.Text.Contains("."))
          display_txt1.Text = display_txt1.Text + btn.Text;
      }
      else
          display_txt1.Text = display_txt1.Text + btn.Text;
    }
  }
}
