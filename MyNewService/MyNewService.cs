using System.Diagnostics;
using System.ServiceProcess;

namespace MyNewService
{
    public partial class MyNewService : ServiceBase
    {
        public MyNewService()
        {
            InitializeComponent();
            eventLog1 = new System.Diagnostics.EventLog();
            if (!EventLog.SourceExists("MySource")) { EventLog.CreateEventSource("MySource", "MyNewLog"); }

            eventLog1.Source = "MySource";
            eventLog1.Log = "MyNewLog";

        }

        protected override void OnStart(string[] args)
        {
        }

        protected override void OnStop()
        {
        }
    }
}
