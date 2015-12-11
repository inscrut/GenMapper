using System.Drawing;

namespace GenMapper
{
    class GenMap
    {
        public void World(Graphics g, Point f, Point s)
        {
            //
        }
        private void ocean(Graphics g, Point f, Point s)
        {
            //
        }
        public void Block(Graphics g, Color color, Size sz, Point xy)
        {
            int x = xy.X * sz.Width - sz.Width;
            int y = xy.Y * sz.Height - sz.Height;

            g.FillRectangle(new SolidBrush(color), x, y, sz.Width, sz.Height);
        }

        //Debug
        public void ShowWeb(Graphics g, Color color, Size cube, Size form)
        {
            for(int i=0; i<form.Width; i += cube.Width)
            {
                for(int j=0; j<form.Height; j += cube.Height)
                {
                    g.DrawRectangle(new Pen(color), i, j, cube.Width, cube.Height);
                }
            }
        }
        public Point GetCubeXY(Size sz_cube, Point t)
        {
            int val_x = 0;
            int val_y = 0;

            for (int i = 0; i < t.X; i += sz_cube.Width) val_x++;
            for (int i = 0; i < t.Y; i += sz_cube.Height) val_y++;

            return new Point(val_x, val_y);
        }
        public Point GetCubeXY_alt(Size sz_cube, Point t)
        {
            int val_x = 1;
            int val_y = 1;
            
            while (true)
            {
                if(val_x * sz_cube.Width >= t.X)
                {
                    if (val_y * sz_cube.Height >= t.Y) break;
                }
                else if(val_y * sz_cube.Height >= t.Y)
                {
                    if (val_x * sz_cube.Width >= t.X) break;
                }
                if (val_x * sz_cube.Width < t.X) val_x++;
                else if (val_y * sz_cube.Height < t.Y) val_y++;
            }

            return new Point(val_x, val_y);
        }
    }
}
