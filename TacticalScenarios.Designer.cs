﻿namespace WindowsFormsApp1
{
    partial class TacticalScenarios
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
            this.button1 = new System.Windows.Forms.Button();
            this.radyToFightBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Lime;
            this.label5.Location = new System.Drawing.Point(95, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(811, 41);
            this.label5.TabIndex = 18;
            this.label5.Text = "Load Baseline";
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
            "Blueland East",
            "BluelandWest",
            "Sarabian North",
            "Hotlib North"});
            this.checkedListBox1.Location = new System.Drawing.Point(408, 259);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(186, 145);
            this.checkedListBox1.TabIndex = 20;
            this.checkedListBox1.ThreeDCheckBoxes = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // radyToFightBtn
            // 
            this.radyToFightBtn.Font = new System.Drawing.Font("MV Boli", 12.6F, System.Drawing.FontStyle.Italic);
            this.radyToFightBtn.Location = new System.Drawing.Point(395, 507);
            this.radyToFightBtn.Name = "radyToFightBtn";
            this.radyToFightBtn.Size = new System.Drawing.Size(208, 55);
            this.radyToFightBtn.TabIndex = 22;
            this.radyToFightBtn.Text = "Ready to FIGHT";
            this.radyToFightBtn.UseVisualStyleBackColor = true;
            this.radyToFightBtn.Click += new System.EventHandler(this.radyToFightBtn_Click);
            // 
            // TacticalScenarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowText;
            this.ClientSize = new System.Drawing.Size(1006, 681);
            this.Controls.Add(this.radyToFightBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.label5);
            this.Name = "TacticalScenarios";
            this.Text = "Tactical Scenarios";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button radyToFightBtn;
    }
}