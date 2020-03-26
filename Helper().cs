using System;
using System.Drawing;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class Helper
    {
        private Graphics p_device;
        private Bitmap p_surface;
        private PictureBox p_pb;
        private Form p_frm;
        private Font p_font;
        private int v1;
        private int v2;

        public Helper()
        {
            Trace.WriteLine("Game class constructor");

            //create a picturebox
            p_pb = new PictureBox();
            p_pb.Parent = Form.ActiveForm;
            //p_pb.Dock = DockStyle.Fill;
            p_pb.Location = new Point(0, 0);
            p_pb.Size = new Size(p_pb.Parent.Width, p_pb.Parent.Height);
            p_pb.BackColor = Color.Transparent;

           
            //set the default font
            SetFont("Arial", 18, FontStyle.Regular);
        }
        ~Helper()
        {
            Trace.WriteLine("Game class destructor");
            p_device.Dispose();
            p_surface.Dispose();
            p_pb.Dispose();
            p_font.Dispose();
        }

        public Graphics Device
        {
            get { return p_device; }
        }

        public void Update()
        {

        }

        /*
         * font support with several Print variations
         */
        public void SetFont(string name, int size, System.Drawing.FontStyle style)
        {
            p_font = new Font(name, size, style, GraphicsUnit.Pixel);
        }

        public void Print(int x, int y, string text, Brush color)
        {
            Device.DrawString(text, p_font, color, (float)x, (float)y);
        }

        public void Print(Point pos, string text, Brush color)
        {
            Print(pos.X, pos.Y, text, color);
        }

        public void Print(int x, int y, string text)
        {
            Print(x, y, text, Brushes.White);
        }

        public void Print(Point pos, string text)
        {
            Print(pos.X, pos.Y, text);
        }

        /*
         * Bitmap support functions
         */
        public Bitmap LoadBitmap(string filename)
        {
            Bitmap bmp = null;
            try
            {
                bmp = new Bitmap(filename);
            }
            catch (Exception ex) { }
            return bmp;
        }

        public void DrawBitmap(ref Bitmap bmp, float x, float y)
        {
            p_device.DrawImageUnscaled(bmp, (int)x, (int)y);
        }

        public void DrawBitmap(ref Bitmap bmp, float x, float y, int width, int height)
        {
            p_device.DrawImageUnscaled(bmp, (int)x, (int)y, width, height);
        }

        public void DrawBitmap(ref Bitmap bmp, Point pos)
        {
            p_device.DrawImageUnscaled(bmp, pos);
        }

        public void DrawBitmap(ref Bitmap bmp, Point pos, Size size)
        {
            p_device.DrawImageUnscaled(bmp, pos.X, pos.Y, size.Width, size.Height);
        }

    }
}
