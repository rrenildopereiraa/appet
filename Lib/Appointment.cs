namespace Lib
{
    public class Appointment
    {
        public int Id { get; set; }
        public string ClientName { get; set; }
        public string VetName { get; set; }
        public DateTime AppointmentDateTime { get; set; }
        public string Notes { get; set; }

        public override string ToString()
        {
            return $"{Id}: {ClientName} - {VetName} ({AppointmentDateTime})";
        }
    }
}