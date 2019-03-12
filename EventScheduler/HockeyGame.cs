using System;

namespace EventScheduler.Properties
{
    public class HockeyGame : IEvent
    {
        public void setTeams(string home, string visitor)
        {
            Console.WriteLine(home + " vs. " + visitor);
        }

        public void schedule(DateTime dateTime)
        {
            Console.WriteLine("Scheduled a hockey game on " + dateTime);
        }
    }
}