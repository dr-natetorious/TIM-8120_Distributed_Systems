using SharedDefinition;
using System;
using System.Diagnostics;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;

namespace RemotingClient
{
    class Program
    {
        static void Main()
        {
            TcpChannel chan = new TcpChannel();
            ChannelServices.RegisterChannel(chan,false);
            // Create an instance of the remote object
            var shared = (MySharedThing)Activator.GetObject(
              typeof(MySharedThing), "tcp://localhost:8080/HelloWorld");

            Console.WriteLine($"The current processid is: {Process.GetCurrentProcess().Id}");
            Console.WriteLine($"The remote process is: {shared.GetProcessId()}");
            Console.ReadLine();
        }
    }
}
