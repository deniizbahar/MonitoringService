using System.ServiceProcess;
using Serilog.Events;
// log dosyasını import et
using Günlük;

namespace MockService
{
    static class Program
    {
        static void Main()
        {
            ServiceBase[] ServicesToRun;
            ServicesToRun = new ServiceBase[]
            {
                new Service1()
            };
            ServiceBase.Run(ServicesToRun);
        }
    }
}
