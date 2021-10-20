using System;

namespace UnixTimeStamp
{
    public static class Converter
    {
        public static DateTime ToDateTime(int unixTimeStamp)
        {
            var dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
            return dtDateTime.AddSeconds(unixTimeStamp).ToLocalTime();
        }

        public static int FromDateTime(DateTime dateTime)
        {
            var dtSeconds = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            return (int)(dateTime.ToUniversalTime() - dtSeconds).TotalSeconds;
        }
    }
}