using SharedDefinition;
using System;
using System.Diagnostics;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Threading;

namespace Remoting.net
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"The current processid is: {Process.GetCurrentProcess().Id}");

            MySharedThing mySharedThing = new MySharedThing();
            TcpChannel channel = new TcpChannel(8080);
            ChannelServices.RegisterChannel(channel, false);
            RemotingConfiguration.RegisterWellKnownServiceType(
               typeof(MySharedThing), "HelloWorld",
               WellKnownObjectMode.Singleton);

            while(true)
            {
                Thread.Sleep(TimeSpan.FromSeconds(1));
            }
        }
    }
}
