using System;
public struct Time
{
    private int minutes;

    public int Hour
    {
        get
        {
            return minutes > 0 ? (minutes / 60) % 24 : ((1440 - Math.Abs(minutes) % 1440) / 60) % 24;
        }
        set
        {
            minutes = 60 * value;
        }
    }

    public int Minute
    {
        get
        {
            return minutes > 0 ? minutes % 60 : 60 - Math.Abs(minutes) % 60;
        }
        set
        {
            minutes = value;
        }
    }

    public Time(int hours, int minutes)
    {
        this.minutes = minutes + 60 * hours;
    }

    public override string ToString()
    {
        return $"{String.Format("{0:00}", Hour)}:{String.Format("{0:00}", Minute)}";
    }

    public void AddMinutes(int minutes)
    {
        this.minutes += minutes;
    }

    public void SubtractMinutes(int minutes)
    {
        this.minutes -= minutes;
    }
}