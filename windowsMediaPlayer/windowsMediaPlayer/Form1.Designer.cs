namespace windowsMediaPlayer
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnMute = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.trackBarVolume = new System.Windows.Forms.TrackBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.windowsMediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVolume)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.windowsMediaPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPause
            // 
            this.btnPause.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPause.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnPause.Location = new System.Drawing.Point(0, 0);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(50, 31);
            this.btnPause.TabIndex = 1;
            this.btnPause.Text = "▶️";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnStop
            // 
            this.btnStop.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStop.ForeColor = System.Drawing.Color.Red;
            this.btnStop.Location = new System.Drawing.Point(46, 0);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(50, 31);
            this.btnStop.TabIndex = 2;
            this.btnStop.Text = "⏹️";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnMute
            // 
            this.btnMute.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMute.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnMute.Location = new System.Drawing.Point(186, 0);
            this.btnMute.Name = "btnMute";
            this.btnMute.Size = new System.Drawing.Size(50, 31);
            this.btnMute.TabIndex = 4;
            this.btnMute.Text = "🔊";
            this.btnMute.UseVisualStyleBackColor = true;
            this.btnMute.Click += new System.EventHandler(this.btnMute_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPrevious.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnPrevious.Location = new System.Drawing.Point(93, 0);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(50, 31);
            this.btnPrevious.TabIndex = 5;
            this.btnPrevious.Text = "⏪";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnNext.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnNext.Location = new System.Drawing.Point(140, 0);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(50, 31);
            this.btnNext.TabIndex = 6;
            this.btnNext.Text = "⏩";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // trackBarVolume
            // 
            this.trackBarVolume.Location = new System.Drawing.Point(230, 0);
            this.trackBarVolume.Name = "trackBarVolume";
            this.trackBarVolume.Size = new System.Drawing.Size(120, 45);
            this.trackBarVolume.TabIndex = 3;
            this.trackBarVolume.Scroll += new System.EventHandler(this.trackBarVolume_Scroll);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnPause);
            this.panel1.Controls.Add(this.trackBarVolume);
            this.panel1.Controls.Add(this.btnMute);
            this.panel1.Controls.Add(this.btnNext);
            this.panel1.Controls.Add(this.btnStop);
            this.panel1.Controls.Add(this.btnPrevious);
            this.panel1.Location = new System.Drawing.Point(14, 517);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(783, 31);
            this.panel1.TabIndex = 7;
            // 
            // windowsMediaPlayer
            // 
            this.windowsMediaPlayer.Enabled = true;
            this.windowsMediaPlayer.Location = new System.Drawing.Point(14, 8);
            this.windowsMediaPlayer.Name = "windowsMediaPlayer";
            this.windowsMediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("windowsMediaPlayer.OcxState")));
            this.windowsMediaPlayer.Size = new System.Drawing.Size(783, 540);
            this.windowsMediaPlayer.TabIndex = 0;
            this.windowsMediaPlayer.Enter += new System.EventHandler(this.windowsMediaPlayer_Enter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(809, 563);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.windowsMediaPlayer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PlayList";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVolume)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.windowsMediaPlayer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer windowsMediaPlayer;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnMute;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.TrackBar trackBarVolume;
        private System.Windows.Forms.Panel panel1;
    }
}

