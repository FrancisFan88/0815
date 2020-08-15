using System;

namespace Event
{
    class EventProgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
			
			var person = new Person();
			person.name = "Joe Smith";

			var alarm = new AlarmClock();
			//Step 5 - Associate the event with the handler
			alarm.AlarmClockEvent += person.HandleAlarm;
						
			alarm.Alarm();
		}
    }
	// Step 4 - Creating code that should occur when the event happens
	public class Person
	{
		public string name { get; set; }

		public void HandleAlarm(object sender, AlarmClockEventArgs e)
		{
			Console.WriteLine("Action:Get out of bed! Now it's {0}", e.time);
		}

	}

	// Step 3 - Declaring the code for the event
	public class AlarmClock
	{
		public event AlarmClockEventHandeler AlarmClockEvent;

		public void Alarm()
		{
			Console.WriteLine("Alarm Event is triggered!");
			AlarmClockEventHandeler alarm = AlarmClockEvent;
			if (AlarmClockEvent != null)
			{
				alarm(this, new AlarmClockEventArgs(DateTime.Now));
			}
		}
	}

	// Step 2 - Setting up the delegate for the event
	public delegate void AlarmClockEventHandeler(object source, AlarmClockEventArgs e);

	// Step 1 - Creating a class to pass arguments for the event handlers 	
	public class AlarmClockEventArgs : EventArgs
	{
		public DateTime time { get; set; }
		public AlarmClockEventArgs(DateTime time)
		{
			this.time = time;
		}
	}
}
