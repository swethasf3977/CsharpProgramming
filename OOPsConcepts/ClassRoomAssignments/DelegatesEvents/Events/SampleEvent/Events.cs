namespace SampleEvent
{
    public delegate void EventManager();  //user defined delegate
    public class Events
    {
        private string _eventName;
        public static event EventManager eventlink; //user defined event
        static int i;
        public Events(string eventName)
        {
            _eventName = eventName;
        }
        public static void HandleEvent() //event triggering method
        {
            i=0;
            System.Console.WriteLine("user Registration ");
            System.Console.WriteLine("Starting the following events ");
            eventlink();  //event trigger -> like cliking a buton
        }
        public void StartEvent() //Explaination about the button click action
        {
            ++i;
            System.Console.WriteLine("Event no "+i+" is "+_eventName+" Started");

        }
        
    }
}