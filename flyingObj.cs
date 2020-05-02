using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class FlyingObj
    {
        private int r;
        private Random rand = new Random();
        private bool alive;
        private Bitmap bitmap;
        private int X;
        private int Y;
        private Size size;
        Helper helper;
        private bool friend;
        private int timeToFire;




        public FlyingObj()
        {
            timeToFire = 10;
            X = rand.Next(100, 900);
            Y = rand.Next(50, 150);
            if (rand.Next(10)>7)
            {
                friend = true;
            }
            else
            {
                friend = false;
            }
                
        }
        public bool getIFF()
        {
            return friend;
        }

        public int TimeToFire
        {
            get { return timeToFire; }
            set { timeToFire = value; }
        }
        public int X_Axes
        {
            get { return X; }
            set { X = value; }
        }
        public int Y_Axes
        {
            get { return Y; }
            set { Y = value; }
        }

        public void Move()
        {
            r = rand.Next(10);
            if (r==1)
            {
                // turn right
                if(X>100)
                {
                    this.X-=4;
                }
            }
            else if (r == 2)
            {
                // turn left
                if (X < 900)
                {
                    this.X+=4;
                }
            }
            else if (r>7)
            {
                //go ahead
                this.Y+=5;
            }

        }

        internal void Dispose()
        {
            this.Dispose();
        }
    }
}
