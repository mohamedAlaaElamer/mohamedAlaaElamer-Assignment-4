using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System.Text;

namespace Academy_Schedule_Analyzer
{
    internal class Program
    {
        static void BuildtheSameReportUsingStringBuilder(string[] names, DateTime[] dates, int[] durations)
        {
            StringBuilder reportBuilder = new StringBuilder();

            for (int i = 0; i < names.Length; i++)
            {
                reportBuilder.Append(names[i]);
                reportBuilder.Append(" - ");
                reportBuilder.Append(dates[i].ToString("dd/MM//yyyy"));
                reportBuilder.Append(" - ");
                reportBuilder.Append(durations[i].ToString());
                reportBuilder.Append(" minutes");
                Console.WriteLine(reportBuilder.ToString());
                reportBuilder.Clear();
            }
        }
        static void BuildAScheduleReportUsingString(string[] names, DateTime[] dates, int[] durations)
        {
            string result = "";

            for (int i = 0; i < names.Length; i++)
            {
                result += names[i];
                result += " - ";
                result += dates[i].ToString("dd/MM//yyyy");
                result += " - ";
                result += durations[i].ToString();
                result += " minutes";
                Console.WriteLine(result);
                result = "";
            }
        }
        static void ValidatesASessionDuration(int[] sessionDurations)
        {
            Console.Write("Enter session duration: ");
            int.TryParse(Console.ReadLine(), out int sessionDuration);

            for (int i = 0; i < sessionDurations.Length; i++)
            {
                if (sessionDurations[i] == sessionDuration)
                {
                    Console.WriteLine($"Session duration {sessionDuration} is valid.");
                    return;
                }
                else
                {
                    throw new ArgumentException("Duration must be greater than zero");
                }
            }
        }
        static void ExceptionHandlingInvalidArrayIndex(string[] sessionNames)
        {
            Console.Write("Enter seesion index: ");
            int.TryParse(Console.ReadLine(), out int index);

            try
            {
                Console.WriteLine($"Session name at index {index} is: {sessionNames[index]}");
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("The selected session index is out of range.\r\n");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Input operation finished.\r\n");
            }



        }
        static void MenuInput()
        {
            try
            {
                Console.Write("Choose an option: ");
                int option = int.Parse(Console.ReadLine());

                while (option == null)
                {
                    Console.WriteLine("Invalid input. Please enter a valid option.");
                    Console.Write("Choose an option: ");
                    option = int.Parse(Console.ReadLine());
                }
            }
            catch (FormatException)
            {

                throw new FormatException("Invalid menu option. Enter a number.\r\n");
            }



        }
        static string ReadandValidateADate(DateTime[] sessionDates)
        {
            Console.Write("Enter a date (yyyy-MM-dd HH:mm):");
            string input = Console.ReadLine();

            while (!DateTime.TryParseExact(input, "yyyy-MM-dd HH:mm", null, System.Globalization.DateTimeStyles.None, out DateTime date))
            {
                Console.Write("Invalid date format. Please enter a date (yyyy-MM-dd HH:mm):");
                input = Console.ReadLine();
            }
            return input;
        }
        static void DateFormatting(DateTime[] datetimes, string[] names)
        {
            Console.Write("Enter the session name:");
            string firstSessionName = Console.ReadLine();
            int index = Array.FindIndex(names, name => name.Equals(firstSessionName, StringComparison.OrdinalIgnoreCase));

            if (index != -1)
            {
                Console.WriteLine($"{datetimes[index].ToString("dd-MM-yyyy")}");
                Console.WriteLine($"{datetimes[index].ToString("dd/MM/yyyy")}");
                Console.WriteLine($"{datetimes[index].ToString("dd MMMM yyyy")}");
                Console.WriteLine($"{datetimes[index].ToString("dddd")}, {datetimes[index].ToString("dd MMMM yyyy")}");
                Console.WriteLine($"{datetimes[index].ToString("HH:mm tt")}");
            }
        }
        static void FindtheNextSession(DateTime[] dates, string[] names)
        {
            DateTime currentDate = DateTime.Now;

            for (int i = 0; i < names.Length; i++)
            {
                if (dates[i] >= currentDate)
                {
                    Console.WriteLine($"{names[i]} - Next session");
                    Console.WriteLine($"{dates[i].ToString("dd MMMM yyyy")}");
                    Console.WriteLine($"{dates[i].ToString("HH:mm tt")}");

                    Console.WriteLine();
                    TimeSpan difference = currentDate - dates[i];
                    Console.WriteLine($"{difference.Days} days");
                    Console.WriteLine($"{difference.TotalHours} Hours");
                }

                else
                {
                    Console.WriteLine($"{names[i]} - Past Session");
                }
            }
        }
        static void PastandUpcomingSessions(DateTime[] dates, string[] names)
        {
            DateTime currentDate = DateTime.Now;

            for (int i = 0; i < names.Length; i++)
            {
                if (dates[i] >= currentDate)
                {
                    Console.WriteLine($"{names[i]} - Upcoming Session");
                }
                else
                {
                    Console.WriteLine($"{names[i]} - Past Session");
                }
            }
        }
        static void DateDifference(string[] names, DateTime[] dates)
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
            Console.WriteLine("----------------------------");
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
        static void SearchForIndexAndDuration(string[] sessionNames, int[] sessionDurations, out int index, out int duration)
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
        static double GetAverageDuration(int[] sessionDurations, int totalDuration)
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

