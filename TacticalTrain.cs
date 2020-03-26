using System;
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
        private int currentTime;
        private int startTime;
        Random rand = new Random();

        public TacticalTrain()
        {
            InitializeComponent();
        }

        public TacticalTrain(int i)
        {
            InitializeComponent();
            scenNumber = i;
            gameOver = false;
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
                    Application.DoEvents();          //    TI KANEI AYTO ???????????????????

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
            CheckForNewPlanes();

        }

        private void CheckForNewPlanes()
        {
            
        }

        public void quit()
        { 
            this.BackgroundImage = null;
            this.Hide();
        }
        private void Shutdown()
        {

        }

    }
}
