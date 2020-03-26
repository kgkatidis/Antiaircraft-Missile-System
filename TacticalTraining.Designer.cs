namespace WindowsFormsApp1
{
    partial class TacticalTraining
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // TacticalTraining
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 681);
            this.Name = "TacticalTraining";
            this.Text = "Tactical Training";
            this.Load += new System.EventHandler(this.TacticalTraining_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TacticalTraining_KeyDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TacticalTraining_MouseMove);
            this.ResumeLayout(false);

        }

        #endregion
    }
}