namespace spotify_auto_pause
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
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.gbAdvanced = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cbAdvanced = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bwAudioDetect = new System.ComponentModel.BackgroundWorker();
            this.tTimer = new System.Windows.Forms.Timer(this.components);
            this.nDetectInterval = new System.Windows.Forms.NumericUpDown();
            this.nSilenceDuration = new System.Windows.Forms.NumericUpDown();
            this.cbStatus = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.gbAdvanced.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nDetectInterval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nSilenceDuration)).BeginInit();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // gbAdvanced
            // 
            this.gbAdvanced.Controls.Add(this.label3);
            this.gbAdvanced.Controls.Add(this.textBox1);
            this.gbAdvanced.Location = new System.Drawing.Point(3, 162);
            this.gbAdvanced.Name = "gbAdvanced";
            this.gbAdvanced.Size = new System.Drawing.Size(484, 48);
            this.gbAdvanced.TabIndex = 1;
            this.gbAdvanced.TabStop = false;
            this.gbAdvanced.Text = "Advanced";
            this.gbAdvanced.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Spotify Processes:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(106, 17);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(369, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Spotify,";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // cbAdvanced
            // 
            this.cbAdvanced.AutoSize = true;
            this.cbAdvanced.Checked = true;
            this.cbAdvanced.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbAdvanced.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbAdvanced.Location = new System.Drawing.Point(3, 138);
            this.cbAdvanced.Name = "cbAdvanced";
            this.cbAdvanced.Size = new System.Drawing.Size(81, 18);
            this.cbAdvanced.TabIndex = 2;
            this.cbAdvanced.Text = "Advanced";
            this.cbAdvanced.UseVisualStyleBackColor = true;
            this.cbAdvanced.CheckedChanged += new System.EventHandler(this.cbAdvanced_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Enabled = false;
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBox1.Location = new System.Drawing.Point(3, 4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(141, 18);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "Pause Spotify on audio";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Enabled = false;
            this.checkBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBox2.Location = new System.Drawing.Point(3, 53);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(138, 18);
            this.checkBox2.TabIndex = 4;
            this.checkBox2.Text = "Play Spotify on silence";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "ms";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "ms";
            // 
            // listView1
            // 
            this.listView1.CheckBoxes = true;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(135, 2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(352, 130);
            this.listView1.TabIndex = 9;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Process";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "hWnd";
            this.columnHeader2.Width = 50;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Audio";
            this.columnHeader3.Width = 75;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Total";
            this.columnHeader4.Width = 75;
            // 
            // bwAudioDetect
            // 
            this.bwAudioDetect.WorkerReportsProgress = true;
            this.bwAudioDetect.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwAudioDetect_DoWork);
            this.bwAudioDetect.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            // 
            // tTimer
            // 
            this.tTimer.Enabled = true;
            this.tTimer.Interval = 1000;
            this.tTimer.Tick += new System.EventHandler(this.tTimer_Tick);
            // 
            // nDetectInterval
            // 
            this.nDetectInterval.Location = new System.Drawing.Point(3, 27);
            this.nDetectInterval.Maximum = new decimal(new int[] {
            276447231,
            23283,
            0,
            0});
            this.nDetectInterval.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nDetectInterval.Name = "nDetectInterval";
            this.nDetectInterval.Size = new System.Drawing.Size(100, 20);
            this.nDetectInterval.TabIndex = 10;
            this.nDetectInterval.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nDetectInterval.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nDetectInterval.ValueChanged += new System.EventHandler(this.nDetectInterval_ValueChanged);
            // 
            // nSilenceDuration
            // 
            this.nSilenceDuration.Location = new System.Drawing.Point(3, 77);
            this.nSilenceDuration.Maximum = new decimal(new int[] {
            276447231,
            23283,
            0,
            0});
            this.nSilenceDuration.Minimum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.nSilenceDuration.Name = "nSilenceDuration";
            this.nSilenceDuration.Size = new System.Drawing.Size(100, 20);
            this.nSilenceDuration.TabIndex = 11;
            this.nSilenceDuration.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nSilenceDuration.Value = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            // 
            // cbStatus
            // 
            this.cbStatus.AutoSize = true;
            this.cbStatus.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.cbStatus.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbStatus.Location = new System.Drawing.Point(493, 4);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(111, 18);
            this.cbStatus.TabIndex = 12;
            this.cbStatus.Text = "Unknown Status";
            this.cbStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbStatus.UseVisualStyleBackColor = true;
            this.cbStatus.Visible = false;
            this.cbStatus.CheckedChanged += new System.EventHandler(this.cbStatus_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox3.Checked = true;
            this.checkBox3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBox3.Location = new System.Drawing.Point(3, 108);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(126, 24);
            this.checkBox3.TabIndex = 13;
            this.checkBox3.Text = "Enabled";
            this.checkBox3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(447, 146);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(40, 13);
            this.linkLabel1.TabIndex = 14;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "GitHub";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(706, 583);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.nSilenceDuration);
            this.Controls.Add(this.nDetectInterval);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.cbAdvanced);
            this.Controls.Add(this.gbAdvanced);
            this.Name = "Form1";
            this.Text = "Spotify Auto-Pause 0.1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbAdvanced.ResumeLayout(false);
            this.gbAdvanced.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nDetectInterval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nSilenceDuration)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.GroupBox gbAdvanced;
        private System.Windows.Forms.CheckBox cbAdvanced;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.ComponentModel.BackgroundWorker bwAudioDetect;
        private System.Windows.Forms.Timer tTimer;
        private System.Windows.Forms.NumericUpDown nDetectInterval;
        private System.Windows.Forms.NumericUpDown nSilenceDuration;
        private System.Windows.Forms.CheckBox cbStatus;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

