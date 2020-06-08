using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Home : Form
    {
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
        

        private void infoBtn2_Click(object sender, EventArgs e)
        {
            var frm = new InfoMaintenance();
            this.Hide();
            frm.Show();
        }

        private void infoBtn1_Click(object sender, EventArgs e)
        {
            var frm = new InfoTactical();
            this.Hide();
            frm.Show();
        }
    }
}
