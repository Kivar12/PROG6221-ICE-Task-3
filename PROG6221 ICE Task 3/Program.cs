using System;

namespace PROG6221_ICE_Task_3

{

    public delegate void AlarmHandler();

    public class Alarm
    {
        public event AlarmHandler OnAlarmTriggered;

        public void TriggerAlarm()
        {
            Console.WriteLine("Alarm is triggered!");

            OnAlarmTriggered?.Invoke();
        }
    }

    class Program
    {
        public static void RespondToAlarm()
        {
            Console.WriteLine("Warning! Take action immediately!");
        }

        static void Main(string[] args)
        {

            Alarm alarm = new Alarm();

            alarm.OnAlarmTriggered += RespondToAlarm;

            alarm.TriggerAlarm();
        }
    }
}