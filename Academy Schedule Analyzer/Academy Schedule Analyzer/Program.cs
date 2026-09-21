namespace Academy_Schedule_Analyzer
{
    internal class Program
    {
        static int GetLongestDuration(int[] sessionDurations)
        {
            int longestDuration = sessionDurations[0];

            for (int i = 0; i < sessionDurations.Length; i++)
            {
                if (sessionDurations[i] > longestDuration)
                    longestDuration = sessionDurations[i];
            }
            return longestDuration;
        }
        static double GetShortestDuration(int[] sessionDurations)
        {
            double shortestDuration = sessionDurations[0];

            for (int i = 0; i < sessionDurations.Length; i++)
            {
                if (sessionDurations[i] < shortestDuration)
                    shortestDuration = sessionDurations[i];
            }
            return shortestDuration;
        }
        static double GetAverageDuration(int[] sessionDurations , int totalDuration)
        {
            double averageDuration = (double)totalDuration / sessionDurations.Length;

            return averageDuration;
        }
        static int GetTotalDuration(int[] durations)
        {
            int totalDuration = 0;
            foreach (int duration in durations)
            {
                totalDuration += duration;
            }
            return totalDuration;
        }
        static void CopyAnArray(string[] names)
        {
            string[] copyNames = new string[names.Length];
            Array.Copy(names, copyNames, names.Length);

            copyNames[0] = "C++ Basics";

            Console.WriteLine("Copied Array:");
            Console.WriteLine("----------------");
            foreach (string name in copyNames)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine();
            Console.WriteLine("Original Array");
            Console.WriteLine("----------------");
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }
        static string FindIndex(string[] names)
        {
            Console.Write("Enter session name: ");
            string sessionName = Console.ReadLine();
            int index = Array.FindIndex(names, name => name.Equals(sessionName, StringComparison.OrdinalIgnoreCase));
            return index != -1 ? $"Session is found at index :{index}" : "Session not found.";
        }
        static string FindASession(string[] names)
        {
            Console.Write("Enter session name: ");
            string sessionName = Console.ReadLine();

            string found =  Array.Find(names, name => name.Equals(sessionName, StringComparison.OrdinalIgnoreCase));

            return found != null ? $"Session is found :{found}" : "Session not found.";
        }
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

            // CheckIfaSessionExists(sessionNames); 

            // Console.WriteLine(FindASession(sessionNames));

            // Console.WriteLine(FindIndex(sessionNames));

            // CopyAnArray(sessionNames);

            //Console.WriteLine($"Total Duration: {GetTotalDuration(sessionDurations)} minutes");
            //Console.WriteLine($"Average Duration: {GetAverageDuration(sessionDurations , GetTotalDuration(sessionDurations))} minutes");
            //Console.WriteLine($"Shortest Duration: {GetShortestDuration(sessionDurations)} minutes");
            //Console.WriteLine($"Longest Duration: {GetLongestDuration(sessionDurations)} minutes");


        }
    }
}
