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
    public partial class Timer : Form
    {
        public Timer()
        {
            InitializeComponent();
            
        }

        SoundPlayer sound = new SoundPlayer(@"Godzilla (feat. Juice WRLD) [Official Audio].wav");

        List<TimerAndAlarm> timers = new List<TimerAndAlarm>();


        private void timer1_Tick(object sender, EventArgs e)
        {
           
            for (int i = 0; i < timers.Count; ++i)
            {
                bool isSelected = false, isHide = (timers[i].getIndex() == -1);
                if(!isHide)
                    isSelected = listBoxTimersAndAlarms.GetSelected(timers[i].getIndex());
                DateTime currentTime = DateTime.Now;
                if (timers[i].getType() == false)//timer
                {
                    if (timers[i].getValue() == timers[i].getValue().Date)
                    {
                        isHide = true;
                        deleteFromListBox(i);
                        string a = timers[i].getStartValue().ToString(@"hh\:mm\:ss");
                        timers.RemoveAt(i);
                        indexMinUpdate();
                        if (!isDontDisturbMode.Checked)
                        {
                            sound.Play();
                            MessageBox.Show("Time of timer for " + a + " is out");
                            sound.Stop();
                           
                        }
                    }
                    else
                    {
                        if(timers[i].getActive())
                            --timers[i];
                        if (!isHide)
                        {
                            listBoxTimersAndAlarms.Items[timers[i].getIndex()] = "Timer " + timers[i].getStartValue().ToString(@"hh\:mm\:ss")
                                 + "\tRemaining time " + timers[i].getValue().ToString("HH:mm:ss");
                            listBoxTimersAndAlarms.SetSelected(timers[i].getIndex(), isSelected);
                        }
                                
                    }
                }
                else
                {
                    if (timers[i].getValue() <= DateTime.Now)
                    {
                        isHide = true;
                        deleteFromListBox(i);
                        string a = timers[i].getStartValue().ToString(@"hh\:mm\:ss");
                        timers.RemoveAt(i);
                        indexMinUpdate();
                        if (!isDontDisturbMode.Checked)
                        {
                            sound.Play();
                            MessageBox.Show("Time of alarm for "+ a +  " is out");
                            sound.Stop();
                        }
                       
                    }
                    else
                    {
                        if (!isHide)
                        {
                            listBoxTimersAndAlarms.Items[timers[i].getIndex()] = ( "Alarm "  + timers[i].getValue().ToString(@"HH\:mm\:ss")
                                                            + "\tRemaining time " + timers[i].getRemainingTime().ToString(@"dd\.hh\:mm\:ss"));

                            listBoxTimersAndAlarms.SetSelected(timers[i].getIndex(), isSelected);
                        }
                                
                    }
                }
                    
            }
            indexMinUpdate();
            progressBarUpdate();
        }


        int numOfTimers = 0;
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if(dateTimePicker.Value != dateTimePicker.Value.Date)
            if(isTimer.Checked)
            {
                    numberOfTimers.Text = "Number of timers: " + ++numOfTimers;
                    if(!alarmsToolStripMenuItem.Checked)
                    {
                        listBoxTimersAndAlarms.Items.Add("Timer " + dateTimePicker.Value.TimeOfDay.ToString()
                                + "\tRemaining time " + dateTimePicker.Value.TimeOfDay.ToString());
                        timers.Add(new TimerAndAlarm(dateTimePicker.Value, listBoxTimersAndAlarms.Items.Count - 1, false));
                    }
                    else
                    {
                        timers.Add(new TimerAndAlarm(dateTimePicker.Value, -1, false));
                    }
                    

            }
            else if(isAlarm.Checked)
            {
                   if (dateTimePicker.Value<=DateTime.Now)
                    {
                        MessageBox.Show("Our time is less than current. Error.");
                    }
                   else
                    {

                        numberOfTimers.Text = "Number of timers: " + ++numOfTimers;
                        if (!timersToolStripMenuItem.Checked)
                        {
                            DateTime cur = DateTime.Now;

                            TimeSpan t = dateTimePicker.Value.Subtract(cur);
                            listBoxTimersAndAlarms.Items.Add("Alarm " + dateTimePicker.Value.TimeOfDay.ToString()
                               + "\tRemaining time " + t.ToString(@"dd\.hh\:mm\:ss"));
                            timers.Add(new TimerAndAlarm(dateTimePicker.Value, listBoxTimersAndAlarms.Items.Count - 1, true));
                        }
                        else
                           timers.Add(new TimerAndAlarm(dateTimePicker.Value,  -1, true));
                    }
                    
             }
            indexMinUpdate();
            progressBarUpdate();
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
            for (int i = timers.Count - 1; i >=0; --i)
            {
                if(timers[i].getIndex()!= -1 && listBoxTimersAndAlarms.GetSelected(timers[i].getIndex()))
                {
                    deleteFromListBox(i);
                    timers.RemoveAt(i);
                }
            }
            indexMinUpdate();
            progressBarUpdate();
        }

        private void deleteFromListBox(int index)
        {
            if (timers[index].getIndex() == -1)
                return;
            numberOfTimers.Text = "Number of timers: " + --numOfTimers;
            listBoxTimersAndAlarms.Items.RemoveAt(timers[index].getIndex());
            for(int i=0;i<timers.Count;++i)
            {
                if(timers[i].getIndex() > timers[index].getIndex())
                {
                    timers[i].setIndex(timers[i].getIndex()-1);
                }
            }
        }

        private void allToolStripMenuItem_Click(object sender, EventArgs e)
        {
            allToolStripMenuItem.Checked = true;
            timersToolStripMenuItem.Checked = false;
            alarmsToolStripMenuItem.Checked = false;
            listBoxTimersAndAlarms.Items.Clear();
            for(int i=0;i<timers.Count;++i) //adding all elements from timers
            {
                if(timers[i].getType() == false)//timer
                {
                    timers[i].setIndex(listBoxTimersAndAlarms.Items.Count);
                    listBoxTimersAndAlarms.Items.Add("Timer " + timers[i].getStartValue().ToString(@"dd\.hh\:mm\:ss")
                               + "\tRemaining time " + timers[i].getValue().ToString("HH:mm:ss"));
                }
                else
                {
                    timers[i].setIndex(listBoxTimersAndAlarms.Items.Count);
                    listBoxTimersAndAlarms.Items.Add("Alarm " + timers[i].getStartValue().ToString(@"dd\.hh\:mm\:ss")
                               + "\tRemaining time " + timers[i].getRemainingTime().ToString(@"dd\.hh\:mm\:ss"));
                }
            }
        }

        private void timersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            allToolStripMenuItem.Checked = false;
            timersToolStripMenuItem.Checked = true;
            alarmsToolStripMenuItem.Checked = false;

            listBoxTimersAndAlarms.Items.Clear();
            for (int i = 0; i < timers.Count; ++i) //adding timer elements from timers
            {
                if (timers[i].getType() == false)//timer
                {
                    timers[i].setIndex(listBoxTimersAndAlarms.Items.Count);
                    listBoxTimersAndAlarms.Items.Add("Timer " + timers[i].getStartValue().ToString(@"hh\:mm\:ss")
                               + "\tRemaining time " + timers[i].getValue().ToString("HH:mm:ss"));
                }
                else
                {
                    timers[i].setIndex();
                }
            }
        }

        private void alarmsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            allToolStripMenuItem.Checked = false;
            timersToolStripMenuItem.Checked = false;
            alarmsToolStripMenuItem.Checked = true;

            listBoxTimersAndAlarms.Items.Clear();
            for (int i = 0; i < timers.Count; ++i) //adding alarm elements from timers
            {
                if (timers[i].getType() == false)//timers
                {
                    timers[i].setIndex();
                }
                else
                {
                    timers[i].setIndex(listBoxTimersAndAlarms.Items.Count);
                    listBoxTimersAndAlarms.Items.Add("Alarm " + timers[i].getStartValue().ToString(@"dd\.hh\:mm\:ss")
                               + "\tRemaining time " + timers[i].getRemainingTime().ToString(@"dd\.hh\:mm\:ss"));
                }
            }
        }


        int indexMin = -1;
        private void indexMinUpdate()
        {
            TimeSpan minValue = new TimeSpan();
            indexMin = -1;
            for (int i = 0; i<timers.Count;++i)
            {
                if(i==0)
                {
                    indexMin = 0;
                    if (timers[i].getType() == false)
                        minValue = timers[i].toTimeSpan();
                    else
                        minValue = timers[i].getRemainingTime();
                    continue;
                }
                if (timers[i].getType() == false)
                    if (TimeSpan.Compare(minValue, timers[i].toTimeSpan()) > 0)
                    {
                        indexMin = i;
                        minValue = timers[i].toTimeSpan();
                    }

                if (timers[i].getType() == true)
                    if (TimeSpan.Compare(minValue, timers[i].getRemainingTime()) > 0)
                    {
                        indexMin = i;
                        minValue = timers[i].getRemainingTime();
                    }
            }
        }
        private void progressBarUpdate()
        {
            if (indexMin == -1)
            {
                progressBar.Value = 0;
                return;
            }
            if(timers[indexMin].getType() == false)
            {
                progressBar.Maximum = Convert.ToInt32(timers[indexMin].getStartValue().TotalSeconds);
                progressBar.Value = Convert.ToInt32(timers[indexMin].toTimeSpan().TotalSeconds);
                return;
            }
            if(timers[indexMin].getType() == true)
            {
                progressBar.Maximum = Convert.ToInt32(timers[indexMin].getStartValue().TotalSeconds);
                progressBar.Value = Convert.ToInt32(timers[indexMin].getRemainingTime().TotalSeconds);
            }

        }

        private void buttonPR_Click(object sender, EventArgs e)
        {
            for (int i = timers.Count - 1; i >= 0; --i)
            {
                if (timers[i].getIndex() != -1 && listBoxTimersAndAlarms.GetSelected(timers[i].getIndex()))
                {
                    timers[i].pauseResume();
                }
            }
        }
    }
}
