namespace WindowsFormsApp1
{
    partial class Home
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
            this.maintenanceCheck = new System.Windows.Forms.CheckBox();
            this.tacticalCheck = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.sureBtn = new System.Windows.Forms.Button();
            this.checkMsg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // maintenanceCheck
            // 
            this.maintenanceCheck.AutoSize = true;
            this.maintenanceCheck.BackColor = System.Drawing.SystemColors.WindowText;
            this.maintenanceCheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.maintenanceCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maintenanceCheck.ForeColor = System.Drawing.Color.Lime;
            this.maintenanceCheck.Location = new System.Drawing.Point(440, 325);
            this.maintenanceCheck.Name = "maintenanceCheck";
            this.maintenanceCheck.Size = new System.Drawing.Size(158, 29);
            this.maintenanceCheck.TabIndex = 30;
            this.maintenanceCheck.Text = "Maintenance";
            this.maintenanceCheck.UseVisualStyleBackColor = false;
            // 
            // tacticalCheck
            // 
            this.tacticalCheck.AutoSize = true;
            this.tacticalCheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tacticalCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tacticalCheck.ForeColor = System.Drawing.Color.Lime;
            this.tacticalCheck.Location = new System.Drawing.Point(440, 256);
            this.tacticalCheck.Name = "tacticalCheck";
            this.tacticalCheck.Size = new System.Drawing.Size(109, 29);
            this.tacticalCheck.TabIndex = 29;
            this.tacticalCheck.Text = "Tactical";
            this.tacticalCheck.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Lime;
            this.label4.Location = new System.Drawing.Point(2, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1004, 57);
            this.label4.TabIndex = 28;
            this.label4.Text = "Choose your Training Program";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Lime;
            this.label5.Location = new System.Drawing.Point(91, 489);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(811, 41);
            this.label5.TabIndex = 27;
            this.label5.Text = "Ready for Training?";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sureBtn
            // 
            this.sureBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sureBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F, System.Drawing.FontStyle.Bold);
            this.sureBtn.Location = new System.Drawing.Point(430, 552);
            this.sureBtn.Name = "sureBtn";
            this.sureBtn.Size = new System.Drawing.Size(136, 47);
            this.sureBtn.TabIndex = 24;
            this.sureBtn.Text = "Sure";
            this.sureBtn.UseVisualStyleBackColor = true;
            this.sureBtn.Click += new System.EventHandler(this.sureBtn_Click);
            // 
            // checkMsg
            // 
            this.checkMsg.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkMsg.ForeColor = System.Drawing.Color.Lime;
            this.checkMsg.Location = new System.Drawing.Point(2, 399);
            this.checkMsg.Name = "checkMsg";
            this.checkMsg.Size = new System.Drawing.Size(1004, 57);
            this.checkMsg.TabIndex = 31;
            this.checkMsg.Text = "please check ONLY one of the above";
            this.checkMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkMsg.Visible = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowText;
            this.ClientSize = new System.Drawing.Size(1006, 681);
            this.Controls.Add(this.checkMsg);
            this.Controls.Add(this.maintenanceCheck);
            this.Controls.Add(this.tacticalCheck);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.sureBtn);
            this.Name = "Home";
            this.Text = "Home";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox maintenanceCheck;
        private System.Windows.Forms.CheckBox tacticalCheck;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button sureBtn;
        private System.Windows.Forms.Label checkMsg;
    }
}