using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/*public class TimerAndAlarm
{
    long value;
    bool typeOfTimer;//false - timer; true - alarma

    public TimerAndAlarm()
    {
        value = 0;
        typeOfTimer = false;
    }
    public TimerAndAlarm(long inputValue, bool type = false)
    {
        setValue(inputValue, type);
    }
    public long getValue()
    {
        return value;
    }
    public void setValue(long inputValue, bool type = false)
    {
        value = inputValue;
        typeOfTimer = type;
    }
    public static TimerAndAlarm operator --(TimerAndAlarm t)
    {
        return new TimerAndAlarm(t.value - 1, t.typeOfTimer);
    }
}*/

public class TimerAndAlarm
{
    DateTime value;
    bool typeOfTimer;//false - timer; true - alarma

    public TimerAndAlarm()
    {
        value = new DateTime(0,0,0,0,0,0);
        typeOfTimer = false;
    }
    public TimerAndAlarm(DateTime inputValue, bool type = false)
    {
        setValue(inputValue, type);
    }
    public DateTime getValue()
    {
        return value;
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
        return new TimerAndAlarm(t.value.AddSeconds(-1), t.typeOfTimer);
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
