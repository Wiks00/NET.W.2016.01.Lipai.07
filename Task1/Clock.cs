using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task1
{
    public class Clock
    {
        /// <summary>
        /// 
        /// </summary>
        public event EventHandler<ClockEventArgs> EndTime;

        protected virtual void OnEndTime(object sender, ClockEventArgs e) => EndTime?.Invoke(this, e);

        /// <summary>
        /// Method set time work and send it subscribes.
        /// </summary>
        /// <param name="time">time work</param>
        public void SetTime(int time)
        {
            var waitTime = time * 60000;
            Console.WriteLine($"Your time is {waitTime}");
            Thread.Sleep(waitTime);
            OnEndTime(this, new ClockEventArgs(time));
        }
    }
}
