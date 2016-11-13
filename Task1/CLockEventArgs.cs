using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public sealed class ClockEventArgs : EventArgs
    {
        private int time;

        /// <summary>
        /// Wait time property
        /// </summary>
        public int Time
        {
            private set
            {
                if (time < 0)
                    throw new ArgumentOutOfRangeException();
                time = value;
            }
            get { return time; }
        }

        /// <summary>
        /// Set wait time
        /// </summary>
        /// <param name="time">wait time</param>
        public ClockEventArgs(int time)
        {
            Time = time;
        }
    }
}
