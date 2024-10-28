namespace DatetimeException;

public class Meeting
{
    public DateTime FromDate { get; set; }
    public DateTime ToDate { get; set; }
    public string FullName { get; set; }
    public Meeting(DateTime fromDate, DateTime toDate, string fullName)
    {
        FromDate = fromDate;
        ToDate = toDate;
        FullName = fullName;
    }
}
public class MeetingSchedule
{
    public static Meeting[] Meetings { get; set; }
    int meetingCount = 0;
    public MeetingSchedule(int meeting)
    {
        Meetings = new Meeting[meeting];
    }
    public void SetMeeting(string fullname, DateTime from, DateTime to)
    {
        if (from >= to)
        {
            throw new WrongDateInterval($"{from} tarixi {to} dan boyuk ola bilmez");
        }

        for (int i = 0; i < meetingCount; i++)
        {
            if (from < Meetings[i].ToDate && to > Meetings[i].FromDate)
            {
                throw new ReservedDateInterval("Gonderilen tarix intervalda movcuddur");
            }

        }
        if (meetingCount < Meetings.Length)
        {
            Meetings[meetingCount++] = new Meeting(from, to, fullname);
            Console.WriteLine($"Yeni gorus{fullname} {from} {to} elave olundu");
        }

    }

}


public class ReservedDateInterval : Exception
{
    public ReservedDateInterval(string message) : base(message) { }
}
public class WrongDateInterval : Exception
{
    public WrongDateInterval(string message) : base(message) { }
}