using System;

namespace Chap12Part4
{

    class Time
    {
        private int hour, minute, second;

        public Time(int h, int m, int s)
        {
            hour = validateHour(h);
            minute = m;
            second = s;
        }

        public Time()
        {
            hour = 0;
            minute = 0;
            second = 0;
        }

        public int Hour
        {
            get
            {
                return hour;
            }
            set
            {
                hour = value;
            }
        }

        public int Minute
        {
            get
            {
                return minute;
            }
            set
            {
                minute = value;
            }
        }

        public int Second
        {
            get
            {
                return second;
            }
            set
            {
                second = value;
            }
        }

        public void setTime(int h, int m, int s)
        {
            hour = h;
            minute = m;
            second = s;
        }

        override
        public String ToString()
        {
            //return hour + ":" + minute + ":" + second;
            return formatTime();
        }

        private String formatTime()
        {
            String hours, minutes, seconds;
            if (hour < 10)
                hours = "0" + hour.ToString();
            else
                hours = hour + "";
            if (minute < 10)
                minutes = "0" + minute.ToString();
            else
                minutes = minute + "";
            if (second < 10)
                seconds = "0" + second.ToString();
            else
                seconds = second + "";
            return hours + ":" + minutes + ":" + seconds;
        }

        private int validateHour(int hour)
        {
            if (hour >= 0 && hour <= 23)
                return hour;
            else
                return 0;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Time theTime = new Time(-8, 25, 30);
            Console.WriteLine(theTime.ToString());
            Console.ReadKey();
        }
    }
}
