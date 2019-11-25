using System.ServiceProcess;

namespace MyNewService
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main(string[] args)
        {
            ServiceBase[] ServicesToRun;
            ServicesToRun = new ServiceBase[]
            {
                new MyNewService(args)
            };
            ServiceBase.Run(ServicesToRun);
        }

        //Instal Service:
        //installutil MyNewService.exe

        //Uninstall service:
        //installutil.exe /u MyNewService.exe
    }
}
