using System;

namespace EventScheduler.Properties
{
    public class EventFactory
    {
        public IEvent getEvent(String eventType)
        {
            if (eventType == null)
            {
                return null;
            }

            if (eventType.Equals("HOCKEY"))
            {
                return new HockeyGame();
            }

            if (eventType.Equals("SOCCER"))
            {
                return  new SoccerGame();
            }

            return null;
        }
    }
}