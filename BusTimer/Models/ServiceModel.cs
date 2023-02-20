namespace BusTimer.Models
{
    public class ServiceModel
    {
        public string service_name { get; set; }
        public DepartureModel[] departures { get; set; }
        public int first_departure { get; set; }
    }

}
