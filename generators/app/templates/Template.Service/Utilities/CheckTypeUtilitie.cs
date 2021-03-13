using System;
using System.Collections.Generic;
using System.Text;


public static class CheckTypeUtilitie
{
    public static bool isNumeric(this string input)
    {
        decimal number;
        return decimal.TryParse(input, out number);
    }


    public static bool isNationalCode(this string input)
    {
        return input.Trim().Length == 10;
    }
    public static bool isNullOrEmpty(this string input)
    {
        return String.IsNullOrEmpty(input);
    }
}
