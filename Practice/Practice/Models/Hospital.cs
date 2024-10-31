namespace Practice.Models;
internal class Hospital
{
    private readonly List<Appointment> _appointment;
    public Hospital()
    {
        _appointment = new List<Appointment>();
    }

    public void AddAppointment(Appointment appointment)
    {
        _appointment.Add(appointment);
    }

    public DateTime EndAppointment(int no)
    {
        Appointment? appointment = _appointment.Find(a => a.No == no);
        if (appointment == null)
        {
            throw new InvalidOperationException($"No:{no} deyerine sahib EndDate yoxdur");
        }
            return appointment.EndDate;
    }
    public Appointment? GetAppointment(int no)
    {
        Appointment? appointment = _appointment.Find(a => a.No == no);
        if (appointment != null)
        {
            throw new InvalidOperationException($"No:{no} deyerine sahib appointment yoxdur");
        }
        return appointment;
    }
    public List<Appointment> GetAllAppointments()
    {
        
        return _appointment;
    }

    public void  GetWeeklyAppointments()
    {
       var weeklyApp= _appointment.FindAll(w => w.EndDate.AddDays(-7) < w.StartDate);
        foreach (Appointment appointment in weeklyApp) 
        {
            Console.WriteLine(appointment);
        }
    }

    public void GetTodaysAppointments()
    {
        var todayApp = _appointment.FindAll(t => (t.EndDate - t.StartDate).TotalHours<=24);
        foreach(Appointment appointment in todayApp)
        {
            Console.WriteLine(appointment);
        }
    }
    public void GetAllContinuingAppointments()
    {
        var contiuningApp= _appointment.FindAll(c => c.EndDate>DateTime.Now);
        foreach (Appointment appointment in contiuningApp)
        {
            Console.WriteLine(appointment);
        }
    }
}
