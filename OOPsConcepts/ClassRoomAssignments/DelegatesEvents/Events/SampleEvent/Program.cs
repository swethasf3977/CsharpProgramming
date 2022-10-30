using System;
namespace  SampleEvent;

class Program 
{
    public static void Main(string[] args)
    {
            Events event1 = new Events("Quiz");
            Events event2 = new Events("Debuging");
            Events event3 = new Events("Presentation");
            Events event4 = new Events("Games");

            //subscribe to events - example event registration by management

                Events.eventlink += new EventManager(event1.StartEvent);
                Events.eventlink += new EventManager(event2.StartEvent);
                Events.eventlink += new EventManager(event3.StartEvent);  
                Events.eventlink += new EventManager(event4.StartEvent); //events assigned with methods

                //process triggering to start events

                Events.HandleEvent();

                //events cancellation /deregistraation - unsubscribe
                Events.eventlink -= new EventManager(event4.StartEvent);
                Events.HandleEvent();
                
        
    }
}