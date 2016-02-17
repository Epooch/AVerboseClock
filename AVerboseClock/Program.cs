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
            int currentHour;
            do
            {
                while (!Console.KeyAvailable)
                {
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

                    var strHour = string.Empty;
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

                    Console.WriteLine(strHour);


                    Console.WriteLine("To come to a stopping point at any time use the 'end' key.");
                    //Adds a pause of 5 seconds.
                    Thread.Sleep(5000);
                }
            } while (Console.ReadKey(true).Key != endTimeLoopKey);
            #endregion
        }

        private static void SetProjectTitle(string strProjectTitle)
        {
            Console.WriteLine("Project Title: " + strProjectTitle);
            Console.WriteLine("Press ESC to stop");
        }
    }
}
