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
        public MaintenanceContrrolSystem()
        {
            InitializeComponent();
        }

        private void runBtn_Click(object sender, EventArgs e)
        {
            if (this.checkedListBox1.CheckedItems.Count>1)
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
            }
        }
    }
}


