using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.ConsoleTests
{
    class Program
    {
        static void Main(string[] args)
        {
            var clock = new Clock();
            var neighbor1 = new Neighbor();
            var neighbor2 = new Neighbor();
            var alarmclock1 = new Alarmclock();
            var alarmclock2 = new Alarmclock();
            var alarmclock3 = new Alarmclock();
            neighbor1.SubscribeToInfo(clock);
            neighbor2.SubscribeToInfo(clock);
            alarmclock1.SubscribeToInfo(clock);
            alarmclock2.SubscribeToInfo(clock);
            alarmclock3.SubscribeToInfo(clock);
            clock.SetTime(0);
            alarmclock2.UnSubscribeToInfo(clock);
            clock.SetTime(1);
            Console.ReadKey();
        }
    }
}
