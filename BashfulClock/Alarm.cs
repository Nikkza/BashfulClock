using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BashfulClock
{
    class Alarm
    {
        private int _alarmHour;
        private int _alarmMinute;
        private bool alarmRunning = false; 

        public void CheckAlarm(int clockHour, int clockMinute)
        {
            if (clockHour == _alarmHour && clockMinute == _alarmMinute)
            {
                alarmRunning = true;
            }
            else
            {
                alarmRunning = false;
            }
        }

        public bool GetRunningAlarm()
        {
            return alarmRunning;
        }

        public void SetAlarm(int alarmHour, int alarmMinute)
        {
            _alarmHour = alarmHour;
            _alarmMinute = alarmMinute;
        }
    }
}
