using System;
using System.Diagnostics;
using System.Threading;
using Nova.Boot.Ansi;

namespace Template.Common.Boot {

    public class BannerPrinter
    {
        public static void PrintBanner(int sleepMilli = 0) {
            Console.WriteLine($"  {AnsiColor.GREEN}      ██         █████████   ██████████   ███████   {AnsiColor.RED}    █████████       ████████        ████████        ██████████");
            Console.WriteLine($"  {AnsiColor.GREEN}      ██         ██              ██      ██         {AnsiColor.RED}  ██              ██        ██      ██      ██      ██        ");
            Console.WriteLine($"  {AnsiColor.GREEN}      ██         ████████        ██       ██████    {AnsiColor.RED} ██              ██          ██     ██       ██     ████████  ");
            Console.WriteLine($"  {AnsiColor.GREEN}      ██         ██              ██            ██   {AnsiColor.RED}  ██              ██        ██      ██      ██      ██        ");
            Console.WriteLine($"  {AnsiColor.GREEN}      ████████   █████████       ██      ██████     {AnsiColor.RED}    █████████       ████████        ████████        ██████████");

            Console.WriteLine($"{AnsiColor.WHITE}        ███████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████");
            Console.WriteLine($"{AnsiColor.BRIGHT_BLUE}:: Nova.Net 🤓  :: Running ASP.Net Core 'The best version' ::");
            Console.WriteLine($":: http://Nova.github.io ::{AnsiColor.DEFAULT}");
            Thread.Sleep(sleepMilli);
        }
    }
}
