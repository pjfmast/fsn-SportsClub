namespace SportsClub.API.Extensions
{
    public static class DateTimeExtensions
    {
        public static DateTime NextDayAt(this DateTime dt, DayOfWeek dayOfWeek, int hour, int minutes)
        {
            int diff = (dayOfWeek >= dt.DayOfWeek) ? (dayOfWeek - dt.DayOfWeek) : (7 + (dayOfWeek - dt.DayOfWeek));
            DateTime day = dt.AddDays(diff).Date;
            DateTime nextDayAt = day.AddHours(hour).AddMinutes(minutes);
            return nextDayAt;
        }

        public static DateTime AtTime(this DateTime dt, int hour, int minutes)
        {
            return new DateTime(dt.Year, dt.Month, dt.Day, hour, minutes, 0, 0);
        }

        public static DateTime StartOfDay(this DateTime theDate)
        {
            return theDate.Date;
        }

        public static DateTime EndOfDay(this DateTime theDate)
        {
            return theDate.Date.AddDays(1).AddTicks(-1);
        }
    }
}
