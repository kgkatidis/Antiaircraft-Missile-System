using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
        }
        

        private void startGameBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var frm = new Home();
            frm.Show();
        }
        
     
    }
}
