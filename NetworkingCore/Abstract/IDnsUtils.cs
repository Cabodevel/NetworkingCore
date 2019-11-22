using System;
using System.Collections.Generic;
using System.Text;

namespace NetworkingCore.Abstract
{
    public interface IDnsUtils
    {
        IEnumerable<string> SolveName(string name);
        string SolveIp(string ip);
    }
}
