using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BashfulClock
{
    class Minute
    {
        private int _minuteValue;

        public int GetMinuteValue()
        {
            return _minuteValue;
        }

        public void SetMinuteValue(int minuteValue)
        {
            _minuteValue = minuteValue;
        }

        public void Tick()
        {
            _minuteValue++;
        }

    }
}
