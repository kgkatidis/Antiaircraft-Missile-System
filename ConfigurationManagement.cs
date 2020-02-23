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
    public partial class ConfigurationManagement : Form
    {
        private MainScen mainScen;
        public ConfigurationManagement()
        {
            InitializeComponent();
        }
        public ConfigurationManagement(MainScen mS)
        {
            InitializeComponent();
            mainScen = mS;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.button1.Text == "Update")
            {
                this.button1.Text = "Validate";
                this.label4.Text = null;
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
            this.Hide();
            frmB.Show();
        }
        private void psQ_Click(object sender, EventArgs e)
        {
            // NA PROSTE8OUN TA APO PANW KAI NA MPEI KAI H ANTISTOIXH BIBLIOGRAFIA
        }

        private void ccaQ_Click(object sender, EventArgs e)
        {
            // NA PROSTE8OUN TA APO PANW KAI NA MPEI KAI H ANTISTOIXH BIBLIOGRAFIA
        }
    }
}
