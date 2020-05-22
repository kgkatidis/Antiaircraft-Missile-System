using System;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class GamePlay
    {
        private Graphics p_device;
        private Bitmap p_surface;
        private PictureBox p_pb;
        private Form p_frm;

        public GamePlay(ref Form form, int width, int height)
        {
            Trace.WriteLine("GamePlay class constructor");

            //set form properties
            p_frm = form;
            p_frm.FormBorderStyle = FormBorderStyle.FixedSingle;
            p_frm.MaximizeBox = false;
            //adjust size for window border
            p_frm.Size = new Size(width + 6, height + 28);

            //create a picturebox
            p_pb = new PictureBox();
            p_pb.Parent = p_frm;
            //p_pb.Dock = DockStyle.Fill;
            p_pb.Location = new Point(0, 0);
            p_pb.Size = new Size(width, height);
            p_pb.BackColor = Color.Black;

            //create graphics device
            p_surface = new Bitmap(p_frm.Size.Width, p_frm.Size.Height);
            p_pb.Image = p_surface;
            p_device = Graphics.FromImage(p_surface);
            
        }
        

        ~GamePlay()
        {
            Trace.WriteLine("GamePlay class destructor");
            p_device.Dispose();
            p_surface.Dispose();
            p_pb.Dispose();
        }

        public Graphics Device
        {
            get { return p_device; }
        }

        public void Update()
        {
            //refresh the drawing surface
            p_pb.Image = p_surface;
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
        

        public void DrawBitmap(ref Bitmap bmp, float x, float y, int width, int height)
        {
            p_device.DrawImageUnscaled(bmp, (int)x, (int)y, width, height);
        }

        public void DrawBitmap(ref Bitmap bmp, Point pos, Size size)
        {
            p_device.DrawImageUnscaled(bmp, pos.X, pos.Y, size.Width, size.Height);
        }

    }
}
