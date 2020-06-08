namespace WindowsFormsApp1
{
    partial class MaintenanceControlSystem
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
            this.components = new System.ComponentModel.Container();
            this.title = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.runBtn = new System.Windows.Forms.Button();
            this.checkMsg = new System.Windows.Forms.Label();
            this.diagnosticsTimer = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.homeBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.title.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.Lime;
            this.title.Location = new System.Drawing.Point(108, 21);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(795, 41);
            this.title.TabIndex = 18;
            this.title.Text = "Welcome to Maintenance Control System Training";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.BackColor = System.Drawing.SystemColors.WindowText;
            this.checkedListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkedListBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.22F);
            this.checkedListBox1.ForeColor = System.Drawing.Color.Lime;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Computer Diagnostics",
            "Configuration Management",
            "System Adjustments"});
            this.checkedListBox1.Location = new System.Drawing.Point(295, 159);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(501, 148);
            this.checkedListBox1.TabIndex = 21;
            // 
            // runBtn
            // 
            this.runBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.runBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.runBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.15F);
            this.runBtn.ForeColor = System.Drawing.Color.Lime;
            this.runBtn.Location = new System.Drawing.Point(444, 538);
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
            this.checkMsg.Location = new System.Drawing.Point(1, 356);
            this.checkMsg.Name = "checkMsg";
            this.checkMsg.Size = new System.Drawing.Size(1002, 115);
            this.checkMsg.TabIndex = 32;
            this.checkMsg.Text = "please check ONLY one of the above";
            this.checkMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkMsg.Visible = false;
            // 
            // diagnosticsTimer
            // 
            this.diagnosticsTimer.Interval = 500;
            this.diagnosticsTimer.Tick += new System.EventHandler(this.diagnosticsTimer_Tick);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(347, 616);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(266, 31);
            this.button1.TabIndex = 33;
            this.button1.Text = "Restart (New Scenario)";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // homeBtn
            // 
            this.homeBtn.BackColor = System.Drawing.SystemColors.GrayText;
            this.homeBtn.Location = new System.Drawing.Point(12, 626);
            this.homeBtn.Name = "homeBtn";
            this.homeBtn.Size = new System.Drawing.Size(100, 43);
            this.homeBtn.TabIndex = 34;
            this.homeBtn.Text = "Home";
            this.homeBtn.UseVisualStyleBackColor = false;
            this.homeBtn.Click += new System.EventHandler(this.homeBtn_Click);
            // 
            // MaintenanceControlSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowText;
            this.ClientSize = new System.Drawing.Size(1006, 681);
            this.Controls.Add(this.homeBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkMsg);
            this.Controls.Add(this.runBtn);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.title);
            this.Name = "MaintenanceControlSystem";
            this.Text = "Maintenance Control System";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button runBtn;
        private System.Windows.Forms.Label checkMsg;
        private System.Windows.Forms.Timer diagnosticsTimer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button homeBtn;
    }
}