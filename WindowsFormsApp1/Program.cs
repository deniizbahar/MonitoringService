using ControlService;
using MainForm;
using MockService;
using System;
using System.Windows.Forms;

namespace MonitoringService
{
    static class Program
    {
        /// <summary>
        /// Uygulamanın ana giriş noktası.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Service1 mockService = new Service1();
            MyService myService = new MyService();
            Application.Run(new Form2(mockService, myService));
        }
    }
}