namespace UptimeBoard.RequestServer.Models
{
    public class DeviceViewModel
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public int RequestTimeout { get; set; }
        public RequestType Type { get; set; }
    }

    public enum RequestType : int
    {
        Ping = 0,
        Get = 1,
        Post = 2
    }
}