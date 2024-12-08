using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;

namespace SystemMonitor.Api.Models
{
    public record class HostInfo(string HostName, string HostAddr)
    {
        static private string ipAddr;
        private static string IPAddress
        {
            get
            {
                if (string.IsNullOrEmpty(ipAddr))
                {
                    var addrs = from ni in NetworkInterface.GetAllNetworkInterfaces()
                                where ni.OperationalStatus == OperationalStatus.Up
                                let properties = ni.GetIPProperties()
                                where properties.GatewayAddresses.Any(p => p.Address.AddressFamily == AddressFamily.InterNetwork)
                                from addrInfo in properties.UnicastAddresses
                                where addrInfo.Address.AddressFamily == AddressFamily.InterNetwork
                                select addrInfo.Address.ToString();

                    ipAddr = addrs.FirstOrDefault();
                }
                return ipAddr;
            }
        }

        public static HostInfo GetHostInfo() => new HostInfo(
            Environment.MachineName,
            IPAddress
        );
    }
}