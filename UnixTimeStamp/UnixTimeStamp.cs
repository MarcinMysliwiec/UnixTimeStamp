using System;

public class UnixTimeStamp
{
    public static DateTime ToDateTime(int unixTimeStamp)
    {
        DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
        return dtDateTime.AddSeconds(unixTimeStamp).ToLocalTime();
    }

    public static int FromDateTime(DateTime dateTime)
    {
        DateTime origin = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
        TimeSpan diff = dateTime.ToUniversalTime() - origin;
        return (int)diff.TotalSeconds;
    }
}