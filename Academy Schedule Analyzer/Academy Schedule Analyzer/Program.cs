using System.Globalization;

namespace Academy_Schedule_Analyzer
{
    internal class Program
    {

        static void displayAllSessions(string[] names, DateTime[] dates, int[] durations)
        {
            for(int i =0; i < names.Length; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"{i + 1}. {names[i]}");
                Console.WriteLine($"Date: {dates[i].ToString("dd MMMM yyyy")}");
                Console.WriteLine($"Start Time: {dates[i].ToString("HH:mm tt")}");
                Console.WriteLine($"Duration: {durations[i]} minutes");
            }
        }

        static void Main(string[] args)
        {
            string[] sessionNames =
                {
                "C# Basics",
                "Arrays",
                "Functions",
                "Date and Time",
                "Exception Handling"
                };

            DateTime[] sessionDates =
                {
                new DateTime(2026, 9, 10, 18, 0, 0),
                new DateTime(2026, 9, 13, 18, 0, 0),
                new DateTime(2026, 9, 17, 18, 0, 0),
                new DateTime(2026, 9, 20, 18, 0, 0),
                new DateTime(2026, 9, 24, 18, 0, 0)
                };

            int[] sessionDurations =
                {
                180,
                240,
                180,
                240,
                180
                };

            displayAllSessions(sessionNames, sessionDates, sessionDurations);
        }
    }
}
