using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClockradioProject
{
    class Program
    {
        static void Main(string[] args)
        {
            ClockRadio myClockRadio = new ClockRadio("5:00pm", "88.9", true);

            myClockRadio.ChecksStatus();

            myClockRadio.SetsAlarm();
            Console.WriteLine(myClockRadio.newAlarmTime);

            myClockRadio.ChangesStation();
            Console.WriteLine(myClockRadio.newStation);
        }
    }
}
