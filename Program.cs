using System;
using System.Drawing;
using System.Windows;
using System.Windows.Forms;

namespace Graphics
{
    class Program
    {
        static void Main(string[] args)
        {

            int res = 2000;
            Bitmap block = new Bitmap(res, res);
            Form form = new Form();
            form.Text = "Graphics";
            PictureBox pictureBox = new PictureBox();
            pictureBox.Dock = DockStyle.Fill;
            form.Controls.Add(pictureBox);
            Color clrR = Color.FromArgb(255, 0, 0);
            Color clrG = Color.FromArgb(0, 255, 0);
            pictureBox.Image = block;

            DrawSquare(0, 0, 1000, 500, clrR, block);
            //DrawLine(800, 800, 500, 600, clrG, block);

            Application.Run(form);

        }
        static void DrawSquare(int x1, int y1, int x2, int y2, Color some_color, Bitmap bitmap)
        {
            if(x1 < x2 && y1 < y2)
            {
                for (int x = x1; x <= x2; x++)
                {
                    for (int y = y1; y <= y2; y++)
                    {
                        bitmap.SetPixel(x, y, some_color);
                    }
                }
            }
            if (x1 > x2 && y1 > y2)
            {
                int tmp_x = x1;
                x1 = x2;
                x2 = tmp_x;
                int tmp_y = y1;
                y1 = y2;
                y2 = tmp_y;
                for (int x = x1; x <= x2; x++)
                {
                    for (int y = y1; y <= y2; y++)
                    {
                        bitmap.SetPixel(x, y, some_color);
                    }
                }
            }
        }
        /*
        static void DrawLine(int x1, int y1, int x2, int y2, Color some_color, Bitmap bitmap)
        {
            double m = ((double)y2 - (double)y1) / ((double)x2 - (double)x1);
            if (x1 < x2 && y1 < y2)
            {
                for (double x = x1; x <= x2; x++)
                {
                    double y = Math.Round(m * x - (m * x1 + y1));
                    bitmap.SetPixel((int)x, (int)y, some_color);
                }
            }
            if (x1 > x2 && y1 > y2)
            {
                int tmp_x = x1;
                x1 = x2;
                x2 = tmp_x;
                int tmp_y = y1;
                y1 = y2;
                y2 = tmp_y;
                for (float x = x1; x <= x2; x++)
                {
                    double y = Math.Round(m * x - (m * x1 + y1));
                    bitmap.SetPixel((int)x, (int)y, some_color);
                }
            }
        }
        */
    }
}
