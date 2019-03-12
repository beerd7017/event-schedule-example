using System;

namespace EventScheduler.Properties
{
    public interface IEvent
    {
        void setTeams(string home, string visitor);
        void schedule(DateTime dateTime);
    }
}