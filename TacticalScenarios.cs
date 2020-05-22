using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class TacticalScenarios : Form
    {
        public TacticalScenarios()
        {
            InitializeComponent();
        }
        
        //load Scenario ...
        private void radyToFightBtn_Click(object sender, EventArgs e)
        {
            // going to playing form
            if (checkedListBox1.GetItemCheckState(0) == CheckState.Checked)
            {
                this.Hide();
                TrainTactical frm = new TrainTactical(1);
                frm.ShowDialog();
            }
            else if (checkedListBox1.GetItemCheckState(1) == CheckState.Checked)
            {
                this.Hide();
                TrainTactical frm = new TrainTactical(2);
                frm.ShowDialog();
            }
            else if (checkedListBox1.GetItemCheckState(2) == CheckState.Checked)
            {
                this.Hide();
                TrainTactical frm = new TrainTactical(3);
                frm.ShowDialog();
            }
            else if (checkedListBox1.GetItemCheckState(3) == CheckState.Checked)
            {
                this.Hide();
                TrainTactical frm = new TrainTactical(4);
                frm.ShowDialog();
            }
        }

        //check only one
        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked && checkedListBox1.CheckedItems.Count > 0)
            {
                checkedListBox1.ItemCheck -= checkedListBox1_ItemCheck;
                checkedListBox1.SetItemChecked(checkedListBox1.CheckedIndices[0], false);
                checkedListBox1.ItemCheck += checkedListBox1_ItemCheck;
            }
        }
    }
}
