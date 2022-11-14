using DevComponents.Editors;
using DS_Proj3_Calculator;
using DS_Proj3_Calulator;
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
    //Arthur -> Kianoosh vadaei
    //November 9, 2022.
    //Made for UI-DS
    //Mini Project num.3 
    public partial class Form1 : Form
    {

        string phrase = string.Empty;
        double result = 0;
        int p_check = -1;
        bool enterValue = false;
        MyStack<char> stack = new MyStack<char>(); 
        public Form1()
        {
            InitializeComponent();
            Console.SetWindowSize(40, 30);
            Console.ForegroundColor = ConsoleColor.Green;
        }

        private void xit_butt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }


        private void num_click(object sender, EventArgs e)
        {
            if (display_txt1.Text.Length < 14)
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
                else if (btn.Text == "%" || btn.Text == "^" || btn.Text == "✕" || btn.Text == "÷" || btn.Text == "+" || btn.Text == "-")
                {
                    try
                    {
                        if (display_txt1.Text.Last() != '%' && display_txt1.Text.Last() != '^' && display_txt1.Text.Last() != '✕' && display_txt1.Text.Last() != '÷' && display_txt1.Text.Last() != '+' && display_txt1.Text.Last() != '-' && display_txt1.Text != "0")
                            display_txt1.Text = display_txt1.Text + btn.Text;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Error!. display is Empty");
                        display_txt1.Text = "0";
                    }
                }
                else if (btn.Name == "CE_butt")
                {
                    if (display_txt1.Text != "" && display_txt1.Text != "0")
                    {
                        display_txt1.Text = display_txt1.Text.Substring(0, display_txt1.Text.Length - 1);
                        if (display_txt1.Text == String.Empty)
                            display_txt1.Text = "0";
                    }
                    else
                        display_txt1.Text = "0";
                }
                else if (btn.Text == "=")
                {
                    phrase = display_txt1.Text;

                    if (!MySetting.MySettings.Parentheses_check(phrase))
                    {
                        try
                        {
                            throw new Exception("EP");
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("ERROR_P" + "\n########################################");
                            display_txt1.Text = "0";
                            display_txt2.Text = "0";
                            p_check = -1;
                        }
                    }
                    else
                    {
                        phrase = MySetting.MySettings.infToPos(phrase);
                        Console.WriteLine("Postfix is >> " + phrase);
                        result = MySetting.MySettings.calcute(phrase);
                        //Console.WriteLine(result);
                        if (result != -123456.123456)
                        {
                            if (result.ToString().Length > 14)
                                display_txt2.Text = result.ToString().Substring(0, 14);
                            else
                                display_txt2.Text = result.ToString();
                        }
                        else
                        {
                            Console.WriteLine("ERROR_Op" + "\n########################################");
                            display_txt1.Text = "0";
                            display_txt2.Text = "0";
                            p_check = -1;
                        }
                    }



                }
                else if (btn.Text == "()")
                {
                    if (p_check < 0)
                    {
                        display_txt1.Text += "(";
                        p_check *= -1;
                    }
                    else
                    {
                        display_txt1.Text += ")";
                        p_check *= -1;
                    }

                }
                else if (btn.Text == "√x")
                {
                    try
                    {
                        if (display_txt1.Text.Last() != '√')
                            display_txt1.Text += "√";
                    }
                    catch(Exception)
                    {
                        display_txt1.Text = "√";
                    }
                    
                }
                else if (btn.Text == "C")
                {
                    display_txt1.Clear();
                    display_txt2.Clear();

                    display_txt1.Text = "0";
                    display_txt2.Text = "0";
                    p_check = -1;
                }
                else if (btn.Text == "Sin")
                {
                    try
                    {
                        if (display_txt1.Text.Last() != '$') // & is sin
                            display_txt1.Text += "$(";
                    }
                    catch (Exception)
                    {
                        display_txt1.Text = "$(";
                    }
                }
                else if (btn.Text == "Cos")
                {
                    try
                    {
                        if (display_txt1.Text.Last() != '#') // # is Cos
                            display_txt1.Text += "#(";
                    }
                    catch (Exception)
                    {
                        display_txt1.Text = "#(";
                    }
                }

                else
                    display_txt1.Text = display_txt1.Text + btn.Text;
            }
        }



    }
  
}
