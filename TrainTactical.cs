using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class TrainTactical : Form
    {
        private int scenNumber;
        private Bitmap background;
        private GamePlay gp;
        private bool gameOver;
        private Asset target;
        private Asset aircraft;
        private List<Asset> aircrafts;
        private List<FlyingObj> planes;
        private Asset standBy;
        private int totalTime;
        private bool biggerScore;
        private bool smallerScore;
        private int score;
        private bool fault;
        Random rand = new Random();
        FlyingObj fO;
        private bool canKill;
        Pen limePen;

        PaintEventArgs lines;

        public TrainTactical() => InitializeComponent();

        public TrainTactical(int i)     // choosing the scen number on loading
        {
            InitializeComponent();
            scenNumber = i;
            background = new Bitmap("Bleast.png");
            gameOver = false;
            aircrafts = new List<Asset>();
            planes = new List<FlyingObj>();
            totalTime = 0;
            biggerScore = false;
            smallerScore = false;
            score = 0;
            fault = false;
            canKill = true;
            limePen = new Pen(Color.Lime, 3);
        }

        private Asset InitializeAsset(Asset a, string filename, GamePlay gp)
        {
            Asset asset = new Asset(ref gp);
            asset.Image = gp.LoadBitmap(filename);
            asset.Image.MakeTransparent(Color.White);
            asset.Width = 32;
            asset.Height = 32;
            asset.Columns = 1;
            asset.TotalFrames = 1;
            asset.AnimationRate = 0; // no need 

            return asset;
        }

        private void TrainTactical_Load(object sender, EventArgs e)
        {
            Cursor.Hide(); // cursor doesn't need to be appeared
            Form form = (Form)this;
            gp = new GamePlay(ref form, this.Width, this.Height);      // inititate scenario screen
            LoadMap(); // Load Scenario ...

            quickTimer.Start();
            quickTimer.Enabled = true;
            CentralTimer.Start();
            CentralTimer.Enabled = true;
        }

        private void LoadMap()
        {
           
            switch (scenNumber)
            {
                case 1:
                    {
                        background = gp.LoadBitmap("Bleast.png");
                        this.Text = "Training Over Blueland East";
                        break;
                    }
                case 2:
                    {
                        background = gp.LoadBitmap("Blwest.png");
                        this.Text = "Training Over Blueland West";
                        break;
                    }
                case 3:
                    {
                        background = gp.LoadBitmap("Sarabian.png");
                        this.Text = "Training Over Sarabian North";
                        break;
                    }
                case 4:
                    {
                        background = gp.LoadBitmap("Hotlib.png");
                        this.Text = "Training Over Hotlib North";
                        break;
                    }
            }

            // initialize target
            target = InitializeAsset(target, "Target.png", gp);
            target.X = this.Width / 2;
            target.Y = this.Height / 2;
        }
       
        private void UpdateScen()
        {
            {
                //move planes
                CheckForNewPlanes(scenNumber);
                movePlanes();
                if (!fault)
                {
                    CheckForFault();
                }
                updateScore();
            }
        }

        private void CheckForNewPlanes(int i)
        {

            if (i > totalTime % 10) // possibility of each map for an aircraft to be appeared. e.g. P(Bleast) < P(Hotlib)
            {
                aircraft=InitializeAsset(aircraft, "PlaneFront.png", gp);
                
                fO = new FlyingObj();
                
                aircraft.X = fO.X_Axes;
                aircraft.Y = fO.Y_Axes;


                planes.Add(fO);
                aircrafts.Add(aircraft);
            }
        }

        private void CheckForFault()
        {
            int r = rand.Next(10000);
            if (r < 6)
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

        private void movePlanes()
        {
            int i = 0;
            foreach (FlyingObj plane in planes)
            {
                plane.Move();
                aircrafts[i].X = planes[i].X_Axes;
                aircrafts[i].Y = planes[i].Y_Axes;

                i++;
            }
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
        
        private void TrainTactical_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F:
                    {
                        if (go2.Text == "NOGO")
                        {
                            // RS not working --> can't recognize
                            break;
                        }
                        engagePlane();
                        break;
                    }
                case Keys.G:
                    {
                        if (go1.Text == "NOGO" || go1.Text == "NOGO")
                            // CS or LS not working --> can't kill
                        {
                            break;
                        }
                        if (canKill)
                        {
                            killPlane();
                        }
                        break;
                    }
                case Keys.Q:
                    {
                        // Exit
                        if (go1.Text == "NOGO" || go2.Text == "NOGO" || go3.Text == "NOGO")
                        {
                            // bonus of correct decision
                            score += 500;
                        }
                        gameOver = true;
                        cleanMem();
                        // GAME OVER
                        this.Hide();
                        GameOver frm = new GameOver(score);
                        frm.ShowDialog();
                        break;
                    }
            }
        }

        private void engagePlane()
        {
            int i = 0;
            foreach (Asset craft in aircrafts)
            {
                if (aircrafts[i].IsColliding(ref target))
                    {
                    if (planes[i].getIFF())
                    {
                        aircrafts[i].Image = gp.LoadBitmap("PlaneBlue.png");
                    }
                    else
                    {
                        aircrafts[i].Image = gp.LoadBitmap("PlaneRed.png");
                    }
                }
                i++;
            }
        }
        private void killPlane()
        {
            int i = 0;
            foreach (Asset craft in aircrafts)
            {
                if (aircrafts[i].IsColliding(ref target))
                {
                    aircrafts.Remove(aircrafts[i]);            // remove from pictureList
                    craft.DisposeIt();                         // remove the aircraft asset
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
                    planes.Remove(planes[i]);                   // remove from palne-characteristicsList
                    break;
                }
                i++;
            }
        }

        private void CentralTimer_Tick(object sender, EventArgs e)
        {
            totalTime += CentralTimer.Interval / 1000;
            this.timeLabel.Text = "Time: " + totalTime;
            this.scoreBoard.Text = "Score: " + score;
            
            UpdateScen();
            int i = 0;
            foreach (FlyingObj plane in planes)
            {
                if (plane.TimeToFire > 1)
                {
                    plane.timeDown();
                }
                else
                {
                    if (!plane.getIFF())
                    {
                        if (!gameOver)
                        {
                            gameOver = true;
                            cleanMem();
                            // GAME OVER
                            this.Hide();
                            GameOver frm = new GameOver(score);
                            frm.ShowDialog();
                        }
                    }
                    else
                    {
                        // end of friendly aircraft flight
                        plane.Dispose();
                        aircrafts[i].DisposeIt();
                    }
                }
                i++;   
            }
        }

        private void moveTarget()
        {
            target.X = MousePosition.X-200;
            target.Y = MousePosition.Y-200;
        }

        private void quickTimer_Tick(object sender, EventArgs e)
        {
            //draw background
            gp.DrawBitmap(ref background, 0, 0, this.Width, this.Height);

            //draw target
            moveTarget();
            target.Draw();

            // update game object
            gp.Update();
            
            // draw aircrafts
            foreach (Asset craft in aircrafts)
            {
                craft.Draw();
            }
        }

        private void cleanMem()
        {
            CentralTimer.Stop();
            CentralTimer.Enabled = false;
            quickTimer.Stop();
            quickTimer.Enabled = false;

            target.DisposeIt();
            foreach (Asset craft in aircrafts)
            {
                craft.DisposeIt();
            }
            
        }
        
    }
}
