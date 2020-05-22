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

        public Helper()
        {


        }
        ~Helper()
        {
        }
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

        public Bitmap LoadBitmap(string filename, int i)
        {
            Bitmap bmp = null;
            try
            {
                bmp = new Bitmap(filename);
                bmp.MakeTransparent();
            }
            catch (Exception ex) { }
            return bmp;
        }




        // Make picturebox transparent over the others (Two methods)

        public static void OverlayPictures(Bitmap back, Bitmap front, int dx, int dy)
        {
            for (int y = 0; y < front.Height; y++)
            {
                for (int x = 0; x < front.Width; x++)
                {
                    if (front.GetPixel(x, y).A < 255)
                    {
                        Color newColor = back.GetPixel(x + dx, y + dy);
                        front.SetPixel(x, y, newColor);
                    }
                }
            }

        }
        public static void OverlayPictures(PictureBox back, PictureBox front)
        {
            //   if ((back.Location.X + back.Width >= front.Location.X && back.Location.X <= front.Location.X + front.Width) || (back.Location.Y + back.Height >= front.Location.Y & back.Location.Y <= front.Location.Y + front.Height))
            {

                int leftDifference = Math.Abs(back.Left - front.Left);
                int topDifference = Math.Abs(back.Top - front.Top);
                //     if (leftDifference < back.Width && leftDifference < front.Width && topDifference < back.Height && topDifference < front.Height)
                {
                    OverlayPictures((Bitmap)back.Image, (Bitmap)front.Image, leftDifference, topDifference);
                }
            }

        }
        public void imageConstruction(PictureBox myPictureBox, int width, int height, Image imageBack, Image imageFront)
        {
            Image image = new Bitmap(width, height);

            using (var graphics = Graphics.FromImage(image))
            {
                graphics.DrawImage(imageBack, new Rectangle(0, 0, width, height));
                graphics.DrawImage(imageFront, new Rectangle(0, 0, width, height));
            }

            myPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            myPictureBox.Image = image;
        }
        // My PictureBox (Image without picturebox)

    }


}
