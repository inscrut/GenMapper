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
    public partial class Form1 : Form
    {
        DebInfo debf = new DebInfo();
        GenMap gm = new GenMap();
        Size maxsize;

        Point[] xy_block = { new Point(1, 1), new Point(1, 1) };
        Size[] blocks = { new Size(10, 10), new Size(50, 50) };

        public Form1()
        {
            InitializeComponent();
            debf.Show();
        }

        private void button_open_Click(object sender, EventArgs e)
        {

        }

        private void button_save_Click(object sender, EventArgs e)
        {

        }

        private void MapBox_Click(object sender, EventArgs e)
        {
            MapBox.Refresh();
        }

        private void MapBox_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            maxsize = new Size(MapBox.Width, MapBox.Height);

            gm.ShowWeb(g, Color.Green, blocks[0], maxsize);
            gm.ShowWeb(g, Color.Red, blocks[1], maxsize);

            gm.Block(g, Color.Blue, blocks[1], xy_block[1]);
            gm.Block(g, Color.White, blocks[0], xy_block[0]);
        }

        private void MapBox_MouseMove(object sender, MouseEventArgs e)
        {
            debf.mouseXY = "X: " + e.X + "\r\nY: " + e.Y;

            xy_block[0] = gm.GetCubeXY(blocks[0], new Point(e.X, e.Y));
            xy_block[1] = gm.GetCubeXY(blocks[1], new Point(e.X, e.Y));
            debf.cubeID = "(" + xy_block[0].X + ";" + xy_block[0].Y + ")" + " (" + xy_block[1].X + ";" + xy_block[1].Y + ")";

            MapBox.Refresh();
        }
    }
}
