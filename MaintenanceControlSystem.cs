using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{

    public partial class MaintenanceControlSystem : Form
    {
        int dtStop = 0;
        private MainScen mainScen;
        private Form frmCM;
        private Form frmSA;

        public MaintenanceControlSystem()
        {
            InitializeComponent();
            mainScen = new MainScen();

            frmCM = new ConfigurationManagement(mainScen);
            frmSA = new SystemAdjustments(mainScen);
        }
        public MaintenanceControlSystem(MainScen mS)
        {
            InitializeComponent();
            mainScen = mS;
        }

        public void setSomething(int a, int  b)
        {
            a = b;
        }

        private void runBtn_Click(object sender, EventArgs e)
        {
            // End of diagnostics runninng
            if (this.runBtn.Text == "Back")   
            {
                this.checkMsg.Visible = false;
                this.title.Text = "Maintenance Control System Training";
                this.checkedListBox1.Visible = true;
                this.checkMsg.Text = "Diagnostics are running.\r\nPlease wait . . ."; // location of checkMsg is (0,200)
                this.checkMsg.Location = new Point(0, 340);
                this.checkMsg.Font = new Font("Arial", 12, FontStyle.Regular);
                this.runBtn.Text = "Run";
                this.checkedListBox1.SetItemChecked(0, false);
            }
            else
            {

                if (this.checkedListBox1.CheckedItems.Count > 1)
                {
                    this.checkMsg.Text = "check ONLY ONE. . . ";
                    this.checkMsg.Visible = true;
                }
                else if (this.checkedListBox1.CheckedItems.Count < 1)
                {
                    this.checkMsg.Text = "Please check . . . ";
                    this.checkMsg.Visible = true;
                }
                else
                {
                    if (this.checkedListBox1.GetItemChecked(1))
                    {
                        this.Hide();
                        var frmCM = new ConfigurationManagement(mainScen);
                        frmCM.Show();
                    }
                    else if (this.checkedListBox1.GetItemChecked(0))
                    {
                        this.title.Text = "System Diagnostics";
                        this.checkedListBox1.Visible = false;
                        this.checkMsg.Text = "Diagnostics are running.\r\nPlease wait . . ."; // location of checkMsg is (0,349)
                        this.checkMsg.Location = new Point(0, 200);
                        this.checkMsg.Font = new Font("Arial", 18, FontStyle.Bold);
                        this.checkMsg.Visible = true;
                        this.runBtn.Text = "Back";
                        diagnosticsTimer.Start();
                        diagnosticsTimer.Enabled = true;
                    }
                    else  // this.checkedListBox1.GetItemChecked(2)
                    {
                        this.Hide();
                        var frmSA = new SystemAdjustments(mainScen);
                            frmSA.Show();
                    }
                }
            }
        }

        private void diagnosticsTimer_Tick(object sender, EventArgs e)
        {
            dtStop++;
            if (dtStop < 10)
            {
                // flashing text 
                if (this.checkMsg.Visible == false)
                    this.checkMsg.Visible = true;
                else
                    this.checkMsg.Visible = false;
            }
            else
            {
                diagnosticsTimer.Stop();
                if (mainScen.problemSolved())
                {
                    this.checkMsg.Text = "The System is ready to fire!";
                    this.checkMsg.Visible = true;
                }
                else
                {
                    this.checkMsg.Text = "Diagnosted a Problem in ";
                    if (mainScen.getProblem() <= 6)
                    {
                        this.checkMsg.Text += "Radar System";
                        if (mainScen.getProblem() == 3 || mainScen.getProblem() == 4)
                        {
                            this.checkMsg.Text += " (TWT1) ";
                        }
                        else if (mainScen.getProblem() == 5 || mainScen.getProblem() == 6)
                        {
                            this.checkMsg.Text += " (TWT2) ";
                        }
                    }
                    else if (mainScen.getProblem() <= 8)
                    {
                        this.checkMsg.Text += "Command Station";
                        if (mainScen.getProblem() == 8)
                        {
                            this.checkMsg.Text += " (Circuit Card Assy) ";
                        }
                    }
                    else
                    {
                        this.checkMsg.Text += "Launching System";
                        if (mainScen.getProblem() <= 12)
                        {
                            this.checkMsg.Text += " (Power Supply) ";
                        }
                    }

                    this.checkMsg.Text += "\r\n Go Back to configure your System or get extra information \r\n from system adjustments";
                    this.checkMsg.Visible = true;
                }
            }

        }

        // Restart (New Scenario)
        private void button1_Click(object sender, EventArgs e)
        {
            var frmMCS = new MaintenanceControlSystem();
            this.Hide();
            frmMCS.Show();
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            var frm = new Home();
            this.Hide();
            frm.Show();
        }
    }
}


