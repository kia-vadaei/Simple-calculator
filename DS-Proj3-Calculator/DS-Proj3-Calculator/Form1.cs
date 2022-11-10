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

    void set_butt_cur()
    {
      foreach (Control control in butt_pnl.Controls)
      {
        if (control is Button)
          control.Cursor = Cursors.Hand;
      }
    }
        public Form1()
        {
            InitializeComponent();
        }
    }
}
