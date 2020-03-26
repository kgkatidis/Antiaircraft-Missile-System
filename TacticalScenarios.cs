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
    public partial class TacticalScenarios : Form
    {
        public TacticalScenarios()
        {
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //load Scenario ...
        private void radyToFightBtn_Click(object sender, EventArgs e)
        {
            // going to playing form
            if (checkedListBox1.GetItemCheckState(0) == CheckState.Checked)
            {
                this.Hide();
                TacticalTrain frm = new TacticalTrain(1);
                frm.ShowDialog();
            }
            else if (checkedListBox1.GetItemCheckState(1) == CheckState.Checked)
            {
                this.Hide();
                TacticalTrain frm = new TacticalTrain(2);
                frm.ShowDialog();
            }
            else if (checkedListBox1.GetItemCheckState(2) == CheckState.Checked)
            {
                this.Hide();
                TacticalTrain frm = new TacticalTrain(3);
                frm.ShowDialog();
            }
            else if (checkedListBox1.GetItemCheckState(3) == CheckState.Checked)
            {
                this.Hide();
                TacticalTrain frm = new TacticalTrain(4);
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
