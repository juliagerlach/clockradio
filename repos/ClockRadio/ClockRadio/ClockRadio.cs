using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClockradioProject
{
    public class ClockRadio
    {
        //member variables
        public string timeOfDay;
        public string currentStation;
        public bool alarmStatus;
        public string timeOfAlarm;
        public string newStation;
        public string newAlarmTime;

        //constructor
        public ClockRadio(string timeOfDay, string currentStation, bool alarmStatus)
        {
            this.timeOfDay = "5:00 pm";
            this.currentStation = "88.9 fm";
            this.alarmStatus = true;
            this.timeOfAlarm = "12:00am";
        }


        //member methods
        public void ChecksStatus()
        {
            Console.WriteLine("\nThe current time is 5:00 pm.");
            Console.WriteLine("\nThe alarm is set for 12:00 am.");
            Console.WriteLine("\nThe radio is currently tuned to 88.9 fm.");
            Console.Write("\nPress any key to continue... ");
            Console.ReadLine();
            Console.ReadKey(true);
        }

        public void SetsAlarm()
        {
            Console.WriteLine("\nWhat time would you like the alarm to sound?");
            newAlarmTime = Console.ReadLine();
            Console.WriteLine($"\nThe alarm has been changed to sound at {newAlarmTime}.");
            Console.Write("\nPress any key to continue... ");
            Console.ReadKey(true);
        }
        public bool ChangesStation()
        {
            Console.WriteLine("\nEnter the call numbers of the station you would like to switch to");
            newStation = Console.ReadLine();
            Console.WriteLine($"\nThe station will be changed to {newStation}.");
            Console.Write("\nPress any key to continue... ");
            Console.ReadKey(true);
            return true;
        }
    }
}
