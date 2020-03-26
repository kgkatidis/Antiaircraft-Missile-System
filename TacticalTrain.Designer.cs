namespace WindowsFormsApp1
{
    partial class TacticalTrain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TacticalTrain));
            this.SuspendLayout();
            // 
            // TacticalTrain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1006, 681);
            this.Name = "TacticalTrain";
            this.Text = "TacticalTrain";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TacticalTrain_FormClosed);
            this.Load += new System.EventHandler(this.TacticalTrain_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.TacticalTrain_Paint);
            this.ResumeLayout(false);

        }

        #endregion
    }
}