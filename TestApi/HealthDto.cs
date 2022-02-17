namespace TestApi
{
    public class HealthDto
    {
        public string ServerId { get; }
        public string LocalIp { get; }
        public string LocalPort { get; }

        public HealthDto(
            string serverId,
            string localIp,
            string localPort)
        {
            ServerId = serverId;
            LocalIp = localIp;
            LocalPort = localPort;
        }
    }
}
