using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.ConsoleTests
{
    class Alarmclock
    {
        /// <summary>
        /// Method that alert the end-time
        /// </summary>
        private void Ring(object sender, ClockEventArgs clock) =>
            Console.WriteLine($"Ring-Ring! Time to wake up! You sleep already {clock.Time} minutes.");

        /// <summary>
        /// The method that subscribes to the event notification
        /// </summary>
        public void SubscribeToInfo(Clock clock) => clock.EndTime += Ring;

        /// <summary>
        /// The method that unsubscribes to the event notification
        /// </summary>
        public void UnSubscribeToInfo(Clock clock) => clock.EndTime -= Ring;
    }
}
