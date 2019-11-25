using System.Diagnostics;
using System.ServiceProcess;
using System.Timers;


namespace MyNewService
{
    public partial class MyNewService : ServiceBase
    {
        private int eventId = 1;

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
            eventLog1.WriteEntry("In OnStart");
            Timer timer = new Timer
            {
                Interval = 60000
            };
            timer.Elapsed += new ElapsedEventHandler(this.OnTimer);
            timer.Start();
        }
        public void OnTimer(object sender, ElapsedEventArgs args)
        {
            // TODO: Insert monitoring activities here.
            eventLog1.WriteEntry("Monitoring the System", EventLogEntryType.Information, eventId++);
        }

        protected override void OnStop()
        {
            eventLog1.WriteEntry("In OnStop.");
        }
    }
}
