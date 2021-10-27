using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

public class TimerAndAlarm
{
    DateTime value;
    TimeSpan startValue;
    bool typeOfTimer;//false - timer; true - alarma
    bool isActive; //for timers
    int indexInListBox;

    public TimerAndAlarm()
    {
        value = new DateTime(0,0,0,0,0,0);
        typeOfTimer = false;
        isActive = false;
        indexInListBox = -1;
    }
    public TimerAndAlarm(DateTime inputValue, int index = -1, bool type = false)
    {
        setValue(inputValue, type);
        if (type)
            startValue = value.Subtract(DateTime.Now);
        else
            startValue = value.Subtract(DateTime.Now.Date);
        indexInListBox = index;
        isActive = false;
    }
    public void pauseResume()
    {
        isActive = !isActive;
    }

    public bool getActive()
    {
        return isActive;
    }
    public DateTime getValue()
    {
        return value;
    }
    public TimeSpan getStartValue()
    {
        return startValue;
    }
    public bool getType()
    {
        return typeOfTimer;
    }
    public void setValue(DateTime inputValue, bool type = false)
    {
        value = inputValue;
        typeOfTimer = type;
    }
    public static TimerAndAlarm operator --(TimerAndAlarm t)
    {
        TimerAndAlarm ans = t;
        ans.setValue(t.value.AddSeconds(-1));
        return ans;
    }
    public TimeSpan getRemainingTime()//method for alarms
    {
        DateTime cur = DateTime.Now;

        TimeSpan t = value.Subtract(cur);
        return t;
    }
    public int getIndex()
    {
        return indexInListBox;
    }
    public void setIndex(int index = -1)
    {
        indexInListBox = index;
    }
    public TimeSpan toTimeSpan()//method for timers to get value with timespan type
    {
        return value.Subtract(DateTime.Now.Date);
    }
}


namespace TimerAndAlarmClock
{
    static class Program
    {
        /// <summary>
        /// The main entry polint for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Timer());
        }
    }
}
