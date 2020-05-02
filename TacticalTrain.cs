using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class TacticalTrain : Form
    {
        private int scenNumber;
        private bool gameOver;
        private bool fault;
        private bool biggerScore;
        private bool smallerScore;
        private bool canKill;
        private int currentTime;
        private int startTime;
        Random rand = new Random();
        private int totalTime;
        Helper helper;
        PictureBox p;
        PictureBox target;
        FlyingObj fO;
        List<FlyingObj> planes;
        List<PictureBox> planePictures;
        int score;


        public TacticalTrain()
        {
            InitializeComponent();
        }

        public TacticalTrain(int i)
        {
            InitializeComponent();
            scenNumber = i;
            gameOver = false;
            fault = false;
            biggerScore = false;
            smallerScore = false;
            canKill = true;
            helper = new Helper();
            LoadMap();

            // start of the game
            gameTimer.Start();
            gameTimer.Enabled = true;
            targetUpdate.Start();
            targetUpdate.Enabled = true;
            totalTime = 0;
            planes = new List<FlyingObj>();
            planePictures = new List<PictureBox>();
            score = 0;

        }

        private void LoadMap()
        {
            
            switch (scenNumber)
            {
                case 1:
                    {
                        this.BackgroundImage = helper.LoadBitmap("Bleast.png");
                        this.Text = "Training Over Blueland East";
                        break;
                    }
                case 2:
                    {
                        this.BackgroundImage = helper.LoadBitmap("Blwest.png");
                        this.Text = "Training Over Blueland West";
                        break;
                    }
                case 3:
                    {
                        this.BackgroundImage = helper.LoadBitmap("Sarabian.png");
                        this.Text = "Training Over Sarabian North";
                        break;
                    }
                case 4:
                    {
                        this.BackgroundImage = helper.LoadBitmap("Hotlib.png");
                        this.Text = "Training Over Hotlib North";
                        break;
                    }
            }
        }

        private void TacticalTrain_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen p = new Pen(Color.Lime, 4);
            g.DrawLine(p, 20, 150, this.Width/2, this.Height-50);
            g.DrawLine(p, this.Width/2, this.Height - 50, this.Width-20, 150);
        }

        private void TacticalTrain_Load(object sender, EventArgs e)
        {
           
            Cursor.Dispose();
            target = new PictureBox();
            target.Location = new System.Drawing.Point(this.Width / 2, this.Height / 2);
            target.Size = new System.Drawing.Size(32, 32);

            target.BackColor = Color.Transparent;
            target.Image = helper.LoadBitmap("Target.png");
            Controls.Add(target);
            Main();
        }

        private void TacticalTrain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Shutdown();
        }

        private void Main()
        {
            
            while (scenNumber < 1)
            {
                // Wait to Tactical Scenarios Form ... until Load Scenario 
            }

//          while (!gameOver)
            {

                //update timer
                currentTime = Environment.TickCount;

                //refresh at 60 FPS
                if (currentTime > startTime + 16)
                {
                    //update timing 
                    startTime = currentTime;

                    //give the form some cycles 
                    Application.DoEvents();        

                    //let the game object update
                    UpdateScen();
                }
                
            }
            //free memory and shut down
//             quit();
//             Application.Exit();
        }

        private void UpdateScen()
        {
            CheckForNewPlanes(scenNumber);
            movePlanes();
            if (!fault)
            {
                CheckForFault();
            }
            updateScore();

            foreach (PictureBox pb1 in planePictures)
            {
                foreach (PictureBox pb2 in planePictures)
                {
                    if (pb1.Location!=pb2.Location)
                    {
                        Helper.OverlayPictures(pb1,pb2);
                    }
                }
            }
        }
        private void CheckForFault()
        {
            int r = rand.Next(10000);
            if (r<6) // possibility of each map for an aircraft to be appeared. e.g. P(Bleast) < P(Hotlib)
            {
                if (r == 0)
                {
                    go1.Text = "DEG";
                }
                else if (r == 1)
                {
                    go1.Text = "NOGO";
                }
                else if (r == 2)
                {
                    go2.Text = "DEG";
                }
                else if (r == 3)
                {
                    go2.Text = "NOGO";
                }
                else if (r == 4)
                {
                    go3.Text = "DEG";
                }
                else
                {
                    go3.Text = "NOGO";
                }
                if (r % 2 == 0)
                {
                    biggerScore = true;
                }
                else
                {
                    smallerScore = true;
                }
                
                fault = true;
            }
        }

        private void moveTarget()
        {
            target.Location = new System.Drawing.Point(MousePosition.X-150,MousePosition.Y-150);
        }

        private void CheckForNewPlanes(int i)
        {
            if (i>totalTime%10) // possibility of each map for an aircraft to be appeared. e.g. P(Bleast) < P(Hotlib)
            {
                
                p = new PictureBox();

                fO = new FlyingObj();
                p.Location = new System.Drawing.Point(fO.X_Axes, fO.Y_Axes);
                p.Size = new System.Drawing.Size(32, 32);
              
                p.BackColor = Color.Transparent;
                p.Image = helper.LoadBitmap("PlaneFront.png");
                Controls.Add(p);
                
       //         p.Parent = target;

                planes.Add(fO);
                planePictures.Add(p);

                

            }
        }

        private void movePlanes()
        {
            int i = 0;
            foreach (FlyingObj plane in planes)
            {
                plane.Move();
                planePictures[i].Location = new System.Drawing.Point(planes[i].X_Axes, planes[i].Y_Axes);
                i++;
            }
            
        }

        public void quit()
        { 
            this.BackgroundImage = null;
            this.Hide();
        }
        private void Shutdown()
        {

        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            totalTime += gameTimer.Interval/1000;
            this.timeLabel.Text = "Time: "+ totalTime;
            this.scoreBoard.Text = "Score: " + score;

            // Update Scenario ...
            UpdateScen();
        }
        private void updateScore()
        {
            if (biggerScore)
            {
                score += 1;
            }
            else if (smallerScore)
            {
                score -= 5;
                canKill = false;
            }
        }

        private void engagePlane()
        {
            int i = 0;
            foreach (PictureBox pB in planePictures)
            {
               if (planePictures[i].Location.X>target.Location.X-5 && planePictures[i].Location.X < target.Location.X + 5 && planePictures[i].Location.Y > target.Location.Y - 5 && planePictures[i].Location.Y < target.Location.Y + 5)
                {
                    if (planes[i].getIFF())
                    {
                        planePictures[i].Image = helper.LoadBitmap("PlaneBlue.png");
                    }
                    else
                    {
                        planePictures[i].Image = helper.LoadBitmap("PlaneRed.png");
                    }
                }
                i++;
            }
        }

        private void killPlane()
        {
            int i = 0;
            foreach (PictureBox pB in planePictures)
            {
                if (planePictures[i].Location.X > target.Location.X - 5 && planePictures[i].Location.X < target.Location.X + 5 && planePictures[i].Location.Y > target.Location.Y - 5 && planePictures[i].Location.Y < target.Location.Y + 5)
                {
               //     planePictures.Remove(planePictures[i]);
                    planePictures[i].Dispose();
                    if (planes[i].getIFF())
                    {
                        score -= 500;
                        // a friendly aircraft has been killed
                    }
                    else
                    {
                        score += 10;
                        // a foe has been killed
                    }
                    planes.Remove(planes[i]);

                }
                i++;
            }
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            moveTarget();

           
        }

        private void TacticalTrain_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F:
                    {
                        engagePlane();
                        break;
                    }
                case Keys.G:
                    {
                        if (canKill)
                        {
                            killPlane();
                        }
                        break;
                    }
            }
            
        }
    }
}
