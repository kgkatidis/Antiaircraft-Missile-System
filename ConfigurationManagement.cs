using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ConfigurationManagement : Form
    {
        private MainScen mainScen;
        private MaintenanceControlSystem frmMCS;
        public ConfigurationManagement()
        {
            InitializeComponent();
        }
        public ConfigurationManagement(MainScen mS)
        {
            InitializeComponent();
            mainScen = mS;
            frmMCS = new MaintenanceControlSystem(mainScen);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((this.button1.Text == "Update") && (comboBox1.SelectedIndex > -1 || comboBox2.SelectedIndex > -1 || comboBox3.SelectedIndex > -1))
            {
                this.button1.Text = "Validate";
                this.label4.Text = null;
            }
            else if (this.button1.Text == "Validate")
            {
                if (mainScen.getProblem() == 3 || mainScen.getProblem() == 4)
                {
                    if (comboBox1.SelectedIndex < 4)                     // TWT1 Serial Numbers
                    {
                        mainScen.solveProblem();
                    }
                }
                else if (mainScen.getProblem() == 5 || mainScen.getProblem() == 6)
                {
                    if (comboBox1.SelectedIndex > 3)                      // TWT2 Serial Numbers
                    {
                        mainScen.solveProblem();
                    }
                }
                else if (mainScen.getProblem() ==8 && comboBox3.SelectedIndex > 3)    // index 4 and above are CCAs after implementation
                {
                    mainScen.solveProblem();
                }

                else if (mainScen.getProblem() >10 && comboBox2.SelectedIndex > -1)   // all Power Supplies are similar
                                                                                           {
                    mainScen.solveProblem();
                }
                
                this.Hide();
                frmMCS.Show();
            }
        }
       
        private void removeTwtText(object sender, EventArgs e)
        {
            infoText.Text = "Hover ? to view info";
            twtText.Visible = false;
        }
        private void addTwtText(object sender, EventArgs e)
        {
            infoText.Text = "Click ? to view info";
            twtText.Text = "about TWT \r\n Gereral & Replacement";
            twtText.Visible = true;
        }
        private void removepsText(object sender, EventArgs e)
        {
            infoText.Text = "Hover ? to view info";
            twtText.Visible = false;
        }
        private void addpsText(object sender, EventArgs e)
        {
            infoText.Text = "Click ? to view info";
            twtText.Text = "about Power Supply \r\n Gereral & Replacement";
            twtText.Visible = true;
        }
        private void removeCcaText(object sender, EventArgs e)
        {
            infoText.Text = "Hover ? to view info";
            twtText.Visible = false;
        }
        private void addCcaText(object sender, EventArgs e)
        {
            infoText.Text = "Click ? to view info";
            twtText.Text = "about Circuit Card Assembly \r\n Gereral & Replacement";
            twtText.Visible = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            var frmB = new Bibliography(mainScen);
            frmB.showWordPackage(1);
            this.Hide();
            frmB.Show();

        }
        private void psQ_Click(object sender, EventArgs e)
        {
            var frmB = new Bibliography(mainScen);
            frmB.showWordPackage(2);
            this.Hide();
            frmB.Show();

        }

        private void ccaQ_Click(object sender, EventArgs e)
        {
            var frmB = new Bibliography(mainScen);
            frmB.showWordPackage(3);
            this.Hide();
            frmB.Show();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMCS.Show();
        }
    }
}
