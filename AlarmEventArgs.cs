using System;

namespace SyntraWestAdvancedDotNetEventsExercise5
{
    public class AlarmEventArgs : EventArgs
    {
        public int Alarm { get; set; }

        public AlarmEventArgs(int alarm)
        {
            Alarm = alarm;
        }
    }
}
