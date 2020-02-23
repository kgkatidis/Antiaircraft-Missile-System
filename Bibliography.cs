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
    }
}
