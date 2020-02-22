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

    public partial class MaintenanceContrrolSystem : Form
    {
        int dtStop = 0;

        public MaintenanceContrrolSystem()
        {
            InitializeComponent();

        }

        public void setSomething(int a, int  b)
        {
            a = b;
        }

        private void runBtn_Click(object sender, EventArgs e)
        {
            // End of diagnostics runninng

            if (this.runBtn.Text == "Back")    // SOS ΝΑ ΜΠΕΙ ΧΡΟΝΟΜΕΤΡΗΣΗ 
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
                        var frm = new ConfigurationManagement();
                        frm.Show();
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
                    else
                    {
                        this.Hide();
                        var frm = new SystemAdjustments();
                        frm.Show();
                    }
                }
            }
        }

        private void diagnosticsTimer_Tick(object sender, EventArgs e)
        {
            dtStop++;
            if (dtStop < 4)
            {
                if (this.checkMsg.Visible == false)
                    this.checkMsg.Visible = true;
                else
                    this.checkMsg.Visible = false;
            }
            else
            {
                diagnosticsTimer.Stop();
                MainScen mainScen = new MainScen();
                this.checkMsg.Text = "Diagnosted a Problem in ";
                switch (mainScen.getProblem())
                {
                    case 0:
                        {
                            this.checkMsg.Text += "Radar System";
                            break;
                        }
                    case 1:
                        {
                            this.checkMsg.Text += "Command Station";
                            break;
                        }
                    case 2:
                        {
                            this.checkMsg.Text += "Launching System";
                            break;
                        }
                }
                this.checkMsg.Text += "\r\n Go Back to configure your System or get extra information \r\n from system adjustments";
                this.checkMsg.Visible = true;
            }
        }
    }
}


