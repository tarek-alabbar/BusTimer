namespace BusTimer.Models
{
    public class DepartureModel
    {
        public string stop_id { get; set; }
        public string service_name { get; set; }
        public string destination { get; set; }
        public string departure_time { get; set; }
        public int departure_time_unix { get; set; }
        public int minutes { get; set; }
        public bool real_time { get; set; }
        public bool diverted { get; set; }
    }

}
