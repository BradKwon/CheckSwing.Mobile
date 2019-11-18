using System;
using CheckSwing.Models;

namespace CheckSwing.ViewModels
{
    public class EventDetailViewModel : BaseDetailViewModel<Event, Event>
    {
        public EventDetailViewModel(Event pEvent)
        {
            Title = pEvent?.Title;
            Item = pEvent;
        }
    }
}
