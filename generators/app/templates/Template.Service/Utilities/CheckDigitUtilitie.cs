using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Template.Services.Utilities
{
    public static class CheckDigitUtilitie
    {
        public static string MakeDigit(string number)
        {
            number = number.Substring(number.Length - 9, 9);
            var Numbers = number.ToString().ToCharArray(0, number.ToString().Length);
            int i = 2;
            int Result = 0;
            Numbers.Reverse().ToList().ForEach(c =>
            {
                Result += (int.Parse(c.ToString()) * i++);
            });
            Result = (Result % 11);
            Result = (11 - Result);
            return Result.ToString();
        }

        public static bool VarifyDigit(string number)
        {
            number = number.Substring(number.Length - 10, 10);
            var Numbers = number.ToString().ToCharArray(0, number.ToString().Length);
            int i = 1;
            int Result = 0;
            Numbers.Reverse().ToList().ForEach(c =>
            {
                Result += (int.Parse(c.ToString()) * i++);
            });
            Result = (Result % 11);
            if (Result == 0) return true;
            else return false;
            //    return Result.ToString();
        }
    }
}
