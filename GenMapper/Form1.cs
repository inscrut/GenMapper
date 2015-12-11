using System;
using System.Drawing;
using System.Windows.Forms;

namespace GenMapper
{
    public partial class Form1 : Form
    {
        DebInfo debf = new DebInfo();
        GenMap gm = new GenMap();
        Size maxsize;

        Bitmap bm;

        Point[] xy_block = { new Point(1, 1), new Point(1, 1) };
        Size[] blocks = { new Size(10, 10), new Size(50, 50) };

        public Form1()
        {
            InitializeComponent();
            debf.Show();
        }

        private void button_open_Click(object sender, EventArgs e)
        {
            //Coming soon
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            SaveFileDialog SFD = new SaveFileDialog();
            SFD.Filter = "BMP files (*.bmp)|*.bmp|PNG files (*.png)|*.png";

            if(SFD.ShowDialog() == DialogResult.OK)
            {
                switch (SFD.FilterIndex)
                {
                    case 1:
                        bm.Save(SFD.FileName, System.Drawing.Imaging.ImageFormat.Bmp);
                        break;
                    case 2:
                        bm.Save(SFD.FileName, System.Drawing.Imaging.ImageFormat.Png);
                        break;
                    default:
                        break;
                }
            }
        }

        private void MapBox_Click(object sender, EventArgs e)
        {
            //MapBox.Image = bm;
            //MapBox.Refresh();

            MapBox.Refresh();
            MapBox.Image = bm;
        }

        private void MapBox_Paint(object sender, PaintEventArgs e)
        {
            bm = new Bitmap(MapBox.Width, MapBox.Height);
            maxsize = new Size(MapBox.Width, MapBox.Height);

            Graphics g = Graphics.FromImage(bm);
            gm.ShowWeb(g, Color.Green, blocks[0], maxsize);
            gm.ShowWeb(g, Color.Red, blocks[1], maxsize);

            gm.Block(g, Color.Green, blocks[1], xy_block[1]);
            gm.Block(g, Color.Red, blocks[0], xy_block[0]);

            //MapBox.Image = bm;
        }

        private void MapBox_MouseMove(object sender, MouseEventArgs e)
        {
            debf.mouseXY = "X: " + e.X + "\r\nY: " + e.Y;

            xy_block[0] = gm.GetCubeXY(blocks[0], new Point(e.X, e.Y));
            xy_block[1] = gm.GetCubeXY(blocks[1], new Point(e.X, e.Y));
            debf.showCoords(xy_block);

            //MapBox.Refresh();
        }
    }
}
