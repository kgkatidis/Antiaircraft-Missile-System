using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class SystemAdjustments : Form
    {
        private Random rand1 = new Random();
        private int r1;
        private int r2;
        private int r3;
        private int r4;
        private int r5;
        private int r6;
        private MaintenanceControlSystem frmMCS;
        private MainScen mainScen;
        private Label problemAdj;
        private int rAP;

        private int c;      // take inform of which label has been selected
        private Label adjControl; // keeps the adjustment that can be changed

        public SystemAdjustments()
        {
            InitializeComponent();
            
            adjTimer.Start();
            adjTimer.Enabled = true;
        }
        public SystemAdjustments(MainScen mS)
        {
            InitializeComponent();
            adjTimer.Start();
            adjTimer.Enabled = true;
            mainScen = mS;
            frmMCS = new MaintenanceControlSystem(mainScen);
            c = 0;
            adjControl = new Label();
            rAP = rand1.Next(0, 5);         //random adjustment problem
        }

        public void setProblemAdj(Label l)
        {
            problemAdj = l;

            //problem in adjustment .....   lost
            problemAdj.Height = rand1.Next(rand1.Next(10, 20));
          
            problemAdj.Location = new Point(problemAdj.Location.X, horizontalAxe.Location.Y - problemAdj.Height);
        }

        public Label getAdj(int i)
        {
            switch (i)
            {
                case 1:
                    {
                        return adj1;
                    }
                case 2:
                    {
                        return adj2;
                    }
                case 3:
                    {
                        return adj3;
                    }
                case 4:
                    {
                        return adj4;
                    }
                case 5:
                    {
                        return adj5;
                    }
                case 6:
                    {
                        return adj6;
                    }
                default:
                    {
                        return null;
                    }
            }
        }

        // this methode finds the bottom level of the adjustments
        public int getDownPart(Label l)
        {
            int downPart = l.Size.Height + l.Location.Y;
            return downPart;
        }

        private void adjTimer_Tick(object sender, EventArgs e)
        {
           // if (mainScen.problemSolved())
            {
                r1 = rand1.Next(180, 190);
                r2 = rand1.Next(180, 190);
                r3 = rand1.Next(180, 190);
                r4 = rand1.Next(180, 190);
                r5 = rand1.Next(180, 190);
                r6 = rand1.Next(180, 190);

                adj1.Size = new Size(adj1.Size.Width, r1);
                adj1.Location = new Point(adj1.Location.X, horizontalAxe.Location.Y - r1);

                adj2.Size = new Size(adj2.Size.Width, r2);
                adj2.Location = new Point(adj2.Location.X, horizontalAxe.Location.Y - r2);

                adj3.Size = new Size(adj3.Size.Width, r3);
                adj3.Location = new Point(adj3.Location.X, horizontalAxe.Location.Y - r3);

                adj4.Size = new Size(adj4.Size.Width, r4);
                adj4.Location = new Point(adj4.Location.X, horizontalAxe.Location.Y - r4);

                adj5.Size = new Size(adj5.Size.Width, r5);
                adj5.Location = new Point(adj5.Location.X, horizontalAxe.Location.Y - r5);

                adj6.Size = new Size(adj6.Size.Width, r6);
                adj6.Location = new Point(adj6.Location.X, horizontalAxe.Location.Y - r6);
                
            }
            if (!mainScen.problemSolved())
            {
                // radar problem
                if (mainScen.getProblem()==0) 
                {
                    setProblemAdj(adj2);
                    if (!mainScen.problemSolved() && c == 2)
                    {
                        adjustThis(adj2);
                    }
                }
                else if (mainScen.getProblem() == 1)
                {
                    setProblemAdj(adj3);
                    if (!mainScen.problemSolved() && c == 3)
                    {
                        adjustThis(adj3);
                    }
                }
                else if (mainScen.getProblem() == 2)
                {
                    setProblemAdj(adj4);
                    if (!mainScen.problemSolved() && c == 4)
                    { 
                          adjustThis(adj4);
                     }
                }

                else if (mainScen.getProblem() <= 6)
                { 
                
                    // radar equipment problem
                }
                 // cs problem
                else if (mainScen.getProblem() == 7)
                {
                    setProblemAdj(adj1);
                    if(!mainScen.problemSolved() && c == 1)       
                    {
                        adjustThis(adj1);
                    }
                }
                else if (mainScen.getProblem() == 8)
                {
                     // cs equipment problem
                }
                // ls problem
                else if (mainScen.getProblem() == 9)
                {
                     setProblemAdj(adj5);
                     if (!mainScen.problemSolved() && c == 2)
                     {
                         adjustThis(adj5);
                     }
                }
                else if (mainScen.getProblem() == 10)
                {
                     setProblemAdj(adj6);
                     if (!mainScen.problemSolved() && c == 3)
                     {
                         adjustThis(adj6);
                     }
                } 
                            
                else                
                {
                     // ls equipment problem
                }
            }
        }
        

        private void SystemAdjustments_KeyDown(object sender, KeyEventArgs key)
        {
            switch (key.KeyCode)
            {
                case Keys.Escape:
                    {
                        this.Hide();
                        frmMCS.Show();
                        break;
                    }
            }
        }

        //adjust the selected label (adjustment)
        public void adjustThis(Label l)
        {
            adjTimer.Stop();
            adjTimer.Enabled = false;
            adjControl = l;
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SystemAdjustments_KeyPress);
        }

        // you may adjust sth by clicking on its label
        public void setAdj(Label l)
        {
            switch (c)
            {
                case 1:
                    {
                        adj1 = l;
                        break;
                    }
                case 2:
                    {
                        adj2 = l;
                        break;
                    }
                case 3:
                    {
                        adj3 = l;
                        break;
                    }
                case 4:
                    {
                        adj4 = l;
                        break;
                    }
                case 5:
                    {
                        adj5 = l;
                        break;
                    }
                case 6:
                    {
                        adj6 = l;
                        break;
                    }

            }
        }

        
        private void SystemAdjustments_KeyPress(object sender, KeyPressEventArgs e)
        {

            Label lS = new Label();
            lS.Size = new Size(adj1.Size.Width, r1);  // 
            switch (e.KeyChar)
            {
                case (Char)Keys.U:
                    {   if ((adjControl.Size.Height <= lS.Size.Height+5) && (adjControl.Size.Height >= lS.Size.Height - 5))
                        {
                            // adj is ok
                            mainScen.solveProblem();
                            adjTimer.Start();
                            adjTimer.Enabled = true;
                        }
                        else
                        {
                            adjControl.Size = new Size(adjControl.Size.Width, adjControl.Size.Height + 1);
                            adjControl.Location = new Point(adjControl.Location.X, horizontalAxe.Location.Y - adjControl.Height);
                            setAdj(adjControl);
                        }
                        break;
                    }
                case (Char)Keys.D:
                    {
                        if ((adjControl.Size.Height <= lS.Size.Height + 5) && (adjControl.Size.Height >= lS.Size.Height - 5))
                        {
                            // adj is ok
                            mainScen.solveProblem();
                        }
                        else
                        {
                            adjControl.Size = new Size(adjControl.Size.Width, adjControl.Size.Height - 1);
                            adjControl.Location = new Point(adjControl.Location.X, horizontalAxe.Location.Y - adjControl.Height);
                            setAdj(adjControl);
                        }
                        break;
                    }
            }
        }

        // 
        private void adj1_Click(object sender, EventArgs e)
        {
            if ((adj1.Size.Height <= 160) || (adj1.Size.Height >= 180))
            {
                c = 1;
            }
        }

        private void adj2_Click(object sender, EventArgs e)
        {
            if ((adj2.Size.Height <= 160) || (adj2.Size.Height >= 180))
            {
                c = 2;
            }
        }

        private void adj3_Click(object sender, EventArgs e)
        {
            if ((adj3.Size.Height <= 160) || (adj3.Size.Height >= 180))
            {
                c = 3;
            }
        }

        private void adj4_Click(object sender, EventArgs e)
        {
            if ((adj4.Size.Height <= 160) || (adj4.Size.Height >= 180))
            {
                c = 4;
            }
        }

        private void adj5_Click(object sender, EventArgs e)
        {
            if ((adj5.Size.Height <= 160) || (adj5.Size.Height >= 180))
            {
                c = 5;
            }
        }

        private void adj6_Click(object sender, EventArgs e)
        {
            if ((adj6.Size.Height <= 160) || (adj6.Size.Height >= 180))
            {
                c = 6;
            }
        }
    }
}
