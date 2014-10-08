using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_2_digital_vackarklocka
{
    public class AlarmClock
    {
        private int _alarmHour;
        private int _alarmMinute;
        private int _hour;
        private int _minute;

        
        public int Alarmhour
        {
            get { return _alarmHour; }

            set
            {
                if (value < 0 || value > 23)
                {
                    throw new ArgumentException("Alarmtimmen är inte i intervallet 0-23");
                }
                _alarmHour = value;
            }
        
        }

        public int AlarmMinute
        {
            get { return _alarmMinute; }

            set
            {
                if (value < 0 || value > 59)
                {
                    throw new ArgumentException("Alarmminuten är inte i intervallet 0-59");
                }
                _alarmMinute = value;
            }
        }

        public int Hour
        {
            get { return _hour; } 
            
            set
            {
                if (value < 0 || value > 23)
                {
                    throw new ArgumentException("Timmen är inte i intervallet 0-23");
                }
                _hour = value;
            }
        
        }

        public int Minute
        {
            get { return _minute; }

            set
            {
                if (value < 0 || value > 59)
                {
                    throw new ArgumentException("Minuten är inte i intervallet 0-59");
                }
                _minute = value;
            }
        
        
        
        }

        public AlarmClock()
            :this (0, 0)
        {

        }

        public AlarmClock(int hour, int minute)
            :this (hour, minute, 0, 0)
        {
            //Hour = hour;
            //Minute = minute;
        }

        public AlarmClock(int hour, int minute, int alarmHour, int alarmMinute)
        {
            Hour = hour;
            Minute = minute;
            Alarmhour = alarmHour;
            AlarmMinute = alarmMinute;
        }

        public bool TickTock()
        {


            if (Minute == 59 && Hour == 23)
            {
                Minute = 0;
                Hour = 0;
            }

            if (Minute == 59)
            {
                Minute = 0;
                Hour++;
            }

            Minute++;

                

            if (Minute == AlarmMinute && Hour == Alarmhour)
            {
                return true;
            }
            else
            {
                return false;
            }

              


            //return false;
        }

        public override string ToString()
        {
           /* if (Hour > 9 && Alarmhour > 9)
            {
                return String.Format("      {0:D2}:{1:D2}  <{2:D2}:{3:D2}>",
                Hour, Minute, Alarmhour, AlarmMinute);
            }
            else
            {*/
                return String.Format("      {0,2}:{1:D2}  <{2,2}:{3:D2}>",
                Hour, Minute, Alarmhour, AlarmMinute);
            //}

            //return String.Format("{0}:{1}  <{2}:{3}>",
            //    Hour, Minute, Alarmhour, AlarmMinute);
        }
    }
}
