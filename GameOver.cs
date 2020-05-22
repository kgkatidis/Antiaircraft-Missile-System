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
        }
    }
}
