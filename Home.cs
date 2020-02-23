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
    public partial class Home : Form
    {
        private int tenSec;
        public Home()
        {
            InitializeComponent();
        }

        private void sureBtn_Click(object sender, EventArgs e)
        {
            if (tacticalCheck.Checked && !maintenanceCheck.Checked)
            {
                this.Hide();
                var frm = new TacticalScenarios();
                frm.Show();
            }
            else if (!tacticalCheck.Checked && maintenanceCheck.Checked)
            {
                this.Hide();
                var frm = new MaintenanceControlSystem();
                frm.Show();
            }
            else if (!tacticalCheck.Checked && !maintenanceCheck.Checked)
            {
                {
                    this.checkMsg.Text = "Please check . . . ";
                    this.checkMsg.Visible = true;
                }
            }
            else
            {
                this.checkMsg.Text = "check ONLY ONE. . . ";
                this.checkMsg.Visible = true;
            }
        }
    }
}
