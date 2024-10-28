namespace DatetimeException
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MeetingSchedule meetingSchedule = new MeetingSchedule(3);
            try
            {
                meetingSchedule.SetMeeting("Cavadov Murad", new DateTime(2024, 11, 1, 9, 0, 0), new DateTime(2024, 11, 1, 10, 0, 0));
                meetingSchedule.SetMeeting("Cavadov Yunis", new DateTime(2024, 11, 1, 10, 30, 0), new DateTime(2024, 11, 1, 11, 30, 0));
                meetingSchedule.SetMeeting("Cavadov Murad", new DateTime(2024, 11, 1, 10, 0, 0), new DateTime(2024, 11, 1, 11, 0, 0));
            }
            catch (ReservedDateInterval ex)
            {
                Console.WriteLine($"Meeting conflict: {ex.Message}");
            }
            catch (WrongDateInterval ex)
            {
                Console.WriteLine($"Meeting conflict: {ex.Message}");
            }

            try
            {

                meetingSchedule.SetMeeting("Cavadov Elmar", new DateTime(2024, 11, 2, 14, 0, 0), new DateTime(2024, 11, 2, 13, 0, 0));
            }
            catch (ReservedDateInterval ex)
            {
                Console.WriteLine($"Meeting conflict: {ex.Message}");
            }
            catch (WrongDateInterval ex)
            {
                Console.WriteLine($"Invalid date interval: {ex.Message}");
            }
        }
    }
}
