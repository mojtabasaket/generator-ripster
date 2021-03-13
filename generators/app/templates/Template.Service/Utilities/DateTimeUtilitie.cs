using MD.PersianDateTime;
using System;

public static class DateTimeUtilitie
{
    public static DateTime ConvertToDate(PersianDateTime input)
    {
        return input.ToDateTime();
    }
    public static PersianDateTime ConvertToPersainDate(DateTime input)
    {
        return new PersianDateTime(input);
    }
    public static PersianDateTime ConvertToPersainDate(string input)
    {
        return PersianDateTime.Parse(input);
    }

    public static decimal GetDaysOfYear()
    {
        var Now = new PersianDateTime().Date;

        var dif = Now - Now.AddYears(1);

        return decimal.Parse(Math.Abs(dif.TotalDays).ToString());
    }
}
