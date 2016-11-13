using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.ConsoleTests
{
    class Neighbor
    {
        /// <summary>
        /// Method that start drilling after the end-time
        /// </summary>
        private void Drill(object sender, ClockEventArgs clock) =>
            Console.WriteLine($"Brrr! It's about {clock.Time} minutes while your alarm clock is ringing . Now is the drilling time !!!");

        /// <summary>
        /// The method that subscribes to the event notification
        /// </summary>
        public void SubscribeToInfo(Clock clock) => clock.EndTime += Drill;

        /// <summary>
        /// The method that unsubscribes to the event notification
        /// </summary>
        public void UnSubscribeToInfo(Clock clock) => clock.EndTime -= Drill;
    }
}
