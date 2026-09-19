
using static System.Collections.Specialized.BitVector32;

namespace Academy_Schedule_Analyzer
{
    internal class Program
    {
        static void sortSessionNames(string[] names)
        {
            string[] copyNames = new string[names.Length];
            Array.Copy(names, copyNames, names.Length);
            Array.Sort(copyNames);

            foreach (string name in copyNames)
            {
                Console.WriteLine(name);
            }
        }
        static void searchforaSession(string[] names, DateTime[] dates, int[] durations)
        {
            Console.WriteLine();
            Console.WriteLine("Enter the name of the session to search for:");
            string searchName = Console.ReadLine();

            for (int i = 0; i < names.Length; i++)
            {
                if (string.Equals(names[i], searchName, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("-------------------------");
                    Console.WriteLine($"Session Name: {names[i]}");
                    Console.WriteLine($"Date: {dates[i].ToString("dd MMMM yyyy")}");
                    Console.WriteLine($"Start Time: {dates[i].ToString("HH:mm tt")}");
                    Console.WriteLine($"Duration: {durations[i]} minutes");
                    Console.WriteLine("-------------------------");
                    return;
                }
            }
            Console.WriteLine("Session not found.");
        }
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

          //  displayAllSessions(sessionNames, sessionDates, sessionDurations);

         //   searchforaSession(sessionNames, sessionDates, sessionDurations);

            sortSessionNames(sessionNames);
        }
    }
}
