using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceModel;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using WCFService;

namespace WindowsServiceHost
{
    public partial class EmployeeWindowsService : ServiceBase
    {
        ServiceHost host;
        public EmployeeWindowsService()
        {
            InitializeComponent();
            host = new ServiceHost(typeof(IEmployeeService));
        }

        protected override void OnStart(string[] args)
        {
            host.Open();
        }

        protected override void OnStop()
        {
            host.Close();
        }
    }
}
