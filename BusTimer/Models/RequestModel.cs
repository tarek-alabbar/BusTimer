namespace BusTimer.Models
{
    public class RequestModel
    {
        public StopModel stop { get; set; }
        public ServiceModel[] services { get; set; }
    }

}
