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
    public partial class SystemAdjustments : Form
    {
        private Random rand1 = new Random();
        private int r1;
        private int r2;
        private int r3;
        private int r4;
        private int r5;
        private int r6;

        public SystemAdjustments()
        {
            InitializeComponent();
            adjTimer.Start();
            adjTimer.Enabled = true;
        }

        private void adjTimer_Tick(object sender, EventArgs e)
        {
            MainScen mainScen = new MainScen();

            if (mainScen.problemSolved())
            {
                r1 = rand1.Next(180, 190);
                r2 = rand1.Next(180, 190);
                r3 = rand1.Next(180, 190);
                r4 = rand1.Next(180, 190);
                r5 = rand1.Next(180, 190);
                r6 = rand1.Next(180, 190);

                adj1.Size = new Size(10, r1);
                adj2.Size = new Size(10, r2);
                adj3.Size = new Size(10, r3);
                adj4.Size = new Size(10, r4);
                adj5.Size = new Size(10, r5);
                adj6.Size = new Size(10, r6);

                adj1.Location = new Point(168, 351 - r1);
                adj2.Location = new Point(256, 351 - r2);
                adj3.Location = new Point(344, 351 - r3);
                adj4.Location = new Point(432, 351 - r4);
                adj5.Location = new Point(520, 351 - r5);
                adj6.Location = new Point(608, 351 - r6);
            }
            else
            {
                // ΚΩΔΙΚΑΣ ΜΕ ΠΡΟΒΛΗΜΑΤΙΚΕΣ ΡΥΘΜΙΣΕΙΣ ....... !!!!!!!!!!!!!!!!!! 
            }
            
        }
    }
}
