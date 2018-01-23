using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BashfulClock
{
    class Clock
    {
        public static bool isRunning = true;
        public Alarm alarm1 { get; set; }
        public Alarm alarm2 { get; set; }
        public event EventHandler clockEventHandler;
        Hour hour = new Hour();
        Minute minute = new Minute();       

        //Tar in minut värdet
        public int GetMinutes()
        {
            return minute.GetMinuteValue();
        }

        //Tar in Timm värdet
        public int GetHours()
        {
            return hour.GetHourValue();
        }
        
        public void AlarmHandler(bool closeAlarm, Alarm alarm)
        {
            if (closeAlarm)
            {
                alarm = null;
            }
        }

        public void AlarmHandler(int alarmHour, int alarmMinute, Alarm alarm)
        {
            alarm.SetAlarm(alarmHour, alarmMinute);
        }

        public void SetTime(int userHour, int userMinute)
        {
            hour.SetHourValue(userHour);
            minute.SetMinuteValue(userMinute);
        }

        //Startar klockan och får klockan att ticka
        public void StartClock()
        {
            while (isRunning)
            {
                Thread.Sleep(1000);
                if (!(minute.GetMinuteValue() >= 59))
                {
                    minute.Tick();
                }
                else
                {
                    minute.SetMinuteValue(0);

                    if (!(hour.GetHourValue() >= 23))
                    {
                        hour.Tick();
                    }
                    else
                        hour.SetHourValue(0);
                }
                //Kollar om alarmet stämmer överrens med tiden
                if (alarm1 != null)
                {
                    alarm1.CheckAlarm(hour.GetHourValue(), minute.GetMinuteValue());
                }

                if (alarm2 != null)
                {
                    alarm2.CheckAlarm(hour.GetHourValue(), minute.GetMinuteValue());
                }
                clockEventHandler(this, new EventArgs());
            }
        }
        public void StopClock()
        {
            isRunning = false;
        }       
    }
}
