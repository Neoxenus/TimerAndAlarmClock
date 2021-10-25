
namespace TimerAndAlarmClock
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
            this.listBoxTimersAndAlarms = new System.Windows.Forms.ListBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.isTimer = new System.Windows.Forms.RadioButton();
            this.isAlarm = new System.Windows.Forms.RadioButton();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.isDontDisturbMode = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxTimersAndAlarms
            // 
            this.listBoxTimersAndAlarms.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxTimersAndAlarms.FormattingEnabled = true;
            this.listBoxTimersAndAlarms.Location = new System.Drawing.Point(12, 194);
            this.listBoxTimersAndAlarms.Name = "listBoxTimersAndAlarms";
            this.listBoxTimersAndAlarms.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxTimersAndAlarms.Size = new System.Drawing.Size(360, 147);
            this.listBoxTimersAndAlarms.TabIndex = 6;
            this.listBoxTimersAndAlarms.SelectedIndexChanged += new System.EventHandler(this.listBoxTimersAndAlarms_SelectedIndexChanged);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker.Location = new System.Drawing.Point(12, 12);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(360, 20);
            this.dateTimePicker.TabIndex = 7;
            this.dateTimePicker.Value = new System.DateTime(2021, 10, 23, 0, 0, 0, 0);
            // 
            // isTimer
            // 
            this.isTimer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.isTimer.AutoSize = true;
            this.isTimer.Checked = true;
            this.isTimer.Location = new System.Drawing.Point(6, 19);
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
            this.isAlarm.Location = new System.Drawing.Point(273, 19);
            this.isAlarm.Name = "isAlarm";
            this.isAlarm.Size = new System.Drawing.Size(81, 17);
            this.isAlarm.TabIndex = 10;
            this.isAlarm.Text = "Alarm Clock";
            this.isAlarm.UseVisualStyleBackColor = true;
            this.isAlarm.CheckedChanged += new System.EventHandler(this.isAlarm_CheckedChanged);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(6, 19);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(157, 30);
            this.buttonAdd.TabIndex = 11;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
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
            this.groupBox1.Location = new System.Drawing.Point(12, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 62);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.buttonDelete);
            this.groupBox2.Controls.Add(this.buttonAdd);
            this.groupBox2.Location = new System.Drawing.Point(12, 106);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(360, 62);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDelete.Location = new System.Drawing.Point(197, 19);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(157, 30);
            this.buttonDelete.TabIndex = 13;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // isDontDisturbMode
            // 
            this.isDontDisturbMode.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.isDontDisturbMode.AutoSize = true;
            this.isDontDisturbMode.Location = new System.Drawing.Point(120, 19);
            this.isDontDisturbMode.Name = "isDontDisturbMode";
            this.isDontDisturbMode.Size = new System.Drawing.Size(87, 17);
            this.isDontDisturbMode.TabIndex = 11;
            this.isDontDisturbMode.Text = "Don\'t Disturb";
            this.isDontDisturbMode.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.listBoxTimersAndAlarms);
            this.MinimumSize = new System.Drawing.Size(400, 400);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox listBoxTimersAndAlarms;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.RadioButton isTimer;
        private System.Windows.Forms.RadioButton isAlarm;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.CheckBox isDontDisturbMode;
    }
}

