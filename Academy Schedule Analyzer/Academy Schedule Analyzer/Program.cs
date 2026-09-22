using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Academy_Schedule_Analyzer
{
    internal class Program
    {
        static void DateDifference(string[] names , DateTime[] dates)
        {
            Console.Write("Enter the first session name:");
            string firstSessionName = Console.ReadLine();
            int index = Array.FindIndex(names, name => name.Equals(firstSessionName, StringComparison.OrdinalIgnoreCase));

            Console.Write("Enter the Second session name:");
            string secondSessionName = Console.ReadLine();
            int index2 = Array.FindIndex(names, name => name.Equals(secondSessionName, StringComparison.OrdinalIgnoreCase));

            if (index != -1 && index2 != -1)
            {
                Console.WriteLine("--------------------");
                TimeSpan difference = dates[index2] - dates[index];
                Console.WriteLine("Difference:");
                Console.WriteLine($"{difference.Days} days");
                Console.WriteLine($"{difference.TotalHours} Hours");
            }
            else
            {
                Console.WriteLine("One or both session names not found.");
            }
        }
        static void SessionDateDetails(string[] names, DateTime[] dates, int[] durations)
        {
            Console.Write("Enter the session name:");
            string sessionName = Console.ReadLine();
            Console.WriteLine( "----------------------------");
            int index = Array.FindIndex(names, name => name.Equals(sessionName, StringComparison.OrdinalIgnoreCase));

            Console.WriteLine($"Session Date: {dates[index].ToString("dd MMMM yyyy")}");
            Console.WriteLine($"Day :{dates[index].DayOfWeek}");
            Console.WriteLine($"Year :{dates[index].Year}");
            Console.WriteLine($"Month :{dates[index].Month}");
            Console.WriteLine($"Day :{dates[index].Day}");
            Console.WriteLine($"Start Time :{dates[index].ToString("hh:mm tt")}");
            Console.WriteLine($"Duration :{durations[index]} minutes");
            Console.WriteLine($"End Time : {dates[index].AddMinutes(durations[index]).ToString("hh:mm tt")}");
        }
        static void CalculateTotalDuration(params int[] sessionDurations)
        {
            int totalDuration = 0;

            foreach (int duration in sessionDurations)
            {
                totalDuration += duration;
            }

            Console.WriteLine($"Total duration: {totalDuration}");
        }
        static void ReferenceTypeWithiutRef(int[] sessionDurations)
        {
            sessionDurations[0] = 100;
        }
        static void SearchForIndexAndDuration(string[] sessionNames, int[] sessionDurations , out int index, out int duration)
        {
            Console.Write("Enter the session name:");
            string sessionName = Console.ReadLine();
            index = Array.FindIndex(sessionNames, name => name.Equals(sessionName, StringComparison.OrdinalIgnoreCase));
            duration = index != -1 ? sessionDurations[index] : 0;

            Console.WriteLine($"Index: {index}, Duration: {duration}");

        }   
        static void ChangeRefValue(ref int x)
        {
            x = 10;
        }
        static void SortSessionDurations(int[] sessionDurations)
        {
            int[] CopySessionDurations = new int[sessionDurations.Length];
            Array.Copy(sessionDurations, CopySessionDurations, sessionDurations.Length);
            Array.Sort(CopySessionDurations);

            Console.WriteLine("Sorted Session Durations:");
            Console.WriteLine("-------------------------");
            foreach (var session in CopySessionDurations)
            {
                Console.WriteLine(session);
            }
        }
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

            //  SortSessionDurations(sessionDurations);

            //Part 7
            //int x = 5;
            //Console.WriteLine($"Before calling the function: {x}");

            //ChangeRefValue(ref x);

            //Console.WriteLine($"After calling the function: {x}");

            //SearchForIndexAndDuration(sessionNames, sessionDurations , out int index , out int duration);

            // Part 7.3
            //Console.WriteLine("Array before modification:");
            //foreach (int duration in sessionDurations)
            //{
            //    Console.WriteLine(duration);
            //}
            //ReferenceTypeWithiutRef(sessionDurations);

            //Console.WriteLine("Array after modification:");
            //foreach (int duration in sessionDurations)
            //{
            //    Console.WriteLine(duration);
            //}

            // Part 8 
            // CalculateTotalDuration(60, 90, 120, 180, 240);

            //Part 9
            //SessionDateDetails(sessionNames, sessionDates, sessionDurations);

            //Part 10
            DateDifference(sessionNames, sessionDates);
        }
    }
}