            string found = Array.Find(names, name => name.Equals(sessionName, StringComparison.OrdinalIgnoreCase));

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

            int index = Array.IndexOf(names, sessionName);

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
            for (int i = 0; i < names.Length; i++)
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


            Console.WriteLine("===================================\r\n");
            Console.WriteLine("Academy Schedule Analyzer");
            Console.WriteLine("===================================\r\n");

            Console.WriteLine("1. Display all sessions\r\n");
            Console.WriteLine("2. Search for a session\r\n");
            Console.WriteLine("3. Sort session names\r\n");
            Console.WriteLine("4. Reverse session names\r\n");
            Console.WriteLine("5. Find session index\r\n");
            Console.WriteLine("6. Check if session exists\r\n");
            Console.WriteLine("7. Show duration statistics\r\n");
            Console.WriteLine("8. Show session date details\r\n");
            Console.WriteLine("9. Show past and upcoming sessions\r\n");
            Console.WriteLine("10. Find next session\r\n");
            Console.WriteLine("11. Compare two session dates\r\n");
            Console.WriteLine("12. Read and validate a custom date\r\n");
            Console.WriteLine("13. Select session by index\r\n");
            Console.WriteLine("14. Validate session duration\r\n");
            Console.WriteLine("15. Generate report using string\r\n");
            Console.WriteLine("16. Generate report using StringBuilder\r\n");
            Console.WriteLine("0. Exit\r\n");

            Console.WriteLine("Choose an option:\r\n\r\n");

            string input = Console.ReadLine();

            while (input != "0")
            {
                switch (input)
                {
                    case "1":
                        DisplayAllSessions(sessionNames, sessionDates, sessionDurations);
                        break;
                    case "2":
                        SearchforaSession(sessionNames, sessionDates, sessionDurations);
                        break;
                    case "3":
                        SortSessionNames(sessionNames);
                        break;
                    case "4":
                        ReverseSessionNames(sessionNames);
                        break;
                    case "5":
                        FindSessionIndex(sessionNames);
                        break;
                    case "6":
                        CheckIfaSessionExists(sessionNames);
                        break;
                    case "7":
                        int totalDuration = GetTotalDuration(sessionDurations);
                        Console.WriteLine($"Total duration of all sessions: {totalDuration} minutes");
                        break;
                    case "8":
                        SessionDateDetails(sessionNames, sessionDates, sessionDurations);
                        break;
                    case "9":
                        PastandUpcomingSessions(sessionDates, sessionNames);
                        break;
                    case "10":
                        FindtheNextSession(sessionDates, sessionNames);
                        break;
                    case "11":
                        DateDifference(sessionNames, sessionDates);
                        break;
                    case "12":
                        string customDate = ReadandValidateADate(sessionDates);
                        Console.WriteLine($"Custom date entered: {customDate}");
                        break;
                    case "13":
                        string foundSession = FindASession(sessionNames);
                        Console.WriteLine($"Found session: {foundSession}");
                        break;
                    case "14":
                        ValidatesASessionDuration(sessionDurations);
                        break;
                    case "15":
                        BuildAScheduleReportUsingString(sessionNames, sessionDates, sessionDurations);
                        break;
                    case "16":
                        BuildtheSameReportUsingStringBuilder(sessionNames, sessionDates, sessionDurations);
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }

                Console.WriteLine("\r\nChoose another option or enter 0 to exit:\r\n");
                input = Console.ReadLine();








            }
        }
    }
}
