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
            Console.WriteLine("To come to a stopping point at any time use the 'end' key.");
            Console.WriteLine("");

            var endTimeLoopKey = ConsoleKey.End;
            #region GetDate()
            do
            {
                while (!Console.KeyAvailable)
                {
                    
                    var strVerboseTime = GetVerboseTime();

                    Console.WriteLine(strVerboseTime);
                    //Adds a pause of 5 seconds.
                    Thread.Sleep(5000);
                }
            } while (Console.ReadKey(true).Key != endTimeLoopKey);
            #endregion
        }

        private static string GetVerboseTime()
        {
            var its = "It's ";
            var past = "Past ";
            var oClock = " O'Clock";
            //var strA = "a ";
            var strTo = "to ";
            var minutes = "minutes ";
            var half = "Half ";

            var strOne = "One ";
            var strTwo = "Two ";
            var strThree = "Three ";
            var strFour = "Four ";
            var strFive = "Five ";
            var strSix = "Six ";
            var strSeven = "Seven ";
            var strEight = "Eight ";
            var strNine = "Nine ";
            var strTen = "Ten ";
            //var strEleven = "Eleven ";
            //var strTwelve = "Twelve";
            var strQuarter = "a Quarter ";
            var strTwenty = "Twenty ";

            int currentHour = DateTime.Now.Hour;
            int currentMinutes = DateTime.Now.Minute;

            if (currentMinutes < 30)
            {
                //GetHourNow
                if (currentMinutes == 0 || currentMinutes < 5) return its + GetHour(currentHour) + oClock;
                if (currentMinutes == 5 || currentMinutes < 10) return strFive + past + GetHour(currentHour);
                if (currentMinutes == 10 || currentMinutes < 15) return strTen + past + GetHour(currentHour);
                if (currentMinutes == 15 || currentMinutes < 20) return strQuarter + past + GetHour(currentHour);
                if (currentMinutes == 20 || currentMinutes < 25) return strTwenty + past + GetHour(currentHour);
                if (currentMinutes == 25 || currentMinutes < 30) return strTwenty + strFive + past + GetHour(currentHour);
            }
            if (currentMinutes == 30 || currentMinutes < 35) return half + past + GetHour(currentHour);
            if (currentMinutes > 30)
            {
                if (currentMinutes == 35 || currentMinutes < 40) return its + strTwenty + strFive + minutes + strTo + GetHour(currentHour + 1);
                if (currentMinutes == 40 || currentMinutes < 45) return its + strTwenty + strTo + GetHour(currentHour + 1);
                if (currentMinutes == 45 || currentMinutes < 50) return its + strQuarter + strTo + GetHour(currentHour + 1);
                if (currentMinutes == 50) return strTen + strTo + GetHour(currentHour + 1); //minus 1
                else //Minutes are added to this output now.
                    if (currentMinutes < 60)
                    {
                        if (currentMinutes == 51) return strNine + minutes + strTo + GetHour(currentHour + 1);
                        if (currentMinutes == 52) return strEight + minutes + strTo + GetHour(currentHour + 1);
                        if (currentMinutes == 53) return strSeven + minutes + strTo + GetHour(currentHour + 1);
                        if (currentMinutes == 54) return strSix + minutes + strTo + GetHour(currentHour + 1);
                        if (currentMinutes == 55) return strFive + minutes + strTo + GetHour(currentHour + 1);
                        if (currentMinutes == 56) return strFour + minutes + strTo + GetHour(currentHour + 1);
                        if (currentMinutes == 57) return strThree + minutes + strTo + GetHour(currentHour + 1);
                        if (currentMinutes == 58) return strTwo + minutes + strTo + GetHour(currentHour + 1);
                        if (currentMinutes == 59) return strOne + "minute " + "until " + GetHour(currentHour + 1);
                    }
                    else
                    {//If for some reason this all fails just 
                        throw new NotImplementedException();
                    } 
            }
            return string.Empty;
        }

        private static string GetHour(int currentHour)
        {
            string strHour = string.Empty;

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
                    return strHour = "One";
                case 2:
                    return strHour = "Two";
                case 3:
                    return strHour = "Three";
                case 4:
                    return strHour = "Four";
                case 5:
                    return strHour = "Five";
                case 6:
                    return strHour = "Six";
                case 7:
                    return strHour = "Seven";
                case 8:
                    return strHour = "Eight";
                case 9:
                    return strHour = "Nine";
                case 10:
                    return strHour = "Ten";
                case 11:
                    return strHour = "Eleven";
                case 12:
                    return strHour = "Twelve";
                default:
                    return strHour = ".twelve";
            }
        }

        private static void SetProjectTitle(string strProjectTitle)
        {
            Console.WriteLine("Project Title: " + strProjectTitle);
            Console.WriteLine("Press ESC to stop");
        }
    }
}
