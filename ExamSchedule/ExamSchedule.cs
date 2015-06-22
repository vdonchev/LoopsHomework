using System;

class ExamSchedule
{
    static void Main()
    {
        // inputs
        int hour = int.Parse(Console.ReadLine());
        int min = int.Parse(Console.ReadLine());
        string type = Console.ReadLine();
        int durationHours = int.Parse(Console.ReadLine());
        int durationMin = int.Parse(Console.ReadLine());

        int startHour = hour % 12;
        if (type == "PM")
        {
            startHour += 12;
        }

        DateTime startTime = new DateTime(2015, 06, 22, startHour, min, 0);
        startTime = startTime.AddHours(durationHours).AddMinutes(durationMin);
        Console.WriteLine("{0:hh:mm:tt}", startTime);
    }
}