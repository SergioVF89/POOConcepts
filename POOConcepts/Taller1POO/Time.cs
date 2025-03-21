﻿namespace Taller1POO;

class Time
{
    private int _hour;
    private int _minute;
    private int _second;
    private int _millisecond;
    public  Time() {}

    public Time (int hour) { _hour = ValidateHour(hour); _minute = 0; _second = 0; _millisecond = 0; }
    public Time(int hour, int minute) { _hour = ValidateHour(hour); _minute = ValidateMinute(minute); _second = 0; _millisecond = 0; }
    public Time(int hour, int minute, int seconds) { _hour = ValidateHour(hour); _minute = ValidateMinute(minute); _second = ValidateSeconds(seconds); _millisecond = 0; }
    public Time(int hour, int minute, int seconds, int milliseconds) { _hour = ValidateHour(hour); _minute = ValidateMinute(minute); _second = ValidateSeconds(seconds); _millisecond = ValidateMilliseconds(milliseconds); }

    public int Hour
    {
        get => _hour;
        set => _hour = value;
    }
    public int Minute { get => _minute; set => _minute = value; }
    public int Second { get => _second; set => _second = value; }
    public int Millisecond { get => _millisecond; set => _millisecond = value; }

    // public override string ToString() => $"{_hour:00}:{_minute:00}:{_seconds:00}.{_milliseconds:000}";

    public override string ToString()
    {
        DateTime time = new DateTime(1, 1, 1, _hour, _minute, _second, _millisecond);
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
        return _hour * 3600000 + _minute * 60000 + _second * 1000 + _millisecond;
    }

    public int ToSeconds()
    {
        return _hour * 3600 + _minute * 60 + _second;
    }

    public int ToMinutes()
    {
        return _hour * 60 + _minute;
    }

    // Método IsOtherDay
    public bool IsOtherDay(Time other)
    {
        int totalMilliseconds = this.ToMilliseconds() + other.ToMilliseconds();
        return totalMilliseconds >= 86400000; // 86400000 ms = 24 horas
    }

    // Método Add
    public Time Add(Time other)
    {
        int totalMilliseconds = this.ToMilliseconds() + other.ToMilliseconds();
        int hours = (totalMilliseconds / 3600000) % 24;
        int minutes = (totalMilliseconds % 3600000) / 60000;
        int seconds = (totalMilliseconds % 60000) / 1000;
        int milliseconds = totalMilliseconds % 1000;

        return new Time(hours, minutes, seconds, milliseconds);
    }

}