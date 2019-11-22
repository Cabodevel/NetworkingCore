using System.Collections.Generic;
using System.Net;

namespace NetworkingCore
{
    public class DnsUtils
    {
        public IEnumerable<string> SolveName(string name)
        {
            var domainEntry = Dns.GetHostEntry(name);
            foreach (var ip in domainEntry.AddressList)
                yield return ip.ToString();
        }
        public string SolveIp(string ip)
        {
            var domainEntryByAddress = Dns.GetHostEntry(ip);
            return domainEntryByAddress.HostName;
        }
    }
}
