using System.Collections;
using System.ComponentModel;

namespace Jaorszek.ProofOfConcept.MyNewService
{
    [RunInstaller(true)]
    public partial class ProjectInstaller : System.Configuration.Install.Installer
    {
        public ProjectInstaller()
        {
            InitializeComponent();
        }

        protected override void OnBeforeInstall(IDictionary savedState)
        {
            //            string parameter = "MySource1\" \"MyLogFile1";
            //            System.Runtime.Remoting.Contexts.Context.Parameters["assemblypath"] = "\"" + System.Runtime.Remoting.Contexts.Context.Parameters["assemblypath"] + "\" \"" + parameter + "\"";
            //            base.OnBeforeInstall(savedState);
        }

    }

}
