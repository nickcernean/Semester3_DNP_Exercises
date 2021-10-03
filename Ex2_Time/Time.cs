using System;

namespace Ex2_Time
{
    public struct Time
    {
        private int minutes;

        public int Hour
        {
            get { return minutes / 60; }
            set { minutes = 60 * value; }
        }

        public int Minute
        {
            get { return minutes % 60; }
            set { minutes = value; }
        }

        public Time(int hours, int minutes)
        {
            this.minutes = minutes + 60 * hours;
        }

        public override string ToString()
        {
            return $"{String.Format("{0:00}", Hour)}:{String.Format("{0:00}", Minute)}";
        }
    }
}