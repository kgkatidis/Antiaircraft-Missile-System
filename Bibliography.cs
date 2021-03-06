﻿using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{

    public partial class Bibliography : Form
    {
        private MainScen mainScen;
        private ConfigurationManagement frmCM;

        public Bibliography()
        {
            InitializeComponent();
        }
        public Bibliography(MainScen mS)
        {
            InitializeComponent();
            mainScen = mS;
            frmCM = new ConfigurationManagement(mainScen);
        }

        private void Bibliography_KeyDown(object sender, KeyEventArgs key)
        {
            {
                switch (key.KeyCode)
                {
                    case Keys.Escape:
                        {
                            this.Hide();
                            frmCM.Show();
                            break;
                        }
                }
            }
        }

        public void showWordPackage(int wordPackage)
        {
            switch (wordPackage)
            {
               case 1:
                       {

                        this.pictureBox1.Image = Image.FromFile("Twt.png");
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                        title.Text = "WP-38 TWT";
                        general1.Text = "    A traveling-wave tube (TWT, pronounced 'twit') is a specialized vacuum tube that is used in electronics to amplify radio frequency (RF) signals in the microwave range. The TWT belongs to a category of 'linear beam' tubes, such as the klystron, in which the radio wave is amplified by absorbing power from a beam of electrons as it passes down the tube.";
                           general2.Text = "This Antiaircraft Missile System includes two types of TWT:";
                           general3.Text = "Helix TWT - which Serial Number is between 224704816 and 224704891, and Coupled cavity TWT - which serial number is between 224704892 and 224704942.";
                           replacement1.Text = "1.Deenergize the Radar System";
                           replacement2.Text = "2.Remove power cables W12 and W13 for Helix TWT or W15 and W16 for Coupled cavity";
                           replacement3.Text = "3.Remove 4 screws that keeps the damaged TWT";
                           replacement4.Text = "4.Replace TWT with another one";
                           replacement5.Text = "5.Put the 4 screws on their place";
                           replacement6.Text = "6.Put the wires back";
                           replacement7.Text = "7.Energize and Run Diagnostics to check";
                           break;
                       }
                case 2:
                    {
                        this.pictureBox1.Image = Image.FromFile("PS.png");
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                        title.Text = "WP-12 PS";
                        general1.Text = "    A power supply takes the 3-phased AC from the generator power unit (PU), converts it to unregulated DC, and reduces the voltage using an input power transformer, typically stepping it down to the voltage required by the load. For safety reasons, the transformer also separates the output power supply from the mains input. ( CURRENT IS NOT A GAME !!! )";
                        general2.Text = "All PSs that this Antiaircraft Missile System includes are similar.";
                        general3.Text = "There are PSs in both RS, CS and LS and their SN must be < 3600.";
                        replacement1.Text = "1.Deenergize the Launcer Station or Command Station respectively";
                        replacement2.Text = "2.Remove power cables (1),(2)";
                        replacement3.Text = "3.Remove 4 screws that keeps the damaged PS (3),(4),(5),(6)";
                        replacement4.Text = "4.Replace PS with another one (7)";
                        replacement5.Text = "5.Put the 4 screws on their place";
                        replacement6.Text = "6.Put the wires back";
                        replacement7.Text = "7.Energize and Run Diagnostics to check";
                        break;
                    }
                case 3:
                    {
                        this.pictureBox1.Image = Image.FromFile("Cca.png");
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                        title.Text = "WP-01 CCA";
                        general1.Text = "    A Circuit Card Assembly (CCA) mechanically supports and electrically connects electrical or electronic components using conductive tracks, pads and other features etched from one or more sheet layers of copper laminated onto and/or between sheet layers of a non-conductive substrate. Components are generally soldered onto the CCA to both electrically connect and mechanically fasten them to it.";
                        general2.Text = "This Antiaircraft Missile System has been Upgraded to Version 2020.2.2";
                        general3.Text = "With this implementation status, the SN of CCAs are between 1147801 and 1147999.";
                        replacement1.Text = "1.Deenergize the Command Station";
                        replacement2.Text = "2.Open the Rack that includes the CCAs";
                        replacement3.Text = "3.Get an extractor and remove the damaged CCA with no hurry";
                        replacement4.Text = "4.Replace CCA with another one";
                        replacement5.Text = "5.Check that it have been put correctly";
                        replacement6.Text = "6.Close the opened Rack";
                        replacement7.Text = "7.Energize and Run DIagnostics to check";
                        break;
                    }
            }
        }



    }
}
