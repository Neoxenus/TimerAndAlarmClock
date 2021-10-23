
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
            this.SuspendLayout();
            // 
            // listBoxTimersAndAlarms
            // 
            this.listBoxTimersAndAlarms.FormattingEnabled = true;
            this.listBoxTimersAndAlarms.Location = new System.Drawing.Point(11, 68);
            this.listBoxTimersAndAlarms.Name = "listBoxTimersAndAlarms";
            this.listBoxTimersAndAlarms.Size = new System.Drawing.Size(312, 160);
            this.listBoxTimersAndAlarms.TabIndex = 6;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker.Location = new System.Drawing.Point(12, 8);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(310, 20);
            this.dateTimePicker.TabIndex = 7;
            this.dateTimePicker.Value = new System.DateTime(2021, 10, 23, 0, 0, 0, 0);
            // 
            // isTimer
            // 
            this.isTimer.AutoSize = true;
            this.isTimer.Checked = true;
            this.isTimer.Location = new System.Drawing.Point(13, 42);
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
            this.isAlarm.AutoSize = true;
            this.isAlarm.Location = new System.Drawing.Point(115, 42);
            this.isAlarm.Name = "isAlarm";
            this.isAlarm.Size = new System.Drawing.Size(81, 17);
            this.isAlarm.TabIndex = 10;
            this.isAlarm.Text = "Alarm Clock";
            this.isAlarm.UseVisualStyleBackColor = true;
            this.isAlarm.CheckedChanged += new System.EventHandler(this.isAlarm_CheckedChanged);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(247, 39);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 266);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.isAlarm);
            this.Controls.Add(this.isTimer);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.listBoxTimersAndAlarms);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBoxTimersAndAlarms;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.RadioButton isTimer;
        private System.Windows.Forms.RadioButton isAlarm;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Timer timer1;
    }
}

