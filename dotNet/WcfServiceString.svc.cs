using Atomus.Diagnostics;
using System;

namespace Atomus.Service
{
    public class WcfServiceString : IServiceString
    {
        string IServiceString.Request(string data)
        {
            //return (new ServerStringAdapter() as IServiceString).Request(data);
            return (this.CreateInstance("ServerAdapter") as IServiceString).Request(data);
        }
    }
}
