using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using WindowsFormsApp1;
using System.Drawing.Drawing2D;

namespace WindowsFormsApp1
{
    public partial class TacticalTraining : Form
    {
        
        public int scenNumber = 0;
        public TacScen tacScen;

        public Bitmap background;

        public Sprite cannon;
        public Bitmap cannonImage;
        private int cannonAngle;

        private bool p_gameOver = false;
        private int p_startTime = 0;
        private int p_currentTime = 0;




        public int frameCount = 0;
        public int frameTimer = 0;
        public float frameRate = 0;
        public PointF velocity;
        private int speed = 0;
        public int direction = 0;

        public TacticalTraining()
        {
            InitializeComponent();
        }

        private void TacticalTraining_Load(object sender, EventArgs e)
        {
            Main();
        }
        

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Shutdown();
        }
    


        public bool Game_Init()
        {
           
            
            switch (scenNumber)
            {
                case 1:
                    {
                        
                        background = tacScen.LoadBitmap("Bleast.png");
                        this.Text = "Training Over Blueland East";
                        break;
                    }
                case 2:
                    {
                        background = tacScen.LoadBitmap("Blwest.png");
                        this.Text = "Training Over Blueland West";
                        break;
                    }
                case 3:
                    {
                        background = tacScen.LoadBitmap("Sarabian.png");
                        this.Text = "Training Over Sarabian North";
                        break;
                    }
                case 4:
                    {
                        background = tacScen.LoadBitmap("Hotlib.png");
                        this.Text = "Training Over Hotlib North";
                        break;
                    }
            }

            cannonImage = tacScen.LoadBitmap("Cannon.png");
            cannon = new Sprite(ref tacScen);
            cannon.Image = cannonImage;
            cannon.Width = 256;
            cannon.Height = 256;
            cannon.Columns = 1;
            cannon.TotalFrames = 1;
            cannon.AnimationRate = speed * 6;
            cannon.X = (this.Width/2)+(cannon.Width/2);
            cannon.Y = this.Height-cannon.Height;
            
            return true;
        }

        public void Game_Update(int time)
        {

           
        }

        public void Game_Draw()
        {
            //draw background

            tacScen.DrawBitmap(ref background, 0, 0, 1024, 728);


            // draw sprites (with their animations or not)

            cannon.Draw();



        }

        public void Game_End()
        {
            //background = null;
            // gameSoundTrack = null;

            cannon.X = 99999;
           

        }

        public void quit()
        {
            background = null;
           
            cannon = null;
          
            this.Hide();
        }

        public void Game_KeyPressed(System.Windows.Forms.Keys key)
        {

        }
        public void addPoints()
        {

        }
        public void subPoints()
        {

        }


        public void Shutdown()
        {

        }

        //*******************************************
        //real time game loop
        //*******************************************
        public void Main()
        {
            while (scenNumber<1)
            {
                // Wait to Tactical Scenarios Form ... until Load Scenario 
            }

            Form form = (Form)this;
            tacScen = new TacScen(ref form, 1024, 728);

            //load and initialize game assets
            Game_Init();

            while (!p_gameOver)
            {
                //update timer
                p_currentTime = Environment.TickCount;
                //let gameplay code update 
                Game_Update(p_currentTime - p_startTime);
                //refresh at 60 FPS
                if (p_currentTime > p_startTime + 16)
                {
                    //update timing 
                    p_startTime = p_currentTime;

                    //let gameplay code draw
                    Game_Draw();
                    //give the form some cycles 
                    Application.DoEvents();

                    //let the game object update
                    tacScen.Update();
                }

                frameCount += 1;
                if (p_currentTime > frameTimer + 1000)
                {
                    frameTimer = p_currentTime;
                    frameRate = frameCount;
                    frameCount = 0;
                }
            }
            //free memory and shut down
            quit();
            Application.Exit();
        }
        

        private void TacticalTraining_KeyDown(object sender, KeyEventArgs e)
        {

        }

  /*      private void TacticalTraining_Leave(object sender, EventArgs e)
        {
            Shutdown();
        }
*/
        private void TacticalTraining_MouseMove(object sender, MouseEventArgs e)
        {
 //         if (MousePosition.X>cannon.X)
            {
                // rotate cannon right
               
            }
 //           else
            {
 //               RotateImage(cannonImage, -1);
                // rotate cannon left
            }
        }
        public static Image RotateImage(Image img, float rotationAngle)
        {
            //create an empty Bitmap image
            Bitmap bmp = new Bitmap(img.Width, img.Height);

            //turn the Bitmap into a Graphics object
            Graphics gfx = Graphics.FromImage(bmp);

            //now we set the rotation point to the center of our image
            gfx.TranslateTransform((float)bmp.Width / 2, (float)bmp.Height / 2);

            //now rotate the image
            gfx.RotateTransform(rotationAngle);

            gfx.TranslateTransform(-(float)bmp.Width / 2, -(float)bmp.Height / 2);

            //set the InterpolationMode to HighQualityBicubic so to ensure a high
            //quality image once it is transformed to the specified size
            gfx.InterpolationMode = InterpolationMode.HighQualityBicubic;

            //now draw our new image onto the graphics object
            gfx.DrawImage(img, new Point(0, 0));

            //dispose of our Graphics object
            gfx.Dispose();

            //return the image
            return bmp;
        }
    }
}
