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
    public partial class InfoTactical : Form
    {
        public InfoTactical()
        {
            InitializeComponent();
        }

        private void InfoTactical_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    {
                        var frm = new Home();
                        this.Hide();
                        frm.Show();
                        break;
                    }
            }
        }
    }
}
