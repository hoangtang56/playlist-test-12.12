namespace Playlist_test
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Button btn_first;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_add = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btn_play = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.btn_shuffle = new System.Windows.Forms.Button();
            this.btn_remove = new System.Windows.Forms.Button();
            this.listBoxPlaylist = new System.Windows.Forms.ListBox();
            this.btn_sort = new System.Windows.Forms.Button();
            this.btn_sortDESC = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.trackBarSpeed = new System.Windows.Forms.TrackBar();
            this.labelSpeed = new System.Windows.Forms.Label();
            this.labelNowPlaying = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.TextBox();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_minus15 = new System.Windows.Forms.Button();
            this.btn_add15 = new System.Windows.Forms.Button();
            this.trackBarVolume = new System.Windows.Forms.TrackBar();
            this.labelVolume = new System.Windows.Forms.Label();
            this.trackBarProgress = new System.Windows.Forms.TrackBar();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelCurrentTime = new System.Windows.Forms.Label();
            this.labelTotalTime = new System.Windows.Forms.Label();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            btn_first = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarProgress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_first
            // 
            btn_first.Location = new System.Drawing.Point(10, 479);
            btn_first.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btn_first.Name = "btn_first";
            btn_first.Size = new System.Drawing.Size(68, 58);
            btn_first.TabIndex = 5;
            btn_first.Text = "first";
            btn_first.UseVisualStyleBackColor = true;
            btn_first.Click += new System.EventHandler(this.btn_first_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(340, 479);
            this.btn_add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(68, 58);
            this.btn_add.TabIndex = 1;
            this.btn_add.Text = "add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(92, 479);
            this.btnPrevious.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(68, 58);
            this.btnPrevious.TabIndex = 2;
            this.btnPrevious.Text = "prev";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btn_play
            // 
            this.btn_play.Location = new System.Drawing.Point(175, 479);
            this.btn_play.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_play.Name = "btn_play";
            this.btn_play.Size = new System.Drawing.Size(68, 58);
            this.btn_play.TabIndex = 3;
            this.btn_play.Text = "play";
            this.btn_play.UseVisualStyleBackColor = true;
            this.btn_play.Click += new System.EventHandler(this.btn_play_Click);
            // 
            // btn_next
            // 
            this.btn_next.Location = new System.Drawing.Point(258, 479);
            this.btn_next.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(68, 58);
            this.btn_next.TabIndex = 4;
            this.btn_next.Text = "next";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // btn_shuffle
            // 
            this.btn_shuffle.Location = new System.Drawing.Point(506, 479);
            this.btn_shuffle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_shuffle.Name = "btn_shuffle";
            this.btn_shuffle.Size = new System.Drawing.Size(68, 58);
            this.btn_shuffle.TabIndex = 6;
            this.btn_shuffle.Text = "shuffle";
            this.btn_shuffle.UseVisualStyleBackColor = true;
            this.btn_shuffle.Click += new System.EventHandler(this.btn_shuffle_Click);
            // 
            // btn_remove
            // 
            this.btn_remove.Location = new System.Drawing.Point(423, 479);
            this.btn_remove.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(68, 58);
            this.btn_remove.TabIndex = 7;
            this.btn_remove.Text = "remove";
            this.btn_remove.UseVisualStyleBackColor = true;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // listBoxPlaylist
            // 
            this.listBoxPlaylist.FormattingEnabled = true;
            this.listBoxPlaylist.ItemHeight = 16;
            this.listBoxPlaylist.Location = new System.Drawing.Point(396, 85);
            this.listBoxPlaylist.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxPlaylist.Name = "listBoxPlaylist";
            this.listBoxPlaylist.Size = new System.Drawing.Size(365, 292);
            this.listBoxPlaylist.TabIndex = 8;
            this.listBoxPlaylist.SelectedIndexChanged += new System.EventHandler(this.listBoxPlaylist_SelectedIndexChanged);
            // 
            // btn_sort
            // 
            this.btn_sort.Location = new System.Drawing.Point(588, 479);
            this.btn_sort.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_sort.Name = "btn_sort";
            this.btn_sort.Size = new System.Drawing.Size(68, 58);
            this.btn_sort.TabIndex = 10;
            this.btn_sort.Text = "sort (asc)";
            this.btn_sort.UseVisualStyleBackColor = true;
            this.btn_sort.Click += new System.EventHandler(this.btn_sort_Click);
            // 
            // btn_sortDESC
            // 
            this.btn_sortDESC.Location = new System.Drawing.Point(676, 479);
            this.btn_sortDESC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_sortDESC.Name = "btn_sortDESC";
            this.btn_sortDESC.Size = new System.Drawing.Size(68, 58);
            this.btn_sortDESC.TabIndex = 11;
            this.btn_sortDESC.Text = "sort (desc)";
            this.btn_sortDESC.UseVisualStyleBackColor = true;
            this.btn_sortDESC.Click += new System.EventHandler(this.btn_sortDESC_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(378, 340);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // trackBarSpeed
            // 
            this.trackBarSpeed.LargeChange = 20;
            this.trackBarSpeed.Location = new System.Drawing.Point(907, 158);
            this.trackBarSpeed.Maximum = 200;
            this.trackBarSpeed.Minimum = 50;
            this.trackBarSpeed.Name = "trackBarSpeed";
            this.trackBarSpeed.Size = new System.Drawing.Size(104, 56);
            this.trackBarSpeed.SmallChange = 5;
            this.trackBarSpeed.TabIndex = 13;
            this.trackBarSpeed.TickFrequency = 50;
            this.trackBarSpeed.Value = 100;
            this.trackBarSpeed.Scroll += new System.EventHandler(this.trackBarSpeed_Scroll);
            // 
            // labelSpeed
            // 
            this.labelSpeed.AutoSize = true;
            this.labelSpeed.Location = new System.Drawing.Point(1017, 158);
            this.labelSpeed.Name = "labelSpeed";
            this.labelSpeed.Size = new System.Drawing.Size(77, 16);
            this.labelSpeed.TabIndex = 14;
            this.labelSpeed.Text = "Speed: 1.0x";
            this.labelSpeed.Click += new System.EventHandler(this.labelSpeed_Click);
            // 
            // labelNowPlaying
            // 
            this.labelNowPlaying.AutoSize = true;
            this.labelNowPlaying.Location = new System.Drawing.Point(3, 11);
            this.labelNowPlaying.Name = "labelNowPlaying";
            this.labelNowPlaying.Size = new System.Drawing.Size(44, 16);
            this.labelNowPlaying.TabIndex = 9;
            this.labelNowPlaying.Text = "label1";
            this.labelNowPlaying.Click += new System.EventHandler(this.labelNowPlaying_Click);
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(396, 36);
            this.search.Multiline = true;
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(366, 45);
            this.search.TabIndex = 15;
            this.search.TextChanged += new System.EventHandler(this.search_TextChanged);
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(759, 479);
            this.btn_Clear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(68, 58);
            this.btn_Clear.TabIndex = 16;
            this.btn_Clear.Text = "clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_minus15
            // 
            this.btn_minus15.Location = new System.Drawing.Point(833, 479);
            this.btn_minus15.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_minus15.Name = "btn_minus15";
            this.btn_minus15.Size = new System.Drawing.Size(68, 58);
            this.btn_minus15.TabIndex = 17;
            this.btn_minus15.Text = "-15";
            this.btn_minus15.UseVisualStyleBackColor = true;
            this.btn_minus15.Click += new System.EventHandler(this.btn_minus15_Click);
            // 
            // btn_add15
            // 
            this.btn_add15.Location = new System.Drawing.Point(907, 479);
            this.btn_add15.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_add15.Name = "btn_add15";
            this.btn_add15.Size = new System.Drawing.Size(68, 58);
            this.btn_add15.TabIndex = 18;
            this.btn_add15.Text = "+15";
            this.btn_add15.UseVisualStyleBackColor = true;
            this.btn_add15.Click += new System.EventHandler(this.btn_add15_Click);
            // 
            // trackBarVolume
            // 
            this.trackBarVolume.Location = new System.Drawing.Point(980, 479);
            this.trackBarVolume.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.trackBarVolume.Maximum = 100;
            this.trackBarVolume.Name = "trackBarVolume";
            this.trackBarVolume.Size = new System.Drawing.Size(146, 56);
            this.trackBarVolume.TabIndex = 19;
            this.trackBarVolume.TickFrequency = 10;
            this.trackBarVolume.Value = 50;
            this.trackBarVolume.Scroll += new System.EventHandler(this.trackBarVolume_Scroll);
            // 
            // labelVolume
            // 
            this.labelVolume.AutoSize = true;
            this.labelVolume.Location = new System.Drawing.Point(988, 518);
            this.labelVolume.Name = "labelVolume";
            this.labelVolume.Size = new System.Drawing.Size(0, 16);
            this.labelVolume.TabIndex = 20;
            // 
            // trackBarProgress
            // 
            this.trackBarProgress.Location = new System.Drawing.Point(12, 397);
            this.trackBarProgress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.trackBarProgress.Name = "trackBarProgress";
            this.trackBarProgress.Size = new System.Drawing.Size(858, 56);
            this.trackBarProgress.SmallChange = 10;
            this.trackBarProgress.TabIndex = 21;
            this.trackBarProgress.Scroll += new System.EventHandler(this.trackBarProgress_Scroll);
            // 
            // Timer1
            // 
            this.Timer1.Enabled = true;
            this.Timer1.Interval = 1000;
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // labelCurrentTime
            // 
            this.labelCurrentTime.AutoSize = true;
            this.labelCurrentTime.Location = new System.Drawing.Point(19, 427);
            this.labelCurrentTime.Name = "labelCurrentTime";
            this.labelCurrentTime.Size = new System.Drawing.Size(38, 16);
            this.labelCurrentTime.TabIndex = 22;
            this.labelCurrentTime.Text = "00:00";
            // 
            // labelTotalTime
            // 
            this.labelTotalTime.AutoSize = true;
            this.labelTotalTime.Location = new System.Drawing.Point(76, 427);
            this.labelTotalTime.Name = "labelTotalTime";
            this.labelTotalTime.Size = new System.Drawing.Size(38, 16);
            this.labelTotalTime.TabIndex = 23;
            this.labelTotalTime.Text = "00:00";
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(6, 11);
            this.axWindowsMediaPlayer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(869, 565);
            this.axWindowsMediaPlayer1.TabIndex = 0;
            this.axWindowsMediaPlayer1.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.axWindowsMediaPlayer1_PlayStateChange);
            this.axWindowsMediaPlayer1.Enter += new System.EventHandler(this.axWindowsMediaPlayer1_Enter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1359, 562);
            this.Controls.Add(this.labelTotalTime);
            this.Controls.Add(this.labelCurrentTime);
            this.Controls.Add(this.trackBarProgress);
            this.Controls.Add(this.labelVolume);
            this.Controls.Add(this.trackBarVolume);
            this.Controls.Add(this.btn_add15);
            this.Controls.Add(this.btn_minus15);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.search);
            this.Controls.Add(this.labelSpeed);
            this.Controls.Add(this.trackBarSpeed);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_sortDESC);
            this.Controls.Add(this.btn_sort);
            this.Controls.Add(this.labelNowPlaying);
            this.Controls.Add(this.listBoxPlaylist);
            this.Controls.Add(this.btn_remove);
            this.Controls.Add(this.btn_shuffle);
            this.Controls.Add(btn_first);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.btn_play);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarProgress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btn_play;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Button btn_shuffle;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.ListBox listBoxPlaylist;
        private System.Windows.Forms.Button btn_sort;
        private System.Windows.Forms.Button btn_sortDESC;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TrackBar trackBarSpeed;
        private System.Windows.Forms.Label labelSpeed;
        private System.Windows.Forms.Label labelNowPlaying;
        private System.Windows.Forms.TextBox search;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_minus15;
        private System.Windows.Forms.Button btn_add15;
        private System.Windows.Forms.TrackBar trackBarVolume;
        private System.Windows.Forms.Label labelVolume;
        private System.Windows.Forms.TrackBar trackBarProgress;
        private System.Windows.Forms.Timer Timer1;
        private System.Windows.Forms.Label labelCurrentTime;
        private System.Windows.Forms.Label labelTotalTime;
    }
}

