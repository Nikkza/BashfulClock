using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BashfulClock
{
    class Hour
    {
        private int _hourValue;

        public int GetHourValue()
        {
            return _hourValue;
        }

        public void SetHourValue(int hourValue)
        {
            _hourValue = hourValue;
        }

        public void Tick()
        {
            _hourValue++;
        }
    }
}
