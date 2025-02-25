namespace Taller1POO;

class Time
{
    private int _hour;
    private int _minute;
    private int _seconds;
    private int _milliseconds;
    public  Time()
    {
       // _hour = 0;
       // _minute = 0;
       // _seconds = 0;
       // _milliseconds = 0;
    }

    public Time (int hour) { _hour = ValidateHour(hour); _minute = 0; _seconds = 0; _milliseconds = 0; }
    public Time(int hour, int minute) { _hour = ValidateHour(hour); _minute = ValidateMinute(minute); _seconds = 0; _milliseconds = 0; }
    public Time(int hour, int minute, int seconds) { _hour = ValidateHour(hour); _minute = ValidateMinute(minute); _seconds = ValidateSeconds(seconds); _milliseconds = 0; }
    public Time(int hour, int minute, int seconds, int milliseconds) { _hour = ValidateHour(hour); _minute = ValidateMinute(minute); _seconds = ValidateSeconds(seconds); _milliseconds = ValidateMilliseconds(milliseconds); }

    public int Hour
    {
        get => _hour;
        set => _hour = value;
    }
    public int Minute { get => _minute; set => _minute = value; }
    public int Seconds { get => _seconds; set => _seconds = value; }
    public int Milliseconds { get => _milliseconds; set => _milliseconds = value; }

    // public override string ToString() => $"{_hour:00}:{_minute:00}:{_seconds:00}.{_milliseconds:000}";

    public override string ToString()
    {
        DateTime time = new DateTime(1, 1, 1, _hour, _minute, _seconds, _milliseconds);
        return time.ToString("hh:mm:ss.fff tt");
    }

    private int ValidateHour(int hour)
    {
        if (hour < 0 || hour > 23)
        {
            throw new ArgumentException($"The hour: {hour}, not is valid.");
        }
        return hour;
    }
    private int ValidateMinute(int minute) { if (minute < 0 || minute > 59) { throw new ArgumentException($"The minute: {minute}, not is valid."); } return minute; }
    private int ValidateSeconds(int seconds) { if (seconds < 0 || seconds > 59) { throw new ArgumentException($"The seconds: {seconds}, not is valid."); } return seconds; }
    private int ValidateMilliseconds(int milliseconds) { if (milliseconds < 0 || milliseconds > 999) { throw new ArgumentException($"The milliseconds: {milliseconds}, not is valid."); } return milliseconds; }

    public int ToMilliseconds()
    {
        return _hour * 3600000 + _minute * 60000 + _seconds * 1000 + _milliseconds;
    }

    public int ToSeconds()
    {
        return _hour * 3600 + _minute * 60 + _seconds;
    }

    public int ToMinutes()
    {
        return _hour * 60 + _minute;
    }

    // Método IsOtherDay
    public bool IsOtherDay(Time other)
    {
        long totalMilliseconds = this.ToMilliseconds() + other.ToMilliseconds();
        return totalMilliseconds >= 86400000; // 86400000 ms = 24 horas
    }

    // Método Add
    public Time Add(Time other)
    {
        long totalMilliseconds = this.ToMilliseconds() + other.ToMilliseconds();
        long hours = (totalMilliseconds / 3600000) % 24;
        long minutes = (totalMilliseconds % 3600000) / 60000;
        long seconds = (totalMilliseconds % 60000) / 1000;
        long milliseconds = totalMilliseconds % 1000;

        return new Time((int)hours, (int)minutes, (int)seconds, (int)milliseconds);
    }



}

}
