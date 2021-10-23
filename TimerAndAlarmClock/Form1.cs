using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;



namespace TimerAndAlarmClock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SoundPlayer sound = new SoundPlayer(@"D:\Codes_Cpp\TimerAndAlarmClock\TimerAndAlarmClock\Airmow - Time (ft. ROSA).wav");

        List<TimerAndAlarm> timers = new List<TimerAndAlarm>();
        private string Int2StringTime(long time)
        {
            long hours = (time - (time % (60 * 60))) / (60 * 60);
            long minutes = (time - time % 60) / 60 - hours * 60;
            long seconds = time - hours * 60 * 60 - minutes * 60;
            return String.Format("{0:00}:{1:00}:{2:00}", hours, minutes, seconds);
        }

        private long time2Seconds(DateTime t)
        {
            return 3600 * t.Hour + 60 * t.Minute + t.Second;
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            if(timers.Count!=0)
                for (int i = 0; i < listBoxTimersAndAlarms.Items.Count; i+=2)
                {
                    DateTime currentTime = DateTime.Now;
                    if (timers[i / 2].getType() == false)//timer
                    {
                        if (timers[i / 2].getValue() == timers[i / 2].getValue().Date)
                        {
                            listBoxTimersAndAlarms.Items.RemoveAt(i+1);
                            listBoxTimersAndAlarms.Items.RemoveAt(i);
                            sound.Play();
                            MessageBox.Show("Time of " + (i + 1) + (timers[i / 2].getType() ? " alarm" : " timer") + " is out");
                            sound.Stop();
                            timers.RemoveAt(i / 2);
                            
                        }
                        else
                        {
                            --timers[i / 2];
                            listBoxTimersAndAlarms.Items[i + 1] = ("Remaining time " + timers[i / 2].getValue().ToString("HH:mm:ss"));
                        }
                    }
                    else
                    {
                        if (timers[i / 2].getValue() <= DateTime.Now)
                        {
                            listBoxTimersAndAlarms.Items.RemoveAt(i+1);
                            listBoxTimersAndAlarms.Items.RemoveAt(i);
                            
                            MessageBox.Show("Time of " + (i + 1) + (timers[i/2].getType()? " alarm" : " timer") +" is out");
                            timers.RemoveAt(i / 2);
                            Console.Beep();
                        }
                        else
                        {
                            DateTime cur = DateTime.Now;
                            
                             TimeSpan t = timers[i / 2].getValue().Subtract(cur);
                            listBoxTimersAndAlarms.Items[i + 1] = ("Remaining time " + t.ToString(@"dd\.hh\:mm\:ss"));
                        }
                    }
                }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if(dateTimePicker.Value != dateTimePicker.Value.Date)
            if(isTimer.Checked)
            {
                timers.Add(new TimerAndAlarm(dateTimePicker.Value, false));
                listBoxTimersAndAlarms.Items.Add("Timer " + dateTimePicker.Value.TimeOfDay.ToString());
                listBoxTimersAndAlarms.Items.Add("Remaining time " + dateTimePicker.Value.TimeOfDay.ToString());
                
            }
            else if(isAlarm.Checked)
            {
                   if (dateTimePicker.Value<=DateTime.Now)
                    {
                        MessageBox.Show("Our time is less than current. Error.");
                    }
                   else
                    {
                        timers.Add(new TimerAndAlarm(dateTimePicker.Value, true));
                        DateTime cur = DateTime.Now;

                        TimeSpan t = dateTimePicker.Value.Subtract(cur);
                        listBoxTimersAndAlarms.Items.Add("Alarm " + dateTimePicker.Value.TimeOfDay.ToString());
                        listBoxTimersAndAlarms.Items.Add("Remaining time " + t.ToString(@"dd\.hh\:mm\:ss"));
                    }
                    
                }
        }

        private void isTimer_CheckedChanged(object sender, EventArgs e)
        {
           /* dateTimePicker.Format = DateTimePickerFormat.Time;*/
            dateTimePicker.Value = DateTime.Now.Date;
        }

        private void isAlarm_CheckedChanged(object sender, EventArgs e)
        {
           /*dateTimePicker.Format = DateTimePickerFormat.Custom;
            dateTimePicker.CustomFormat = "MM/dd/yyyy HH:mm:ss";*/
            dateTimePicker.Value = DateTime.Now;
        }

        private void listBoxTimersAndAlarms_SelectedIndexChanged(object sender, EventArgs e)
        {
           /* if (listBoxTimersAndAlarms.SelectedIndex % 2 == 1)
                listBoxTimersAndAlarms.SelectedIndex--;
                MessageBox.Show(listBoxTimersAndAlarms.SelectedIndex.ToString());*/
        }
    }
}
