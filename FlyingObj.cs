using System;
using System.Drawing;

namespace WindowsFormsApp1
{
    public class FlyingObj
    {
        private int r;
        private Random rand = new Random();
        private int X;
        private int Y;
        private bool friend;
        private int timeToFire;




        public FlyingObj()
        {
            timeToFire = 60;
            X = rand.Next(100, 700);
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
                if (X < 800)
                {
                    this.X+=4;
                }
            }
            else if (r>3)
            {
                //go ahead
                this.Y+=7;
            }

        }
        public void timeDown()
        {
            timeToFire--;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
