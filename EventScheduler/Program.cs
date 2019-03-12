using System;
using EventScheduler.Properties;

namespace EventScheduler
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            DateTime currentDate = DateTime.Now;
            EventFactory eventFactory = new EventFactory();
            IEvent firstEvent = eventFactory.getEvent("HOCKEY");
            
            firstEvent.setTeams("Knoxville", "Nashville");
            firstEvent.schedule(currentDate);

            IEvent secondEvent = eventFactory.getEvent("SOCCER");
            
            secondEvent.setTeams("Chicago", "New York");
            secondEvent.schedule(currentDate.AddDays(3));
        }

    }
}