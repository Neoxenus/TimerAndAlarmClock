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

        SoundPlayer sound = new SoundPlayer(@"D:\Codes_Cpp\TimerAndAlarmClock\TimerAndAlarmClock\Godzilla (feat. Juice WRLD) [Official Audio].wav");

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
                for (int i = 0; i < timers.Count; ++i)
                {
                    bool isSelected = listBoxTimersAndAlarms.GetSelected(timers[i].getIndex());
                    DateTime currentTime = DateTime.Now;
                    if (timers[i].getType() == false)//timer
                    {
                        if (timers[i].getValue() == timers[i].getValue().Date)
                        {
                            deleteFromListBox(i);
                            if(!isDontDisturbMode.Checked)
                            {
                                sound.Play();
                                MessageBox.Show("Time of " + (i + 1) + (timers[i].getType() ? " alarm" : " timer") + " is out");
                                sound.Stop();
                            }
                            timers.RemoveAt(i);
                            
                        }
                        else
                        {
                            --timers[i];
                            listBoxTimersAndAlarms.Items[timers[i].getIndex()] = ("Timer " + timers[i].getStartValue().ToString("HH:mm:ss")
                               + "\tRemaining time " + timers[i].getValue().ToString("HH:mm:ss"));
                            listBoxTimersAndAlarms.SetSelected(timers[i].getIndex(), isSelected);
                        }
                    }
                    else
                    {
                        if (timers[i].getValue() <= DateTime.Now)
                        {
                            deleteFromListBox(i);

                            if (!isDontDisturbMode.Checked)
                            {
                                sound.Play();
                                MessageBox.Show("Time of " + (i + 1) + (timers[i].getType() ? " alarm" : " timer") + " is out");
                                sound.Stop();
                            }
                            timers.RemoveAt(i);
                        }
                        else
                        {
                            DateTime cur = DateTime.Now;
                            
                             TimeSpan t = timers[i].getValue().Subtract(cur);
                            listBoxTimersAndAlarms.Items[timers[i].getIndex()] = ("Alarm " + timers[i].getStartValue().ToString("HH:mm:ss")
                                + "\tRemaining time " + timers[i].getRemainingTime().ToString(@"dd\.hh\:mm\:ss"));
                            listBoxTimersAndAlarms.SetSelected(timers[i].getIndex(), isSelected);
                        }
                    }
                    
                }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if(dateTimePicker.Value != dateTimePicker.Value.Date)
            if(isTimer.Checked)
            {
                    listBoxTimersAndAlarms.Items.Add("Timer " + dateTimePicker.Value.TimeOfDay.ToString()
                            + "\tRemaining time " + dateTimePicker.Value.TimeOfDay.ToString());
                    timers.Add(new TimerAndAlarm(dateTimePicker.Value, listBoxTimersAndAlarms.Items.Count - 1, false));

            }
            else if(isAlarm.Checked)
            {
                   if (dateTimePicker.Value<=DateTime.Now)
                    {
                        MessageBox.Show("Our time is less than current. Error.");
                    }
                   else
                    {
                       
                        DateTime cur = DateTime.Now;

                        TimeSpan t = dateTimePicker.Value.Subtract(cur);
                        listBoxTimersAndAlarms.Items.Add("Alarm " + dateTimePicker.Value.TimeOfDay.ToString()
                            + "\tRemaining time " + t.ToString(@"dd\.hh\:mm\:ss"));
                        timers.Add(new TimerAndAlarm(dateTimePicker.Value, listBoxTimersAndAlarms.Items.Count - 1, true));
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

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (timers.Count != 0)
                for (int i = timers.Count - 1; i >=0; --i)
                {
                    if(listBoxTimersAndAlarms.GetSelected(timers[i].getIndex()))
                    {
                        deleteFromListBox(i);
                        timers.RemoveAt(i);
                    }
                }
        }

        private void deleteFromListBox(int index)
        {
            listBoxTimersAndAlarms.Items.RemoveAt(timers[index].getIndex());
            for(int i=0;i<timers.Count;++i)
            {
                if(timers[i].getIndex() > timers[index].getIndex())
                {
                    timers[i].setIndex(timers[i].getIndex()-1);
                }
            }
        }
    }
}
