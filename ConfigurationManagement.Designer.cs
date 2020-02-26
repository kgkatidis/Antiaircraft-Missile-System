namespace WindowsFormsApp1
{
    partial class ConfigurationManagement
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.twtQ = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.psQ = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ccaQ = new System.Windows.Forms.Label();
            this.infoText = new System.Windows.Forms.Label();
            this.twtText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.Lime;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "TWT 224704886",
            "TWT 224704890",
            "TWT 224704891",
            "TWT 224704895",
            "TWT 224704900",
            "TWT 224704903"});
            this.comboBox1.Location = new System.Drawing.Point(109, 177);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(182, 24);
            this.comboBox1.TabIndex = 0;
            // 
            // comboBox2
            // 
            this.comboBox2.BackColor = System.Drawing.Color.Lime;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Power Supply 0912",
            "Power Supply 0914",
            "Power Supply 0915",
            "Power Supply 0921",
            "Power Supply 0930",
            "Power Supply 0944"});
            this.comboBox2.Location = new System.Drawing.Point(109, 308);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(182, 24);
            this.comboBox2.TabIndex = 1;
            // 
            // comboBox3
            // 
            this.comboBox3.BackColor = System.Drawing.Color.Lime;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "CCA 114722430",
            "CCA 114723998",
            "CCA 114733890",
            "CCA 114778390",
            "CCA 114778392",
            "CCA 114794541"});
            this.comboBox3.Location = new System.Drawing.Point(109, 432);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(182, 24);
            this.comboBox3.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Lime;
            this.label5.Location = new System.Drawing.Point(87, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(811, 41);
            this.label5.TabIndex = 19;
            this.label5.Text = "Configuration Management Menu";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.LawnGreen;
            this.label4.Location = new System.Drawing.Point(305, 624);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(703, 57);
            this.label4.TabIndex = 29;
            this.label4.Text = "*These updates are ONLY for training program and Configuration Management Menu wi" +
    "ll retain to initial status after shut down the MCST";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(436, 551);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 31);
            this.button1.TabIndex = 30;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // twtQ
            // 
            this.twtQ.Cursor = System.Windows.Forms.Cursors.Hand;
            this.twtQ.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.twtQ.Font = new System.Drawing.Font("MS Reference Sans Serif", 44F);
            this.twtQ.ForeColor = System.Drawing.Color.Lime;
            this.twtQ.Location = new System.Drawing.Point(330, 121);
            this.twtQ.Name = "twtQ";
            this.twtQ.Size = new System.Drawing.Size(114, 80);
            this.twtQ.TabIndex = 31;
            this.twtQ.Text = "?";
            this.twtQ.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.twtQ.Click += new System.EventHandler(this.label1_Click);
            this.twtQ.MouseLeave += new System.EventHandler(this.removeTwtText);
            // 
            // label2
            // 
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(339, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 44);
            this.label2.TabIndex = 32;
            this.label2.Text = "info";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Lime;
            this.label3.Location = new System.Drawing.Point(339, 341);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 35);
            this.label3.TabIndex = 34;
            this.label3.Text = "info";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // psQ
            // 
            this.psQ.Cursor = System.Windows.Forms.Cursors.Hand;
            this.psQ.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.psQ.Font = new System.Drawing.Font("MS Reference Sans Serif", 44F);
            this.psQ.ForeColor = System.Drawing.Color.Lime;
            this.psQ.Location = new System.Drawing.Point(330, 258);
            this.psQ.Name = "psQ";
            this.psQ.Size = new System.Drawing.Size(109, 83);
            this.psQ.TabIndex = 33;
            this.psQ.Text = "?";
            this.psQ.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.psQ.Click += new System.EventHandler(this.psQ_Click);
            this.psQ.MouseLeave += new System.EventHandler(this.removepsText);
            this.psQ.MouseHover += new System.EventHandler(this.addpsText);
            // 
            // label7
            // 
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label7.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Lime;
            this.label7.Location = new System.Drawing.Point(339, 469);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 44);
            this.label7.TabIndex = 36;
            this.label7.Text = "info";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ccaQ
            // 
            this.ccaQ.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ccaQ.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ccaQ.Font = new System.Drawing.Font("MS Reference Sans Serif", 44F);
            this.ccaQ.ForeColor = System.Drawing.Color.Lime;
            this.ccaQ.Location = new System.Drawing.Point(330, 389);
            this.ccaQ.Name = "ccaQ";
            this.ccaQ.Size = new System.Drawing.Size(114, 80);
            this.ccaQ.TabIndex = 35;
            this.ccaQ.Text = "?";
            this.ccaQ.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ccaQ.Click += new System.EventHandler(this.ccaQ_Click);
            this.ccaQ.MouseLeave += new System.EventHandler(this.removeCcaText);
            this.ccaQ.MouseHover += new System.EventHandler(this.addCcaText);
            // 
            // infoText
            // 
            this.infoText.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.infoText.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoText.ForeColor = System.Drawing.Color.Lime;
            this.infoText.Location = new System.Drawing.Point(564, 147);
            this.infoText.Name = "infoText";
            this.infoText.Size = new System.Drawing.Size(351, 229);
            this.infoText.TabIndex = 37;
            this.infoText.Text = "Hover \"?\" to view info";
            this.infoText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // twtText
            // 
            this.twtText.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.twtText.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.twtText.ForeColor = System.Drawing.Color.Lime;
            this.twtText.Location = new System.Drawing.Point(564, 312);
            this.twtText.Name = "twtText";
            this.twtText.Size = new System.Drawing.Size(351, 225);
            this.twtText.TabIndex = 38;
            this.twtText.Text = "TWT (General & Replacement)";
            this.twtText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.twtText.Visible = false;
            // 
            // ConfigurationManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowText;
            this.ClientSize = new System.Drawing.Size(1006, 681);
            this.Controls.Add(this.twtText);
            this.Controls.Add(this.infoText);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ccaQ);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.psQ);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.twtQ);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "ConfigurationManagement";
            this.Text = "Configuration Management";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label twtQ;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label psQ;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label ccaQ;
        private System.Windows.Forms.Label infoText;
        private System.Windows.Forms.Label twtText;
    }
}