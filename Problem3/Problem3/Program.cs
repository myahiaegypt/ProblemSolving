using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            String strDimension;
            String lineTime;
            int intdimension = 5;
            int[,] intmatrix = new int[intdimension, intdimension];
            int hours=0,minutes=0,seconds=0;
            String LastTimePart;
            String daynight="AM";
            String strhour="", strminute="", strsecond="";
            bool valid = false;
            while (valid == false)
            {
                Console.WriteLine("Please enter a time in 12 hour format hh:mm:ssAM or x to exit: ");
                lineTime = Console.ReadLine();
                if (lineTime == "x")
                {
                    Environment.Exit(0);
                }
                try
                {
                    string[] TimeList = lineTime.Split(':');
                    hours = Convert.ToInt32(TimeList[0]);
                    minutes = Convert.ToInt32(TimeList[1]);
                    LastTimePart = TimeList[2];
                    //seconds = Convert.ToInt32(TimeList[2]);
                    daynight = TimeList[2].Substring(LastTimePart.Length - 2);
                    seconds = Convert.ToInt32(TimeList[2].Substring(0, LastTimePart.Length - 2));
                    if (12 < hours || hours < 1 || minutes < 0 || minutes > 59 || seconds < 0 || seconds > 59 || (daynight.ToUpper() != "PM" && daynight.ToUpper() != "AM"))
                    {
                        Console.WriteLine("Please type a valid time format");
                    }
                    else
                    {
                        valid = true;
                        break;
                    }
                }
                catch(Exception e)
                {
                    Console.WriteLine("Please type a valid time format");
                }
            }
            if (daynight == "AM" )
            {
                if (hours == 12)
                {
                    strhour = "00";
                }
                else
                {
                    strhour = hours.ToString();
                }
            }
            else
            {
                hours = hours + 12;
                strhour = hours.ToString();
            }
            if (hours<10)
            {
                strhour = "0" + hours.ToString();
            }
            else
            {
                strhour = hours.ToString();
            }
            if (minutes < 10)
            {
                strminute = "0" + minutes.ToString();
            }
            else
            {
                strminute = minutes.ToString();
            }
            if (seconds < 10)
            {
                strsecond = "0" + seconds.ToString();
            }
            else
            {
                strsecond = seconds.ToString();
            }
            Console.WriteLine("24 hour format : " + strhour + ":" + strminute + ":" + strsecond);
            strDimension = Console.ReadLine();


        }
    }
}
