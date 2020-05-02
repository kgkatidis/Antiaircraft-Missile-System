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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TacticalTrain));
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.timeLabel = new System.Windows.Forms.Label();
            this.targetUpdate = new System.Windows.Forms.Timer(this.components);
            this.scoreBoard = new System.Windows.Forms.Label();
            this.statusBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.go1 = new System.Windows.Forms.Label();
            this.go2 = new System.Windows.Forms.Label();
            this.go3 = new System.Windows.Forms.Label();
            this.end = new System.Windows.Forms.Label();
            this.statusBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 1000;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.BackColor = System.Drawing.SystemColors.WindowText;
            this.timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.12F);
            this.timeLabel.ForeColor = System.Drawing.Color.Lime;
            this.timeLabel.Location = new System.Drawing.Point(12, 9);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(56, 20);
            this.timeLabel.TabIndex = 0;
            this.timeLabel.Text = "Time: ";
            // 
            // targetUpdate
            // 
            this.targetUpdate.Interval = 10;
            this.targetUpdate.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // scoreBoard
            // 
            this.scoreBoard.AutoSize = true;
            this.scoreBoard.BackColor = System.Drawing.SystemColors.WindowText;
            this.scoreBoard.Font = new System.Drawing.Font("NSimSun", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreBoard.ForeColor = System.Drawing.Color.Lime;
            this.scoreBoard.Location = new System.Drawing.Point(857, 9);
            this.scoreBoard.Name = "scoreBoard";
            this.scoreBoard.Size = new System.Drawing.Size(86, 20);
            this.scoreBoard.TabIndex = 1;
            this.scoreBoard.Text = "Score: ";
            // 
            // statusBox
            // 
            this.statusBox.BackColor = System.Drawing.SystemColors.WindowText;
            this.statusBox.Controls.Add(this.go3);
            this.statusBox.Controls.Add(this.go2);
            this.statusBox.Controls.Add(this.go1);
            this.statusBox.Controls.Add(this.label3);
            this.statusBox.Controls.Add(this.label2);
            this.statusBox.Controls.Add(this.label1);
            this.statusBox.ForeColor = System.Drawing.Color.Lime;
            this.statusBox.Location = new System.Drawing.Point(0, 558);
            this.statusBox.Name = "statusBox";
            this.statusBox.Size = new System.Drawing.Size(238, 122);
            this.statusBox.TabIndex = 2;
            this.statusBox.TabStop = false;
            this.statusBox.Text = "System Status";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.WindowText;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.12F);
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Command Station: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.WindowText;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.12F);
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(6, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Radar: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.WindowText;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.12F);
            this.label3.ForeColor = System.Drawing.Color.Lime;
            this.label3.Location = new System.Drawing.Point(6, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Launcher: ";
            // 
            // go1
            // 
            this.go1.AutoSize = true;
            this.go1.BackColor = System.Drawing.SystemColors.WindowText;
            this.go1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.12F);
            this.go1.ForeColor = System.Drawing.Color.Lime;
            this.go1.Location = new System.Drawing.Point(164, 30);
            this.go1.Name = "go1";
            this.go1.Size = new System.Drawing.Size(36, 20);
            this.go1.TabIndex = 3;
            this.go1.Text = "Go ";
            // 
            // go2
            // 
            this.go2.AutoSize = true;
            this.go2.BackColor = System.Drawing.SystemColors.WindowText;
            this.go2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.12F);
            this.go2.ForeColor = System.Drawing.Color.Lime;
            this.go2.Location = new System.Drawing.Point(164, 62);
            this.go2.Name = "go2";
            this.go2.Size = new System.Drawing.Size(31, 20);
            this.go2.TabIndex = 6;
            this.go2.Text = "Go";
            // 
            // go3
            // 
            this.go3.AutoSize = true;
            this.go3.BackColor = System.Drawing.SystemColors.WindowText;
            this.go3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.12F);
            this.go3.ForeColor = System.Drawing.Color.Lime;
            this.go3.Location = new System.Drawing.Point(164, 94);
            this.go3.Name = "go3";
            this.go3.Size = new System.Drawing.Size(31, 20);
            this.go3.TabIndex = 7;
            this.go3.Text = "Go";
            // 
            // end
            // 
            this.end.AutoSize = true;
            this.end.BackColor = System.Drawing.SystemColors.HotTrack;
            this.end.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.end.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.end.Location = new System.Drawing.Point(949, 652);
            this.end.Name = "end";
            this.end.Size = new System.Drawing.Size(56, 25);
            this.end.TabIndex = 3;
            this.end.Text = "END";
            // 
            // TacticalTrain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1006, 681);
            this.Controls.Add(this.end);
            this.Controls.Add(this.statusBox);
            this.Controls.Add(this.scoreBoard);
            this.Controls.Add(this.timeLabel);
            this.DoubleBuffered = true;
            this.Name = "TacticalTrain";
            this.Text = "TacticalTrain";
            this.MaximizedBoundsChanged += new System.EventHandler(this.TacticalTrain_Load);
            this.MaximumSizeChanged += new System.EventHandler(this.TacticalTrain_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TacticalTrain_FormClosed);
            this.Load += new System.EventHandler(this.TacticalTrain_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.TacticalTrain_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TacticalTrain_KeyDown);
            this.statusBox.ResumeLayout(false);
            this.statusBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Timer targetUpdate;
        private System.Windows.Forms.Label scoreBoard;
        private System.Windows.Forms.GroupBox statusBox;
        private System.Windows.Forms.Label go3;
        private System.Windows.Forms.Label go2;
        private System.Windows.Forms.Label go1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label end;
    }
}