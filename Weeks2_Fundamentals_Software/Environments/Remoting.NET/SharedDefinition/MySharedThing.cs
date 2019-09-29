using System;
using System.Diagnostics;

namespace SharedDefinition
{
    public class MySharedThing : MarshalByRefObject
    {
        public int GetProcessId()
        {
            return Process.GetCurrentProcess().Id;
        }
    }
}
