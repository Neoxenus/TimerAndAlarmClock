
namespace TimerAndAlarmClock
{
    partial class Timer
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
            this.listBoxTimersAndAlarms = new System.Windows.Forms.ListBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.isTimer = new System.Windows.Forms.RadioButton();
            this.isAlarm = new System.Windows.Forms.RadioButton();
            this.buttonPause = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.isDontDisturbMode = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonPR = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.filtrationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alarmsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.numberOfTimers = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxTimersAndAlarms
            // 
            this.listBoxTimersAndAlarms.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxTimersAndAlarms.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxTimersAndAlarms.FormattingEnabled = true;
            this.listBoxTimersAndAlarms.ItemHeight = 16;
            this.listBoxTimersAndAlarms.Location = new System.Drawing.Point(12, 190);
            this.listBoxTimersAndAlarms.Name = "listBoxTimersAndAlarms";
            this.listBoxTimersAndAlarms.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxTimersAndAlarms.Size = new System.Drawing.Size(424, 308);
            this.listBoxTimersAndAlarms.TabIndex = 6;
            this.listBoxTimersAndAlarms.SelectedIndexChanged += new System.EventHandler(this.listBoxTimersAndAlarms_SelectedIndexChanged);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker.Location = new System.Drawing.Point(12, 81);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(424, 31);
            this.dateTimePicker.TabIndex = 7;
            this.dateTimePicker.Value = new System.DateTime(2021, 10, 27, 0, 0, 0, 0);
            // 
            // isTimer
            // 
            this.isTimer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.isTimer.AutoSize = true;
            this.isTimer.Checked = true;
            this.isTimer.Location = new System.Drawing.Point(6, 20);
            this.isTimer.Name = "isTimer";
            this.isTimer.Size = new System.Drawing.Size(51, 17);
            this.isTimer.TabIndex = 9;
            this.isTimer.TabStop = true;
            this.isTimer.Text = "Timer";
            this.isTimer.UseVisualStyleBackColor = true;
            this.isTimer.CheckedChanged += new System.EventHandler(this.isTimer_CheckedChanged);
            // 
            // isAlarm
            // 
            this.isAlarm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.isAlarm.AutoSize = true;
            this.isAlarm.Location = new System.Drawing.Point(337, 20);
            this.isAlarm.Name = "isAlarm";
            this.isAlarm.Size = new System.Drawing.Size(81, 17);
            this.isAlarm.TabIndex = 10;
            this.isAlarm.Text = "Alarm Clock";
            this.isAlarm.UseVisualStyleBackColor = true;
            this.isAlarm.CheckedChanged += new System.EventHandler(this.isAlarm_CheckedChanged);
            // 
            // buttonPause
            // 
            this.buttonPause.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPause.Location = new System.Drawing.Point(6, 20);
            this.buttonPause.Name = "buttonPause";
            this.buttonPause.Size = new System.Drawing.Size(91, 30);
            this.buttonPause.TabIndex = 11;
            this.buttonPause.Text = "Add";
            this.buttonPause.UseVisualStyleBackColor = true;
            this.buttonPause.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.isDontDisturbMode);
            this.groupBox1.Controls.Add(this.isTimer);
            this.groupBox1.Controls.Add(this.isAlarm);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(424, 48);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // isDontDisturbMode
            // 
            this.isDontDisturbMode.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.isDontDisturbMode.AutoSize = true;
            this.isDontDisturbMode.Location = new System.Drawing.Point(152, 20);
            this.isDontDisturbMode.Name = "isDontDisturbMode";
            this.isDontDisturbMode.Size = new System.Drawing.Size(87, 17);
            this.isDontDisturbMode.TabIndex = 11;
            this.isDontDisturbMode.Text = "Don\'t Disturb";
            this.isDontDisturbMode.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox2.Controls.Add(this.buttonPR);
            this.groupBox2.Controls.Add(this.buttonDelete);
            this.groupBox2.Controls.Add(this.buttonPause);
            this.groupBox2.Location = new System.Drawing.Point(12, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(424, 62);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            // 
            // buttonPR
            // 
            this.buttonPR.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonPR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPR.Location = new System.Drawing.Point(152, 20);
            this.buttonPR.Name = "buttonPR";
            this.buttonPR.Size = new System.Drawing.Size(132, 30);
            this.buttonPR.TabIndex = 14;
            this.buttonPR.Text = "Pause/Resume";
            this.buttonPR.UseVisualStyleBackColor = true;
            this.buttonPR.Click += new System.EventHandler(this.buttonPR_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDelete.Location = new System.Drawing.Point(337, 20);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(81, 30);
            this.buttonDelete.TabIndex = 13;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filtrationToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(448, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // filtrationToolStripMenuItem
            // 
            this.filtrationToolStripMenuItem.CheckOnClick = true;
            this.filtrationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allToolStripMenuItem,
            this.timersToolStripMenuItem,
            this.alarmsToolStripMenuItem});
            this.filtrationToolStripMenuItem.Name = "filtrationToolStripMenuItem";
            this.filtrationToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.filtrationToolStripMenuItem.Text = "Filtration";
            // 
            // allToolStripMenuItem
            // 
            this.allToolStripMenuItem.Checked = true;
            this.allToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.allToolStripMenuItem.Name = "allToolStripMenuItem";
            this.allToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.allToolStripMenuItem.Text = "All";
            this.allToolStripMenuItem.Click += new System.EventHandler(this.allToolStripMenuItem_Click);
            // 
            // timersToolStripMenuItem
            // 
            this.timersToolStripMenuItem.CheckOnClick = true;
            this.timersToolStripMenuItem.Name = "timersToolStripMenuItem";
            this.timersToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.timersToolStripMenuItem.Text = "Timers";
            this.timersToolStripMenuItem.Click += new System.EventHandler(this.timersToolStripMenuItem_Click);
            // 
            // alarmsToolStripMenuItem
            // 
            this.alarmsToolStripMenuItem.CheckOnClick = true;
            this.alarmsToolStripMenuItem.Name = "alarmsToolStripMenuItem";
            this.alarmsToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.alarmsToolStripMenuItem.Text = "Alarms";
            this.alarmsToolStripMenuItem.Click += new System.EventHandler(this.alarmsToolStripMenuItem_Click);
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.Location = new System.Drawing.Point(13, 513);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(423, 23);
            this.progressBar.TabIndex = 15;
            // 
            // numberOfTimers
            // 
            this.numberOfTimers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numberOfTimers.AutoSize = true;
            this.numberOfTimers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numberOfTimers.Location = new System.Drawing.Point(270, 9);
            this.numberOfTimers.Name = "numberOfTimers";
            this.numberOfTimers.Size = new System.Drawing.Size(122, 16);
            this.numberOfTimers.TabIndex = 16;
            this.numberOfTimers.Text = "Number of timers: 0";
            // 
            // Timer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 548);
            this.Controls.Add(this.numberOfTimers);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.listBoxTimersAndAlarms);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(400, 400);
            this.Name = "Timer";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBoxTimersAndAlarms;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.RadioButton isTimer;
        private System.Windows.Forms.RadioButton isAlarm;
        private System.Windows.Forms.Button buttonPause;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.CheckBox isDontDisturbMode;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem filtrationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem timersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alarmsToolStripMenuItem;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label numberOfTimers;
        private System.Windows.Forms.Button buttonPR;
    }
}

