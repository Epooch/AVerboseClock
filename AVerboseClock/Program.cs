using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AVerboseClock
{
    class Program
    {
        //This is going to be FUN.
        ////Inspired by this thing I found on imgur http://imgur.com/gallery/7E2ww
        static void Main(string[] args)
        {
            string strProjectTitle = "aVerboseClock";
            SetProjectTitle(strProjectTitle);

            var endTimeLoopKey = ConsoleKey.End;
            #region GetDate()
            do
            {
                while (!Console.KeyAvailable)
                {
                    var strHour = string.Empty;
                    strHour = GetHour();

                    var strMinutes = string.Empty;
                    strMinutes = GetMinutes();

                    Console.WriteLine(strMinutes + strHour);
                    Console.WriteLine("To come to a stopping point at any time use the 'end' key.");
                    //Adds a pause of 5 seconds.
                    Thread.Sleep(5000);
                }
            } while (Console.ReadKey(true).Key != endTimeLoopKey);
            #endregion
        }

        private static string GetMinutes()
        {
            var strMinutes = string.Empty;
            int currentMinutes = DateTime.Now.Minute;
            Console.WriteLine(currentMinutes);
            if (currentMinutes == 0 || currentMinutes < 5) return "o'clock";
            if (currentMinutes < 30)
            {
                if (currentMinutes == 5 || currentMinutes < 10) return "Five.Past";
                if (currentMinutes == 10 || currentMinutes < 15) return "Ten.Past";
                if (currentMinutes == 15 || currentMinutes < 20) return "Quarter.Past";
                if (currentMinutes == 20 || currentMinutes < 25) return "Twenty.Past";
                if (currentMinutes == 25 || currentMinutes < 30) return "Twenty.Five.Past";
            }
            if (currentMinutes == 30 || currentMinutes < 35) return "half.Past";
            if (currentMinutes > 30)
            {
                if (currentMinutes == 35 || currentMinutes < 40) return "Twenty.Five.To";
                if (currentMinutes == 40 || currentMinutes < 45) return "Twenty.To";
                if (currentMinutes == 45 || currentMinutes < 50) return "Quarter.To";
                if (currentMinutes == 50) return "Ten.To";
                else //Minutes are added to this output now.
                    if (currentMinutes < 60)
                    {
                        if (currentMinutes == 51) return "Nine.Minutes.To";
                        if (currentMinutes == 52) return "Eight.Minutes.To";
                        if (currentMinutes == 53) return "Seven.Minutes.To";
                        if (currentMinutes == 54) return "Six.Minutes.To";
                        if (currentMinutes == 55) return "Five.Minutes.To";
                        if (currentMinutes == 56) return "Four.Minutes.To";
                        if (currentMinutes == 57) return "Three.Minutes.To";
                        if (currentMinutes == 58) return "Two.Minutes.To";
                        if (currentMinutes == 59) return "One.Minute.Until";
                    }
                    else
                    {//If for some reason this all fails just 
                        throw new NotImplementedException();
                    } 
            }
            return strMinutes;
        }

        private static string GetHour()
        {
            int currentHour;
            string strHour = string.Empty;
            currentHour = DateTime.Now.Hour;
            Console.WriteLine(currentHour);

            if (currentHour > 12)
            {
                currentHour = currentHour - 12;
            }
            else if (currentHour == 0)
            {
                currentHour = 12;
            }

            switch (currentHour)
            {
                case 1:
                    strHour = ".one";
                    break;
                case 2:
                    strHour = ".two";
                    break;
                case 3:
                    strHour = ".three";
                    break;
                case 4:
                    strHour = ".four";
                    break;
                case 5:
                    strHour = ".five";
                    break;
                case 6:
                    strHour = ".six";
                    break;
                case 7:
                    strHour = ".seven";
                    break;
                case 8:
                    strHour = ".eight";
                    break;
                case 9:
                    strHour = ".nine";
                    break;
                case 10:
                    strHour = ".ten";
                    break;
                case 11:
                    strHour = ".eleven";
                    break;
                case 12:
                    strHour = ".twelve";
                    break;
                default:
                    strHour = ".twelve";
                    break;
            }
            return strHour;
        }

        private static void SetProjectTitle(string strProjectTitle)
        {
            Console.WriteLine("Project Title: " + strProjectTitle);
            Console.WriteLine("Press ESC to stop");
        }
    }
}
