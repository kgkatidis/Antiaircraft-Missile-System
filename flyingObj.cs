using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsApp1
{
    public class FlyingObj
    {
        private int altitude;
        private Random rand = new Random();
        private bool alive;
        private Bitmap bitmap;
        private int X;
        private int Y;
        private Size size;
        Helper helper;



        public FlyingObj()
        {
            X = rand.Next(100,900);
            Y = rand.Next(50,150);
        }

        public bool Alive
        {
            get { return alive; }
            set { alive = value; }
        }

        public Bitmap Image
        {
            get { return bitmap; }
            set { bitmap = value; }
        }

        public int XX
        {
            get { return X; }
            set { X = value; }
        }

        public int YY
        {
            get { return Y; }
            set { Y = value; }
        }

        public Size Size
        {
            get { return size; }
            set { size = value; }
        }

        public int Width
        {
            get { return size.Width; }
            set { size.Width = value; }
        }

        public int Height
        {
            get { return size.Height; }
            set { size.Height = value; }
        }

        public void Draw()
        {
            Rectangle frame = new Rectangle();
            frame.X = X;
            frame.Y = Y;
            frame.Width = size.Width;
            frame.Height = size.Height;
            helper.Device.DrawImage(bitmap, Bounds, frame, GraphicsUnit.Pixel);
        }

        //returns bounding rectangle around sprite 
        public Rectangle Bounds
        {
            get
            {
                Rectangle rect = new Rectangle(
                    (int)X, (int)Y,
                    size.Width, size.Height);
                return rect;
            }
        }

        public bool IsColliding(ref FlyingObj other)
        {
            //test for bounding rectangle collision
            bool collision = Bounds.IntersectsWith(other.Bounds);
            return collision;
        }
    }
}
