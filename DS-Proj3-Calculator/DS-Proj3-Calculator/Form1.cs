using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace DS_Proj3_Calculator
{
    public partial class Form1 : Form
    {
        public string MainPhrase = "";
        public Form1()
        {
            InitializeComponent();
        }










        #region Button Settings
        private void b1_Click(object sender, EventArgs e)
        {
            if (Lcd.Text == "0")
                Lcd.Clear();
            Lcd.Text += "1";
        }

        private void b2_Click(object sender, EventArgs e)
        {
            if (Lcd.Text == "0")
                Lcd.Clear();
            Lcd.Text += "2";
        }

        private void b3_Click(object sender, EventArgs e)
        {
            if (Lcd.Text == "0")
                Lcd.Clear();
            Lcd.Text += "3";
        }

        private void b4_Click(object sender, EventArgs e)
        {
            if (Lcd.Text == "0")
                Lcd.Clear();
            Lcd.Text += "4";
        }

        private void b5_Click(object sender, EventArgs e)
        {
            if (Lcd.Text == "0")
                Lcd.Clear();
            Lcd.Text += "5";
        }

        private void b6_Click(object sender, EventArgs e)
        {
            if (Lcd.Text == "0")
                Lcd.Clear();
            Lcd.Text += "6";
        }

        private void b7_Click(object sender, EventArgs e)
        {
            if (Lcd.Text == "0")
                Lcd.Clear();
            Lcd.Text += "7";
        }

        private void b8_Click(object sender, EventArgs e)
        {
            if (Lcd.Text == "0")
                Lcd.Clear();
            Lcd.Text += "8";
        }

        private void b9_Click(object sender, EventArgs e)
        {
            if (Lcd.Text == "0")
                Lcd.Clear();
            Lcd.Text += "9";
        }

        private void dot_butt_Click(object sender, EventArgs e)
        {
            if (!Lcd.Text.Contains("."))
                Lcd.Text += ".";
        }

        private void clear_butt_Click(object sender, EventArgs e)
        {
            Lcd.Clear();
            Lcd.Text = "0";
        }
        #endregion

    }
}
