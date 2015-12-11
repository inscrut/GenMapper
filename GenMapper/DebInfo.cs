using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenMapper
{
    public partial class DebInfo : Form
    {
        public string mouseXY { get { return textBox_mouse.Text; } set { textBox_mouse.Text = value; } }
        public string cubeID { get { return textBox_cubeid.Text; } set { textBox_cubeid.Text = value; } }

        public DebInfo()
        {
            InitializeComponent();
        }

        public void showCoords(Point[] pt)
        {
            textBox_cubeid.Text = "";
            for(int i=0; i<pt.Length; i++)
            {
                textBox_cubeid.Text += "(" + pt[i].X + ";" + pt[i].Y + ") ";
            }
        }
        public void showCoords(Point[] pt, string s)
        {
            textBox_cubeid.Text = "";
            for (int i = 0; i < pt.Length; i++)
            {
                textBox_cubeid.Text += "(" + pt[i].X + ";" + pt[i].Y + ") ";
            }
            textBox_cubeid.Text += s;
        }
        public void showLog(string s)
        {
            textBox_info.Text += s + "\r\n";
        }
    }
}
