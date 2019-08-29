using System;
using System.Collections.Generic;
using System.Text;

namespace StopWatchs
{
    class StopWatch
    {
        private DateTime startTime;
        private DateTime endTime;

    public StopWatch() {
            startTime = DateTime.Now;
        }
     public DateTime Start() {
            return startTime = DateTime.Now;
        }   
     public DateTime Stop( )
        {
          return endTime = DateTime.Now;
        }
        public DateTime getStartTime()
        {
            return startTime;
        }
        public DateTime getEndTime()
        {
            return endTime;
        }
        public int getElapsedTime()
        {
            return endTime.Millisecond - startTime.Millisecond;
        }
    }
    
}   
