using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

public class TimerAndAlarm
{
    DateTime value, startValue;
    bool typeOfTimer;//false - timer; true - alarma
    int indexInListBox;

    public TimerAndAlarm()
    {
        value = new DateTime(0,0,0,0,0,0);
        startValue = value;
        typeOfTimer = false;
        indexInListBox = -1;
    }
    public TimerAndAlarm(DateTime inputValue, int index = -1, bool type = false)
    {
        setValue(inputValue, type);
        startValue = value;
        indexInListBox = index;
    }

    public DateTime getValue()
    {
        return value;
    }
    public DateTime getStartValue()
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
        TimerAndAlarm ans = new TimerAndAlarm(t.startValue, t.indexInListBox, t.typeOfTimer);
        ans.setValue(t.value.AddSeconds(-1));
        return ans;
    }
    public TimeSpan getRemainingTime()
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
            Application.Run(new Form1());
        }
    }
}
