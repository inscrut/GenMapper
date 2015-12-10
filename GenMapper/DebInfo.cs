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
    }
}
