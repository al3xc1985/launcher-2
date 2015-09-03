using System.Net.NetworkInformation;

namespace launcher.Server
{
    class ServerStatus
    {
        public static string PingHost(string nameOrAddress)
        {
            var p = new Ping();
            var r = p.Send(nameOrAddress);

            if (r != null && r.Status == IPStatus.Success)
            {
                return r.RoundtripTime + " ms" + "\n";
            }
            else
                return "";
        }
    }
}
