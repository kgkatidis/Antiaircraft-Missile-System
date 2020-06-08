using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class GameOver : Form
    {
        public GameOver()
        {
            InitializeComponent();
        }
        public GameOver(int i)
        {
            InitializeComponent();
            this.finalScore.Text += i;
            Cursor.Show();
        }

        private void homeBtn_Click(object sender, System.EventArgs e)
        {
            var frm = new Home();
            this.Hide();
            frm.Show();
        }

        private void playAgainBtn_Click(object sender, System.EventArgs e)
        {
            var frm = new TacticalScenarios();
            this.Hide();
            frm.Show();
        }

        private void exitBtn_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }
    }
}
