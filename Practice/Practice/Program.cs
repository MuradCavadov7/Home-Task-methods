using Practice.Models;

namespace Practice;

internal class Program
{
    static void Main(string[] args)
    {
        Hospital hospital = new Hospital();
        

        Console.WriteLine(

                   """ 
        Bütün məlumatları doldurmadan obyekt yaratmaq olmasın.
        1. Appointment yarat
        2. Appointment-i bitir
        3. Bütün appointment-lərə bax
        4. Bu həftəki appointment-lərə bax
        5. Bugünki appointment-lərə bax
        6. Bitməmiş appointmentlərə bax
        7. Menudan çıx
        """

                   );

        int choose = 0;
        bool isContinue = true;
        while (isContinue)
        {

            Console.Write("\nZehmet olmasa 1 ve 7 araliginda deyer gonderin:");
            choose = Convert.ToInt32(Console.ReadLine());

            switch (choose)
            {
                case 1:
                    {
                        Appointment appointments = new Appointment(11, "Murad", "Mucize Doktor", new DateTime(2024, 11, 1), new DateTime(2024, 11, 9));
                        Appointment appointments1 = new Appointment(15, "Yunis", "Sanjay Gupta", new DateTime(2024, 11, 1), new DateTime(2024, 11, 2));
                        Appointment appointments2 = new Appointment(17, "Elmar", "Xelil Doktor", new DateTime(2024, 11, 1), new DateTime(2024, 11, 1));
                        hospital.AddAppointment(appointments);
                        hospital.AddAppointment(appointments1);
                        hospital.AddAppointment(appointments2);
                        Console.WriteLine(appointments);
                        Console.WriteLine(appointments1);
                        Console.WriteLine(appointments2);
                        break;
                    }

                case 2:
                    int no =int.Parse(Console.ReadLine());
                    Console.WriteLine(hospital.EndAppointment(no));
                    
                    break;

                case 3:
                    foreach(Appointment appointment in hospital.GetAllAppointments())
                    Console.WriteLine(appointment);
                    break;

                case 4:
                    hospital.GetWeeklyAppointments();
                    break;

                case 5:
                    hospital.GetTodaysAppointments();
                    break;

                case 6:
                    hospital.GetAllContinuingAppointments();
                    break;
                case 7:
                    Console.WriteLine("Menyudan cix");
                    isContinue = false;
                    break;
                default:
                    Console.WriteLine("Duzgun reqem daxil edilmedi!\n");
                    Console.WriteLine(

           """ 
        1. Appointment yarat
        2. Appointment-i bitir
        3. Bütün appointment-lərə bax
        4. Bu həftəki appointment-lərə bax
        5. Bugünki appointment-lərə bax
        6. Bitməmiş appointmentlərə bax
        7. Menudan çıx
        """

           );
                    break;
            }
        }
    }
}
