using System;
using System.Globalization;

namespace Sino_The_Walker
{
    class Program
    {
        static void Main(string[] args)
        {
            var leavingTime = DateTime.ParseExact(Console.ReadLine(), "HH:mm:ss", CultureInfo.InvariantCulture);
            var steps = int.Parse(Console.ReadLine()) % 86400;
            var secondsForStep = int.Parse(Console.ReadLine()) % 86400;

            var totalSeconds = steps * secondsForStep;

            TimeSpan time = TimeSpan.FromSeconds(totalSeconds);

            leavingTime = leavingTime.AddHours(time.Hours);
            leavingTime = leavingTime.AddMinutes(time.Minutes);
            leavingTime = leavingTime.AddSeconds(time.Seconds);

            Console.WriteLine($"Time Arrival: {leavingTime.Hour:d2}:{leavingTime.Minute:d2}:{leavingTime.Second:d2}");
        }
    }
}
