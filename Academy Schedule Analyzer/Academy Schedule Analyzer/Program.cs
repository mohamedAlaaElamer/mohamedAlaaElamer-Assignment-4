

namespace Academy_Schedule_Analyzer
{
    internal class Program
    {
        static void CheckIfaSessionExists(string[] names)
        {
            Console.Write("Enter session name: ");
            string sessionName = Console.ReadLine();

            bool exists = Array.Exists(names, name => name.Equals(sessionName, StringComparison.OrdinalIgnoreCase));
            Console.WriteLine(exists ? "Session exists." : "Session does not exist.");
        }
        static void FindSessionIndex(string[] names)
        {
            Console.Write("Enter session name: ");
            string sessionName = Console.ReadLine();

            int index = Array.IndexOf(names,sessionName);

            if (index == -1)
            {
                Console.WriteLine("Session not found.");
            }
            else
            {
                Console.WriteLine($"index: {index}");
            }
        }
        static void ReverseSessionNames(string[] names)
        {
            string[] copyNames = new string[names.Length];
            Array.Copy(names, copyNames, names.Length);
            Array.Reverse(copyNames);
            foreach (string name in copyNames)
            {
                Console.WriteLine(name);
            }
        }
        static void SortSessionNames(string[] names)
        {
            string[] copyNames = new string[names.Length];
            Array.Copy(names, copyNames, names.Length);
            Array.Sort(copyNames);

            foreach (string name in copyNames)
            {
                Console.WriteLine(name);
            }
        }
        static void SearchforaSession(string[] names, DateTime[] dates, int[] durations)
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
        static void DisplayAllSessions(string[] names, DateTime[] dates, int[] durations)
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

            //   DisplayAllSessions(sessionNames, sessionDates, sessionDurations);

            //  SearchforaSession(sessionNames, sessionDates, sessionDurations);

            //  SortSessionNames(sessionNames);

            // ReverseSessionNames(sessionNames);

            //  FindSessionIndex(sessionNames);

            CheckIfaSessionExists(sessionNames); 
        }
    }
}
