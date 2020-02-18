namespace WindowsFormsApp1
{
    partial class MaintenanceContrrolSystem
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
            this.label5 = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.runBtn = new System.Windows.Forms.Button();
            this.checkMsg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Lime;
            this.label5.Location = new System.Drawing.Point(92, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(811, 41);
            this.label5.TabIndex = 18;
            this.label5.Text = "Welcome to Maintenance Control System Training";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.BackColor = System.Drawing.SystemColors.WindowText;
            this.checkedListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.16F);
            this.checkedListBox1.ForeColor = System.Drawing.Color.Lime;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Computer Diagnostics",
            "Configuration Management",
            "System Adjustments"});
            this.checkedListBox1.Location = new System.Drawing.Point(321, 263);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(325, 145);
            this.checkedListBox1.TabIndex = 21;
            this.checkedListBox1.ThreeDCheckBoxes = true;
            // 
            // runBtn
            // 
            this.runBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.runBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.15F);
            this.runBtn.ForeColor = System.Drawing.Color.Lime;
            this.runBtn.Location = new System.Drawing.Point(444, 521);
            this.runBtn.Name = "runBtn";
            this.runBtn.Size = new System.Drawing.Size(77, 51);
            this.runBtn.TabIndex = 23;
            this.runBtn.Text = "Run";
            this.runBtn.UseVisualStyleBackColor = true;
            this.runBtn.Click += new System.EventHandler(this.runBtn_Click);
            // 
            // checkMsg
            // 
            this.checkMsg.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkMsg.ForeColor = System.Drawing.Color.Lime;
            this.checkMsg.Location = new System.Drawing.Point(0, 411);
            this.checkMsg.Name = "checkMsg";
            this.checkMsg.Size = new System.Drawing.Size(1004, 57);
            this.checkMsg.TabIndex = 32;
            this.checkMsg.Text = "please check ONLY one of the above";
            this.checkMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkMsg.Visible = false;
            // 
            // MaintenanceContrrolSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowText;
            this.ClientSize = new System.Drawing.Size(1006, 681);
            this.Controls.Add(this.checkMsg);
            this.Controls.Add(this.runBtn);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.label5);
            this.Name = "MaintenanceContrrolSystem";
            this.Text = "Maintenance Control System";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button runBtn;
        private System.Windows.Forms.Label checkMsg;
    }
}