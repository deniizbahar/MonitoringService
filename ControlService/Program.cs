using System.ServiceProcess;

namespace ControlService
{
    static class Program
    {
        static void Main()
        {
            ServiceBase[] ServicesToRun;
            ServicesToRun = new ServiceBase[]
            {
                new MyService()
            };
            ServiceBase.Run(ServicesToRun);
        }
    }
}
