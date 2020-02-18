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
        public ConfigurationManagement()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.button1.Text == "Update")
            {
                this.button1.Text = "Validate";
                this.label4.Text = null;
            }
        }
    }
}
