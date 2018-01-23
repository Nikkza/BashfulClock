using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Windows.Forms;

namespace BashfulClock
{
    public static class Exstensions
    {
        public static bool CheckMinuteValue(this string minuteUserInput)
        {
            int x;
            if ((int.TryParse(minuteUserInput, out x) && (x <= 59 && x >= 0)))
            {
                return true;
            }
            else
                return false;
        }
        public static bool CheckHourValue(this string houreUserInput)
        {
            int y;
            if ((int.TryParse (houreUserInput, out y))&&(y <= 23 && y >= 0))
            {
                return true;
            }
            else
                return false;
        }
        public static void ErrorMessage()
        {
            SystemSounds.Asterisk.Play();
            MessageBox.Show("You have entered a faulty value, value must be from 0 - 23 hours and 0 - 59 minutes", "ERROR!",
                MessageBoxButtons.OK);
            
        }
        public static int Parser (this string unParsed)
        {
            int x;
            int.TryParse(unParsed, out x);
            return x;
        }
    }
}
